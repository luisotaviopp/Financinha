using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField loginInput;
    public InputField passInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(PostLog(loginInput.text, passInput.text));
    }
    
    IEnumerator PostLog(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_username", username);
        form.AddField("post_password", password);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.LOGIN_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "Erro ao Logar";
        }
        else
        {
            //Retorna o estado do login
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            PlayerList listaDosPlayers = JsonUtility.FromJson<PlayerList>("{\"players\":" + result + "}");

            //Texto de Retorno
            statusDisplay.text = www.downloadHandler.text;

            //Salvando PlayerPrefs
            PlayerPrefs.SetString("token", listaDosPlayers.players[0].token);
            PlayerPrefs.SetInt("level", listaDosPlayers.players[0].level);
            PlayerPrefs.SetString("permission", listaDosPlayers.players[0].permission);
            PlayerPrefs.Save();
            
            //Zerando Campos Login
            loginInput.text = "";
            passInput.text = "";

            Debug.Log("Level: " + PlayerPrefs.GetInt("level")); 
            Debug.Log("Permission: " + PlayerPrefs.GetString("permission"));
            Debug.Log("Token: " + PlayerPrefs.GetString("token"));

            statusDisplay.text = "Logado com Sucesso";

            // Esconde os botões (se o usuário for aprendiz).
//            GameObject.Find("UIManager").GetComponent<PermissionCheck>().ShowHideButtons();

            if (listaDosPlayers.players[0].permission == "resp")
            {
                GameObject.Find("UIManager").GetComponent<UIManager>().OpenListaAprendizes();
            }
            else
            {
                PlayerPrefs.SetInt("id_aprendiz", listaDosPlayers.players[0].id);
                PlayerPrefs.Save();
                
                Debug.Log(PlayerPrefs.GetInt("id_aprendiz"));
                
                // Fecha o painel de login.
                GameObject.Find("UIManager").GetComponent<UIManager>().OpenLevelSelector();
            }

        }
    }
}
