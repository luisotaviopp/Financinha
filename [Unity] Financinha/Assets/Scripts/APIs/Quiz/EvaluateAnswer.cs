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
		StartCoroutine(EvaluateAnswerCoroutine(answerInput.text));
	}
	
	IEnumerator EvaluateAnswerCoroutine(string rate)
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
			StartCoroutine(GetScoreCorroutine());
		}
	}

	IEnumerator GetScoreCorroutine()
	{
		// Inicia o form e pega o token ativo
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
		form.AddField("post_level", PlayerPrefs.GetString("notification_question_level"));

		Debug.Log(PlayerPrefs.GetInt("id_aprendiz"));
		Debug.Log(PlayerPrefs.GetString("notification_question_level"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_SCORE, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error);
		}
		else
		{
			//Retorna o estado do login
			string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
			QuizScoreList listaScore = JsonUtility.FromJson<QuizScoreList>("{\"scoreList\":" + result + "}");

			Debug.Log(www.downloadHandler.text);
			
		   // Debug.Log($"Level: {listaValues.menuValues[0].level}");

			if (listaScore.scoreList[0].nota_total >= 7)
			{
				StartCoroutine(IncreaseLevel());
			}
			else
			{
				Debug.Log("REPETIU");
			}
		}
	}

    IEnumerator IncreaseLevel()
    {
        // Inicia o form e pega o token ativo
        WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.INCREASE_LEVEL_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
			Debug.Log(www.downloadHandler.text);
//            PlayerPrefs.SetInt("level", int.Parse(www.downloadHandler.text));
  //          PlayerPrefs.Save();
        }
    }
}
