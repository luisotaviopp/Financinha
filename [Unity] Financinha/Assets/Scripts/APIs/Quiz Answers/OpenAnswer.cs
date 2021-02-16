using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class OpenAnswer : MonoBehaviour
{
    public InputField answerInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(Upload(answerInput.text));
    }

    IEnumerator Upload(string answer)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));
        form.AddField("post_answer", answer);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.INSERT_OPEN_ANSWER, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Retorna o estado do registro
            statusDisplay.text = www.downloadHandler.text;
            answerInput.text = "";
        }
    }
}
