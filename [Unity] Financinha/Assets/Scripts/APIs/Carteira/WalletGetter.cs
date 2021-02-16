using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WalletGetter : MonoBehaviour
{
    public Text amountDisplay;

    public void GetAmount()
    {
        StartCoroutine(GetAmountCorroutine());
    }

    IEnumerator GetAmountCorroutine()
    {
        // Inicia o form e pega o token ativo
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.WALLET_AMOUNT_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Sempre que algo retornar como texto, basta pegar o www.downloadHandler.text, ao invés de converter o json em uma lista.
            PlayerPrefs.SetInt("level", int.Parse(www.downloadHandler.text));
            PlayerPrefs.Save();

            amountDisplay.text = "Carteira: R$" + PlayerPrefs.GetInt("level");
        }
    }
}
