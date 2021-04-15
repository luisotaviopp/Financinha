using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class BankOperation : MonoBehaviour
{
    public InputField valueInput;
    public string operation = "w2s";

    public void GetInfo()
    {
        StartCoroutine(PostLog(valueInput.text, operation));
    }

    IEnumerator PostLog(string post_value, string post_operation)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
        form.AddField("post_value", post_value);
        form.AddField("post_operation", post_operation);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.BANK_OPERATION, form);

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Zerando Campos
            valueInput.text = "";

            GameObject.Find("UIManager").GetComponent<UIManager>().OpenBancoDaCasa();
        }
    }

    public void setOperation(string op)
    {
        this.operation = op;
        Debug.Log(this.operation);
    }
}
