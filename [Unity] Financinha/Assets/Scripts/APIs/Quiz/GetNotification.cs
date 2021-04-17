using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetNotification : MonoBehaviour
{
	public GameObject[] notificationButtons;

	private void Awake()
	{	
		StartCoroutine(GetNotificationCoroutine());		
	}

	private void OnEnable()
	{    
		StartCoroutine(GetNotificationCoroutine());
	}

	IEnumerator GetNotificationCoroutine()
	{
        foreach(GameObject ponto in notificationButtons)
        {
            ponto.SetActive(false);
        }

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
			Debug.Log(www.downloadHandler.text);

			if (int.Parse(PlayerPrefs.GetString("notification_question_level")) > 0)
			{			
				notificationButtons[int.Parse(PlayerPrefs.GetString("notification_question_level"))-1].SetActive(true);
			}
		}
	}
}