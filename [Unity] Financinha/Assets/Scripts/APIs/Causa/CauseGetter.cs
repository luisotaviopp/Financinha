using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CauseGetter : MonoBehaviour
{
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(GetCause());
    }

    IEnumerator GetCause()
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_CAUSE_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "Erro ao Logar";
        }
        else
        {
           
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            CauseList causeList = JsonUtility.FromJson<CauseList>("{\"causes\":" + result + "}");

            //Texto de Retorno
            statusDisplay.text = www.downloadHandler.text;
       
            Debug.Log(www.downloadHandler.text);

            statusDisplay.text = "";

            foreach (Cause cause in causeList.causes)
            {
                statusDisplay.text += cause.name + "\n" + cause.description + "\nR$" + cause.value + "\n\n";
            }
        }
    }
}
