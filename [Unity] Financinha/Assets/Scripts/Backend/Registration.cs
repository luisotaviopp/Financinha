using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public string registrationURL;

    public InputField loginInput;
    public InputField passInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(Upload(loginInput.text, passInput.text));
    }

    IEnumerator Upload(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        UnityWebRequest www = UnityWebRequest.Post(registrationURL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Retorna o estado do login
            statusDisplay.text = www.downloadHandler.text;
        }
    }
}