using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public static class BtnRegra
{
	public static void AddEvent<T> (this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener(delegate ()
		{
			OnClick(param);
		});
	}
}

public class GetRules : MonoBehaviour
{
	public RulesList rulesList;
	public Text saldoValue;

	private void OnEnable()
	{
		GetInfo();
	}

	public void GetInfo()
	{
		StartCoroutine(GetRulesCorroutine());
	}

	IEnumerator GetRulesCorroutine()
	{
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.LIST_RULES_URL, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error); 
		}
		else
		{
			//Retorna o estado do login
			string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);

			rulesList = JsonUtility.FromJson<RulesList>("{\"rules\":" + result + "}");

			GameObject template = transform.GetChild(0).gameObject;
			GameObject g;

			Debug.Log(www.downloadHandler.text);

			float semanada = PlayerPrefs.GetFloat("rules_amount");

			
			// Se já tiver carregado a primeira lista, apaga todos os ítens antes de recarregar os ítens vindos da API.
			if (this.transform.childCount > 1)
			{
				for (int i = 1; i < this.transform.childCount; i++)
				{
					Destroy(transform.GetChild(i).gameObject);
				}
				Debug.Log("Terminou de re-alimentar a lista");
			}


			// Carrega os ítens da API
			for (int i = 0; i < rulesList.rules.Count; i++)
			{
				g = Instantiate(template, transform);

				g.transform.GetChild(1).GetComponent<Text>().text = rulesList.rules[i].quantity.ToString();

				//Pega o Text dessa regra para poder mostrar a quantidade assim que ela mudar.
				rulesList.rules[i].quantityDisplay = g.transform.GetChild(1).GetComponent<Text>();

				g.transform.GetChild(3).GetComponent<Text>().text = rulesList.rules[i].name;
				
				// Adiciona o sinal de - antes do R$ caso o valor seja negativo.
				// Aplica o -1 apenas no valor que será mostrado, não no valor que será usado para calcular o saldo depois.
				if (rulesList.rules[i].value > 0)
				{				
					g.transform.GetChild(5).GetComponent<Text>().text = "R$" + rulesList.rules[i].value.ToString();
					g.transform.GetChild(6).GetComponent<Text>().text = "R$" + (rulesList.rules[i].quantity*rulesList.rules[i].value).ToString();
				}
				else 
				{
					g.transform.GetChild(5).GetComponent<Text>().text = "-R$" + (rulesList.rules[i].value * -1).ToString();
					g.transform.GetChild(6).GetComponent<Text>().text = "-R$" + (rulesList.rules[i].quantity*rulesList.rules[i].value*-1).ToString();
				}

				rulesList.rules[i].totalValueDisplay =g.transform.GetChild(6).GetComponent<Text>();

				g.transform.GetChild(0).GetComponent<Button>().AddEvent(i, RegraDecreased);
				g.transform.GetChild(2).GetComponent<Button>().AddEvent(i, RegraIncreased);
				g.transform.GetChild(4).GetComponent<Button>().AddEvent(i, RegraDeleted);

				semanada +=  rulesList.rules[i].value;
			}

			Destroy(template.gameObject);

			//Texto do saldo.
			if (PlayerPrefs.HasKey("rules_amount"))
			{
				saldoValue.text = "R$"+ semanada.ToString();
			}
			else
			{
				saldoValue.text = "0.00";
			}
		}
	}

	void RegraDecreased (int itemIndex)
	{
		int newValue = rulesList.rules[itemIndex].quantity-=1;                  //Atualiza o valor na lista
		rulesList.rules[itemIndex].quantityDisplay.text = newValue.ToString();  //Renderiza o novo valor na tela

		// Adiciona o sinal de - antes do R$ caso o valor seja negativo.
		// Aplica o -1 apenas no valor que será mostrado, não no valor que será usado para calcular o saldo depois.
		if (rulesList.rules[itemIndex].value > 0) 
		{		
			rulesList.rules[itemIndex].totalValueDisplay.text = "R$" + (rulesList.rules[itemIndex].quantity*rulesList.rules[itemIndex].value).ToString();
		} 
		else 
		{
			rulesList.rules[itemIndex].totalValueDisplay.text = "-R$" + (rulesList.rules[itemIndex].quantity*rulesList.rules[itemIndex].value * -1).ToString();
		}

		//ATUALIZAR SALDO/SEMANADA

		// Manda o valor atual para o servidor
		UpdateRuleQuantityOnDB(newValue, rulesList.rules[itemIndex].id);

		Debug.Log("Diminui " + rulesList.rules[itemIndex].name);
	}

	void RegraIncreased (int itemIndex)
	{
		int newValue = rulesList.rules[itemIndex].quantity+=1;
		rulesList.rules[itemIndex].quantityDisplay.text = newValue.ToString();

		rulesList.rules[itemIndex].totalValueDisplay.text = "R$" + (rulesList.rules[itemIndex].quantity*rulesList.rules[itemIndex].value).ToString();

		// Adiciona o sinal de - antes do R$ caso o valor seja negativo.
		// Aplica o -1 apenas no valor que será mostrado, não no valor que será usado para calcular o saldo depois.
		if (rulesList.rules[itemIndex].value > 0)
		{		
			rulesList.rules[itemIndex].totalValueDisplay.text = "R$" + (rulesList.rules[itemIndex].quantity*rulesList.rules[itemIndex].value).ToString();
		}
		else 
		{
			rulesList.rules[itemIndex].totalValueDisplay.text = "-R$" + (rulesList.rules[itemIndex].quantity*rulesList.rules[itemIndex].value * -1).ToString();
		}

		//ATUALIZAR SALDO/SEMANADA

		// Manda o valor atual para o servidor
		UpdateRuleQuantityOnDB(newValue, rulesList.rules[itemIndex].id);

		Debug.Log("Aumenta: " + rulesList.rules[itemIndex].name);
	}

	void RegraDeleted (int itemIndex)
	{
		StartCoroutine(DeleteRegra(rulesList.rules[itemIndex].id));
		Debug.Log("Deleta: " + rulesList.rules[itemIndex].name);

		// Destroi o objeto da cena;
		Destroy(rulesList.rules[itemIndex].quantityDisplay.transform.parent.gameObject);
	}

	void UpdateRuleQuantityOnDB(int quantity, int ruleId)
	{
		StartCoroutine(UpdateRuleQuantityCorroutine(quantity, ruleId));
	}

	IEnumerator UpdateRuleQuantityCorroutine(int quantity, int ruleId)
	{
		WWWForm form = new WWWForm();
		form.AddField("post_token", PlayerPrefs.GetInt("token"));
		form.AddField("post_quantity", quantity);
		form.AddField("post_rule_id", ruleId);

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.UPDATE_RULE_QUANTITY_URL, form);
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

	IEnumerator DeleteRegra(int ruleId)
	{
		WWWForm form = new WWWForm();
		form.AddField("post_rule_id", ruleId);

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.DELETE_RULE_URL, form);
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