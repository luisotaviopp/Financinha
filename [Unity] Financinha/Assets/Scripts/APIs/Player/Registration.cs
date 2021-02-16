using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public InputField nameInput;
    public InputField usernameInput;
    public InputField passInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(Upload(nameInput.text, usernameInput.text, passInput.text));
    }

    IEnumerator Upload(string name, string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_name", name);
        form.AddField("post_username", username);
        form.AddField("post_password", password);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.REGISTER_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Retorna o estado do registro
            statusDisplay.text = www.downloadHandler.text;
        }
    }
}