using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetApprendices : MonoBehaviour
{
    public Text statusDisplay;

    ApprendicesList apprendicesList;

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
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.LIST_USER_APPRENDICES, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);;
        }
        else
        {
            Debug.Log(www.downloadHandler.text);

            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            apprendicesList = JsonUtility.FromJson<ApprendicesList>("{\"apprendices\":" + result + "}");


            if (apprendicesList.apprendices.Count > 0)
            {
                GameObject template = transform.GetChild(0).gameObject;
                GameObject g;

                for (int i = 0; i < apprendicesList.apprendices.Count; i++)
                {
                    g = Instantiate(template, transform);
                    g.transform.GetChild(0).GetComponent<Text>().text = apprendicesList.apprendices[i].apr;
                    g.transform.GetChild(1).GetComponent<Text>().text = apprendicesList.apprendices[i].level_apr.ToString();
                    g.GetComponent<Button>().AddEventListener(i, AprendizClicked);
                }

                Destroy(template.gameObject);
            }
            else
            {
                statusDisplay.text = "Nenhum aprendiz cadastrado";
            }
        }
    }

    void AprendizClicked(int itemIndex)
    {
        PlayerPrefs.SetInt("id_aprendiz", apprendicesList.apprendices[itemIndex].id_apr);
        PlayerPrefs.SetInt("level", apprendicesList.apprendices[itemIndex].level_apr);

        Debug.Log("Aprendiz selecionado: " + apprendicesList.apprendices[itemIndex].apr);
        Debug.Log("Id: " + PlayerPrefs.GetInt("id_aprendiz"));

        // Muda a altura do cofrinho, de acordo com o level do aprendiz.
        GameObject.Find("UIManager").GetComponent<LevelCheck>().ChangeCofrinhoPosition(PlayerPrefs.GetInt("level"));

        GameObject.Find("UIManager").GetComponent<UIManager>().OpenLevelSelector();
    }
}
