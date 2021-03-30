using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetQuestionToEvaluate : MonoBehaviour
{
	public Text answerTxt;

	private void OnEnable()
	{
		StartCoroutine(GetQuestionCoroutine());
	}
	
	IEnumerator GetQuestionCoroutine()
	{
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
		form.AddField("post_level", PlayerPrefs.GetString("notification_question_level"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_OPEN_ANSWER, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error); 
		}
		else
		{
			Debug.Log(www.downloadHandler.text);
			answerTxt.text = www.downloadHandler.text;
		}
	}
}
