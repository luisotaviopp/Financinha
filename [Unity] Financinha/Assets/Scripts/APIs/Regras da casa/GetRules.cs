using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GetRules : MonoBehaviour
{
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(GetRulesCorroutine());
    }

    IEnumerator GetRulesCorroutine()
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.LIST_RULES_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "Erro ao Logar";
        }
        else
        {
            statusDisplay.text = www.downloadHandler.text;

            Debug.Log(www.downloadHandler.text);


            //Retorna o estado do login
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            RulesList rulesList = JsonUtility.FromJson<RulesList>("{\"rules\":" + result + "}");

            //Texto de Retorno
            statusDisplay.text = www.downloadHandler.text;
            
            statusDisplay.text = "";

            foreach (Rule rule in rulesList.rules)
            {
                statusDisplay.text += "Regra: " + rule.name + " \nDescrição: " + rule.description + "\n\n";
            }
        }
    }
}