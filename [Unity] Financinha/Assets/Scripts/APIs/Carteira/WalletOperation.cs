using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WalletOperation : MonoBehaviour
{
    public InputField reasonInput;
    public InputField valueInput;
    public Text statusDisplay;
    public string operation;

    public void GetInfo()
    {
        StartCoroutine(PostLog(reasonInput.text, valueInput.text, operation));
    }

    IEnumerator PostLog(string reason, string value, string post_operation)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
        form.AddField("post_reason", reason);
        form.AddField("post_value", value);
        form.AddField("post_operation", post_operation);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.WALLET_OPERATION_URL, form);

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "Erro ao Logar";
        }
        else
        {
            //Zerando Campos Login
            reasonInput.text = "";
            valueInput.text = "";

            GameObject.Find("Canvas").GetComponent<AudioManager>().PlayCoinSound();
            GameObject.Find("UIManager").GetComponent<UIManager>().OpenCarteira();
        }
    }

    public void setOperation (string op)
    {
        this.operation = op;
        Debug.Log(this.operation);
    }
}
