using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ExtratoGetter : MonoBehaviour
{
    //public Text statusDisplay;
    private void Start()
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
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.EXTRATO_URL, form);
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
            TransacaoList listaDeTransacoes = JsonUtility.FromJson<TransacaoList>("{\"transacao\":" + result + "}");

            //statusDisplay.text = "";

            GameObject template = transform.GetChild(0).gameObject;
            GameObject g;

            for (int i = 0; i < listaDeTransacoes.transacao.Count; i++)
            {
                g = Instantiate(template, transform);
                g.transform.GetChild(0).GetComponent<Text>().text = listaDeTransacoes.transacao[i].created_at;
                g.transform.GetChild(1).GetComponent<Text>().text = listaDeTransacoes.transacao[i].reason;
                g.transform.GetChild(3).GetComponent<Text>().text = listaDeTransacoes.transacao[i].value.ToString();
            }

            Destroy(template.gameObject);
        }
    }
}
