using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetHabilityProgress : MonoBehaviour
{
	LevelProgressorList levelProgressorList;

	public Sprite cadeadoVerde;
	public Sprite cadeadoVermelho;

	public Image[] cadeadosQuizz;

	void OnEnable()
	{
		StartCoroutine(GetHabilityProgressList());
	}

	IEnumerator GetHabilityProgressList()
	{
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_HABILITIES_LIST, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error);
		}
		else
		{
			//Retorna o estado do login
			string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
			levelProgressorList = JsonUtility.FromJson<LevelProgressorList>("{\"progressor\":" + result + "}");

			if (levelProgressorList.progressor[0].lvl_1_habilidade)
			{
				cadeadosQuizz[0].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_2_habilidade)
			{
				cadeadosQuizz[1].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_3_habilidade)
			{
				cadeadosQuizz[2].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_4_habilidade)
			{
				cadeadosQuizz[3].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_5_habilidade)
			{
				cadeadosQuizz[4].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_6_habilidade)
			{
				cadeadosQuizz[5].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_7_habilidade)
			{
				cadeadosQuizz[6].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_8_habilidade)
			{
				cadeadosQuizz[7].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_9_habilidade)
			{
				cadeadosQuizz[8].sprite = cadeadoVerde;
			}

			if (levelProgressorList.progressor[0].lvl_10_habilidade)
			{
				cadeadosQuizz[9].sprite = cadeadoVerde;
			}
		}
		Debug.Log("Carregou Level progressor");
	}
}
