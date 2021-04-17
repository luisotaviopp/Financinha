using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetHabilityProgress : MonoBehaviour
{

    [Header("Dados que vem da API.")]
    public LevelProgressorList levelProgressorList;

    [Header("Sprites dos cadeados fechados e abertos.")]
    public Sprite cadeadoVerde;
	public Sprite cadeadoVermelho;

    [Header("Botoes das fases")]
    public Button[] levelButtons;


    [Header("Cadeados que indicam se o quiz esta aberto")]
    public Image[] cadeadosQuizz;

    [Header("Cadeados que indicam se a habilidade esta aberta")]
    public Image[] cadeadosHabilidade;

    [Header("Libera o vovo na ultima fase")]
    public Image luaVovo;
    public Sprite luaVovoNave;

    [Header("Valores que devem ser posicionados dentro das nuvens")]
    public List<float> values;

    [SerializeField] private float objectiveValue = 0;
    [SerializeField] private Text[] valueTexts;

    public Button first_level_button;

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

            //Desativa todas as nuvens
            foreach (Button btn in levelButtons)
            {
                btn.interactable = false;
            }

            //Desativa todos os cadeados do quiz
            foreach (Image img in cadeadosQuizz)
            {
                img.sprite = cadeadoVermelho;
            }

            //Desativa todos os cadeados de habilidade
            foreach (Image img in cadeadosHabilidade)
            {
                img.sprite = cadeadoVermelho;
            }

            // Se o valor do objetivo ja existir...
            if (PlayerPrefs.HasKey("objective_value"))
            {
                objectiveValue = PlayerPrefs.GetFloat("objective_value");
            }
            else
            {
                objectiveValue = 10;
            }

            // Aplica o valor dividido nas nuvens e abre os cadeados em sequencia.
            float partial = objectiveValue / valueTexts.Length;
            int expoent = 1;

            foreach (var txt in valueTexts)
            {
                float partialMultiplication = partial * expoent;

                txt.text = partialMultiplication.ToString();

                values.Add(partialMultiplication);

                expoent++;
            }



            // Libera o level 01 - Se carteira for > valor do level.
            if (PlayerPrefs.GetFloat("bank_amount") > values[0])
            {
                cadeadosHabilidade[0].sprite = cadeadoVerde;
                levelButtons[0].interactable = true;
            }

            // Libera o level 02
            if (levelProgressorList.progressor[0].lvl_1_habilidade && (levelProgressorList.progressor[0].lvl_1_quiz + levelProgressorList.progressor[0].lvl_1_resp > 7))
            {
                cadeadosHabilidade[1].sprite = cadeadoVerde;
				levelButtons[1].interactable = true;
			}

            // Libera o level 03
            if (levelProgressorList.progressor[0].lvl_2_habilidade && (levelProgressorList.progressor[0].lvl_2_quiz + levelProgressorList.progressor[0].lvl_2_resp > 7))
            {
                cadeadosHabilidade[2].sprite = cadeadoVerde;
                levelButtons[2].interactable = true;
            }

            // Libera o level 04
            if (levelProgressorList.progressor[0].lvl_3_habilidade && (levelProgressorList.progressor[0].lvl_3_quiz + levelProgressorList.progressor[0].lvl_3_resp > 7))
            {
                cadeadosHabilidade[3].sprite = cadeadoVerde;
                levelButtons[3].interactable = true;
            }

            // Libera o level 05
            if (levelProgressorList.progressor[0].lvl_4_habilidade && (levelProgressorList.progressor[0].lvl_4_quiz + levelProgressorList.progressor[0].lvl_4_resp > 7))
            {
                cadeadosHabilidade[4].sprite = cadeadoVerde;
                levelButtons[4].interactable = true;
            }

            // Libera o level 06
            if (levelProgressorList.progressor[0].lvl_5_habilidade && (levelProgressorList.progressor[0].lvl_5_quiz + levelProgressorList.progressor[0].lvl_5_resp > 7))
            {
                cadeadosHabilidade[5].sprite = cadeadoVerde;
                levelButtons[5].interactable = true;
            }

            // Libera o level 07
            if (levelProgressorList.progressor[0].lvl_6_habilidade && (levelProgressorList.progressor[0].lvl_6_quiz + levelProgressorList.progressor[0].lvl_6_resp > 7))
            {
                cadeadosHabilidade[6].sprite = cadeadoVerde;
                levelButtons[6].interactable = true;
            }

            // Libera o level 08
            if (levelProgressorList.progressor[0].lvl_7_habilidade && (levelProgressorList.progressor[0].lvl_7_quiz + levelProgressorList.progressor[0].lvl_7_resp > 7))
            {
                cadeadosHabilidade[7].sprite = cadeadoVerde;
                levelButtons[7].interactable = true;
            }

            // Libera o level 09
            if (levelProgressorList.progressor[0].lvl_8_habilidade && (levelProgressorList.progressor[0].lvl_8_quiz + levelProgressorList.progressor[0].lvl_8_resp > 7))
            {
                cadeadosHabilidade[8].sprite = cadeadoVerde;
                levelButtons[8].interactable = true;
            }

            // Libera o level 10
            if (levelProgressorList.progressor[0].lvl_9_habilidade && (levelProgressorList.progressor[0].lvl_9_quiz + levelProgressorList.progressor[0].lvl_9_resp > 7))
            {
                cadeadosHabilidade[9].sprite = cadeadoVerde;
                levelButtons[9].interactable = true;
            }

            //Libera o sprite do vovo
            //if (cadeadosHabilidade[cadeadosHabilidade.Length - 1].sprite.name == "cadeado-aberto")
            //{
            //    luaVovo.sprite = luaVovoNave;
            //}







            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_1_habilidade)
            {
                cadeadosQuizz[0].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_2_habilidade)
            {
                cadeadosQuizz[1].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_3_habilidade)
            {
                cadeadosQuizz[2].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_4_habilidade)
            {
                cadeadosQuizz[3].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_5_habilidade)
            {
                cadeadosQuizz[4].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_6_habilidade)
            {
                cadeadosQuizz[5].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_7_habilidade)
            {
                cadeadosQuizz[6].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_8_habilidade)
            {
                cadeadosQuizz[7].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_9_habilidade)
            {
                cadeadosQuizz[8].sprite = cadeadoVerde;
            }

            // Verifica os cadeados do quiz 01
            if (levelProgressorList.progressor[0].lvl_10_habilidade)
            {
                cadeadosQuizz[9].sprite = cadeadoVerde;
            }

        }

        Debug.Log("Progressao carregada");
	}
}
