using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class TokenValidator : MonoBehaviour
{
    public Text tokenDisplay;
    public string link;

    void Start()
    {
        StartCoroutine(GetToken());
    }

    IEnumerator GetToken()
    {
        UnityWebRequest www = UnityWebRequest.Get(link);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Pega o token retornado pela API
            string token = www.downloadHandler.text;
            tokenDisplay.text = token;
        }
    }
}
