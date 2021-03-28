using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class MainMenu : MonoBehaviour
{
    public Text bankAmount;
    public Text rulesAmount;
    public Text walletAmount;
    public Text objectiveAmount;

    private void OnEnable()
    {
        RenderValues();
        if (PlayerPrefs.HasKey("id_aprendiz"))
        {            
            StartCoroutine(GetValuesCorroutine());
        }
        else
        {
            // Fecha o painel de login.
            GameObject.Find("UIManager").GetComponent<UIManager>().OpenListaAprendizes();
        }
    }

    IEnumerator GetValuesCorroutine()
    {
        // Inicia o form e pega o token ativo
        WWWForm form = new WWWForm();
        form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.MENU_UPDATE_VALUES, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Retorna o estado do login
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            MenuValuesList listaValues = JsonUtility.FromJson<MenuValuesList>("{\"menuValues\":" + result + "}");

            //Salvando PlayerPrefs
            PlayerPrefs.SetFloat("wallet_amount", listaValues.menuValues[0].wallet_amount);
            PlayerPrefs.SetFloat("bank_amount", listaValues.menuValues[0].bank_amount);
            PlayerPrefs.SetFloat("objective_value", listaValues.menuValues[0].objective_value);
            PlayerPrefs.SetFloat("rules_amount", listaValues.menuValues[0].saldo);
            PlayerPrefs.SetFloat("semanada", listaValues.menuValues[0].semanada);
            
            Debug.Log(listaValues.menuValues[0].semanada);

            RenderValues();
        }
    }

    public void RenderValues()
    {
        if (PlayerPrefs.HasKey("wallet_amount"))
        {
            walletAmount.text = Math.Round(PlayerPrefs.GetFloat("wallet_amount"), 2).ToString();
        }
        else
        {
            walletAmount.text = "0.00";
        }

        if (PlayerPrefs.HasKey("bank_amount"))
        {
            bankAmount.text = Math.Round(PlayerPrefs.GetFloat("bank_amount"), 2).ToString();
        }
        else
        {
            bankAmount.text = "0.00";
        }

        if (PlayerPrefs.HasKey("objective_value"))
        {
            objectiveAmount.text = Math.Round(PlayerPrefs.GetFloat("objective_value"), 2).ToString();
        }
        else
        {
            objectiveAmount.text = "0.00";
        }

        if (PlayerPrefs.HasKey("rules_amount"))
        {
            rulesAmount.text = Math.Round(PlayerPrefs.GetFloat("rules_amount"), 2).ToString();
        }
        else
        {
            rulesAmount.text = "0.00";
        }
    }
}
