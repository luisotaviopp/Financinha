using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public static class BtnRegra
{
    public static void AddEvent<T> (this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}

public class GetRules : MonoBehaviour
{
    //public Text statusDisplay;
    RulesList rulesList;

    private void OnEnable()
    {
        GetInfo();
    }

    public void GetInfo()
    {
        StartCoroutine(GetRulesCorroutine());
    }

    IEnumerator GetRulesCorroutine()
    {
        WWWForm form = new WWWForm();
        form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.LIST_RULES_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            
        }
        else
        {
            //Retorna o estado do login
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            rulesList = JsonUtility.FromJson<RulesList>("{\"rules\":" + result + "}");

            GameObject template = transform.GetChild(0).gameObject;
            GameObject g;

            Debug.Log(www.downloadHandler.text);

            for (int i = 0; i < rulesList.rules.Count; i++)
            {
                g = Instantiate(template, transform);
                g.transform.GetChild(1).GetComponent<Text>().text = rulesList.rules[i].quantity;
                g.transform.GetChild(3).GetComponent<Text>().text = rulesList.rules[i].name;
                g.transform.GetChild(5).GetComponent<Text>().text = "R$" + rulesList.rules[i].value.ToString();
                g.transform.GetChild(6).GetComponent<Text>().text = "R$" + rulesList.rules[i].total_week.ToString();

                g.transform.GetChild(0).GetComponent<Button>().AddEvent(i, RegraDecreased);
                g.transform.GetChild(2).GetComponent<Button>().AddEvent(i, RegraIncreased);
                g.transform.GetChild(4).GetComponent<Button>().AddEvent(i, RegraDeleted);
                //g.transform.GetChild(0).GetComponent<Button>().AddEventListener(i, AprendizClicked);
            }

            Destroy(template.gameObject);
        }
    }

    void RegraDecreased (int itemIndex)
    {
        Debug.Log("Diminui " + rulesList.rules[itemIndex].name);
    }

    void RegraIncreased (int itemIndex)
    {
        Debug.Log("Aumenta: " + rulesList.rules[itemIndex].name);
    }

    void RegraDeleted (int itemIndex)
    {
        Debug.Log("Deleta: " + rulesList.rules[itemIndex].name);
    }
}