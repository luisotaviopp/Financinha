﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class CreateObjective : MonoBehaviour
{
    public InputField giftName;
    public InputField giftValue;
    public InputField causeName;
    public Text causeValue;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(PostObjective(giftName.text, giftValue.text, causeName.text, causeValue.text));
    }

    IEnumerator PostObjective(string post_gift_name, string post_gift_value, string post_cause_name, string post_cause_value)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));
        form.AddField("post_gift_name", post_gift_name);
        form.AddField("post_gift_value", post_gift_value);
        form.AddField("post_cause_name", post_cause_name);
        form.AddField("post_cause_value", post_cause_value);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.INSERT_OBJECTIVE, form);
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
            giftName.text = "";
            giftValue.text = "";
            causeName.text = "";
            causeValue.text = "";
        }
    }
}
