using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetHabilityProgress : MonoBehaviour
{
	public LevelProgressorList levelProgressorList;

	public Sprite cadeadoVerde;
	public Sprite cadeadoVermelho;

	public Button[] levelButtons;
	public Image[] cadeadosQuizz;

	private void Awake()
	{
		foreach (Button btn in levelButtons)
		{
			btn.interactable = false;
		}

		foreach (Image img in cadeadosQuizz)
		{
			img.sprite = cadeadoVermelho;
		}

		StartCoroutine(GetHabilityProgressList());		
	}

	void OnEnable()
	{
		foreach (Button btn in levelButtons)
		{
			btn.interactable = false;
		}

		foreach (Image img in cadeadosQuizz)
		{
			img.sprite = cadeadoVermelho;
		}

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
				levelButtons[0].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_2_habilidade)
			{
				cadeadosQuizz[1].sprite = cadeadoVerde;
				levelButtons[1].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_3_habilidade)
			{
				cadeadosQuizz[2].sprite = cadeadoVerde;
				levelButtons[2].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_4_habilidade)
			{
				cadeadosQuizz[3].sprite = cadeadoVerde;
				levelButtons[3].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_5_habilidade)
			{
				cadeadosQuizz[4].sprite = cadeadoVerde;
				levelButtons[4].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_6_habilidade)
			{
				cadeadosQuizz[5].sprite = cadeadoVerde;
				levelButtons[5].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_7_habilidade)
			{
				cadeadosQuizz[6].sprite = cadeadoVerde;
				levelButtons[6].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_8_habilidade)
			{
				cadeadosQuizz[7].sprite = cadeadoVerde;
				levelButtons[7].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_9_habilidade)
			{
				cadeadosQuizz[8].sprite = cadeadoVerde;
				levelButtons[8].interactable = true;
			}

			if (levelProgressorList.progressor[0].lvl_10_habilidade)
			{
				cadeadosQuizz[9].sprite = cadeadoVerde;
				levelButtons[9].interactable = true;
			}
		}
	}
}
