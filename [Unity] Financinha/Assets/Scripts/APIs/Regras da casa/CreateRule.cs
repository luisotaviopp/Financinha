using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CreateRule : MonoBehaviour
{
    public InputField nameInput;
    public InputField descriptionInput;
    public InputField valueInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(Upload(nameInput.text, descriptionInput.text, valueInput.text));
    }

    IEnumerator Upload(string name, string description, string value)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));
        form.AddField("post_name", name);
        form.AddField("post_description", description);
        form.AddField("post_value", value);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.CREATE_RULE_URL, form);
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
