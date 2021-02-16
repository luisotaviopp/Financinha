using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ExtratoGetter : MonoBehaviour
{
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(GetExtratoList());
    }

    IEnumerator GetExtratoList()
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        //Debug.Log(username + "  " + password);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.EXTRATO_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = www.downloadHandler.text;
        }
        else
        {
            //Retorna o estado do login
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            TransacaoList listaDeTransacoes = JsonUtility.FromJson<TransacaoList>("{\"transacao\":" + result + "}");

            statusDisplay.text = "";

            foreach (Transacao tr in listaDeTransacoes.transacao)
            {
                statusDisplay.text += "R$" + tr.value.ToString() + " - " + tr.type + "\n" + tr.reason + "\n\n";
            }

            Debug.Log("Level: " + PlayerPrefs.GetInt("level"));
            Debug.Log("Token: " + PlayerPrefs.GetString("token"));
        }
    }
}
