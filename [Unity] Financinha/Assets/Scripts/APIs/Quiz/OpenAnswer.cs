using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class OpenAnswer : MonoBehaviour
{
    public InputField answerInput;
//    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(Upload(answerInput.text));
    }

    IEnumerator Upload(string answer)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
		form.AddField("post_level", PlayerPrefs.GetInt("quiz_level_to_load"));
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
            //statusDisplay.text = www.downloadHandler.text;
            Debug.Log(www.downloadHandler.text);

            answerInput.text = "";
        }
    }
}
