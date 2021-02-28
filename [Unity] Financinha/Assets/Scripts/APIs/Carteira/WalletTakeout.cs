using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WalletTakeout : MonoBehaviour
{
    public InputField reasonInput;
    public InputField valueInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(PostLog(reasonInput.text, valueInput.text));
    }

    IEnumerator PostLog(string reason, string value)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));
        form.AddField("post_reason", reason);
        form.AddField("post_value", value);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.WALLET_OPERATION_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "Erro ao Logar";
        }
        else
        {
            //Texto de Retorno
            statusDisplay.text = www.downloadHandler.text;

            //Zerando Campos Login
            reasonInput.text = "";
            valueInput.text = "";
        }
    }
}
