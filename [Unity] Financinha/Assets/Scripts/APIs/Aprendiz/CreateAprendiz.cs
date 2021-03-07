using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class CreateAprendiz : MonoBehaviour
{
    public InputField nameInput;
    public InputField userInput;
    public InputField passInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(PostLog(nameInput.text, userInput.text, passInput.text));
    }

    IEnumerator PostLog(string name, string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));
        form.AddField("post_username", username);
        form.AddField("post_name", name);
        form.AddField("post_password", password);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.CREATE_APPRENDICE, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "Ops, não conseguimos registrar o aprendiz.";
        }
        else
        {
            //Texto de Retorno
            statusDisplay.text = www.downloadHandler.text;

            //Zerando Campos
            nameInput.text = "";
            userInput.text = "";
            passInput.text = "";
           
            // Fecha o painel de login.
            GameObject.Find("UIManager").GetComponent<UIManager>().OpenListaAprendizes();
        }
    }
}
