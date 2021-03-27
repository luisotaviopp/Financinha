using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ExtratoCarteiraGetter : MonoBehaviour
{
	[SerializeField] private TransacaoList listaDeTransacoes;

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

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.WALLET_EVENTS_URL, form);
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

			//statusDisplay.text = "";

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
					g.transform.GetChild(2).GetComponent<Button>().AddEvent(i, DeleteWalletEvent);
				}

				Destroy(template.gameObject);
			}
		}
	}

	void DeleteWalletEvent (int itemIndex)
	{
		StartCoroutine(DeleteWalletEventCoroutine(listaDeTransacoes.transacao[itemIndex].id));

		Debug.Log("Deleta: " + listaDeTransacoes.transacao[itemIndex].reason);

		// Destroi o objeto da cena;
		Destroy(listaDeTransacoes.transacao[itemIndex].refToDelete.transform.parent.gameObject);
	}

	IEnumerator DeleteWalletEventCoroutine(int eventId)
	{
		WWWForm form = new WWWForm();
		form.AddField("post_event_id", eventId);

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.DELETE_WALLET_EVENT_URL, form);
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
