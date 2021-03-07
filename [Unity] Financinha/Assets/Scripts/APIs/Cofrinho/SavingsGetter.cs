using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SavingsGetter : MonoBehaviour
{
    public Text amountDisplay;

    private void Start()
    {
        GetAmount();
    }

    public void GetAmount()
    {
        StartCoroutine(GetAmountCorroutine());
    }

    IEnumerator GetAmountCorroutine()
    {
        // Inicia o form e pega o token ativo
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.SAVINGS_AMOUNT_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Sempre que algo retornar como texto, basta pegar o www.downloadHandler.text, ao invés de converter o json em uma lista.
            PlayerPrefs.SetFloat("bank_amount", float.Parse(www.downloadHandler.text));
            PlayerPrefs.Save();

            amountDisplay.text = "R$" + Math.Round(PlayerPrefs.GetFloat("bank_amount"));
        }
    }
}
