using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class EvaluateAnswer : MonoBehaviour
{
	public InputField answerInput;

	public void EvaluateAnswerOnDB()
	{
		StartCoroutine(GetQuestionCoroutine(answerInput.text));
	}
	
	IEnumerator GetQuestionCoroutine(string rate)
	{
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
		form.AddField("post_level", PlayerPrefs.GetString("notification_question_level"));
		form.AddField("post_rate", rate);

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.EVALUATE_ANSWER, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error); 
		}
		else
		{
			Debug.Log(www.downloadHandler.text);
		}
	}
}
