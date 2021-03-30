using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetNotification : MonoBehaviour
{
	public Button[] notificationButtons;

	private void OnEnable()
	{    
		foreach (Button btn in notificationButtons)
		{
			btn.interactable = false;
		}

		StartCoroutine(GetNotificationCoroutine());
	}

	IEnumerator GetNotificationCoroutine()
	{
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_NOTIFICATION, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error); 
		}
		else
		{
			PlayerPrefs.SetString("notification_question_level", www.downloadHandler.text);
			Debug.Log("Questão aberta no level: " + int.Parse(PlayerPrefs.GetString("notification_question_level")).ToString());
			notificationButtons[int.Parse(PlayerPrefs.GetString("notification_question_level"))-1].interactable = true;
		}
	}
}
