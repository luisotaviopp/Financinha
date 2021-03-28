using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ExtratoBancoGetter : MonoBehaviour
{
	[SerializeField] TransacaoList listaDeTransacoes;

	//public Text statusDisplay;
	private void OnEnable()
	{
		GetInfo();
	}

	public void GetInfo()
	{
		StartCoroutine(GetExtratoList());
	}

	IEnumerator GetExtratoList()
	{
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.BANK_EVENTS_URL, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error);
			//statusDisplay.text = www.downloadHandler.text;
		}
		else
		{
			//Retorna o estado do login
			string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
			listaDeTransacoes = JsonUtility.FromJson<TransacaoList>("{\"transacao\":" + result + "}");

			// Se já tiver carregado a primeira lista, apaga todos os ítens antes de recarregar os ítens vindos da API.
			if (this.transform.childCount > 1)
			{
				for (int i = 1; i < this.transform.childCount; i++)
				{
					Destroy(transform.GetChild(i).gameObject);
				}
				Debug.Log("Terminou de re-alimentar a lista");
			}

			if (listaDeTransacoes.transacao.Count > 0)
			{
				GameObject template = transform.GetChild(0).gameObject;
				GameObject g;

				for (int i = 0; i < listaDeTransacoes.transacao.Count; i++)
				{
					g = Instantiate(template, transform);
					g.transform.GetChild(0).GetComponent<Text>().text = listaDeTransacoes.transacao[i].created_at;
					g.transform.GetChild(1).GetComponent<Text>().text = listaDeTransacoes.transacao[i].reason;
					g.transform.GetChild(3).GetComponent<Text>().text = listaDeTransacoes.transacao[i].value.ToString();

					listaDeTransacoes.transacao[i].refToDelete = g.transform.GetChild(3).GetComponent<Text>();
					g.transform.GetChild(2).GetComponent<Button>().AddEvent(i, DeleteBankEvent);
				}

				Destroy(template.gameObject);
			}
		}
	}

	void DeleteBankEvent (int itemIndex)
	{
		StartCoroutine(DeleteBankEventCoroutine(listaDeTransacoes.transacao[itemIndex].id));

		Debug.Log("Deleta: " + listaDeTransacoes.transacao[itemIndex].reason);

		// Destroi o objeto da cena;
		Destroy(listaDeTransacoes.transacao[itemIndex].refToDelete.transform.parent.gameObject);
	}

	IEnumerator DeleteBankEventCoroutine(int eventId)
	{
		WWWForm form = new WWWForm();
		form.AddField("post_event_id", eventId);

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.DELETE_BANK_EVENT_URL, form);
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
