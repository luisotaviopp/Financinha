using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public string loginURL;

    public InputField loginInput;
    public InputField passInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(Upload(loginInput.text, passInput.text));
    }

    public void Awake() 
    {
        if (PlayerPrefs.HasKey("token"))
        {
            Debug.Log("User Logged In");
        } else {         
            Debug.Log("User Not Logged In");
        }
    }
    
    IEnumerator Upload(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        UnityWebRequest www = UnityWebRequest.Post(loginURL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Retorna o estado do login
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
          /*  PlayerList listaDosPlayers = JsonUtility.FromJson<PlayerList>("{\"players\":" + result + "}");*/
            statusDisplay.text = www.downloadHandler.text;
            Debug.Log(www.downloadHandler.text);
            //Debug.Log(listaDosPlayers.players[0].username);
            /*  PlayerPrefs.SetString("username", listaDosPlayers.players[0].username);
              PlayerPrefs.SetString("token", listaDosPlayers.players[0].token);
              PlayerPrefs.SetInt("id", listaDosPlayers.players[0].id);
              PlayerPrefs.SetInt("best_distance_single", listaDosPlayers.players[0].best_distance_single);
              PlayerPrefs.SetInt("best_distance_coop", listaDosPlayers.players[0].best_distance_coop);
              PlayerPrefs.SetInt("victories_versus", listaDosPlayers.players[0].victories_versus);
              PlayerPrefs.SetInt("victories_deathmatch", listaDosPlayers.players[0].victories_deathmatch);
              PlayerPrefs.SetInt("losts_versus", listaDosPlayers.players[0].losts_versus);
              PlayerPrefs.SetInt("losts_deathmatch", listaDosPlayers.players[0].losts_deathmatch);
              PlayerPrefs.Save();*/

            //Debug.Log(PlayerPrefs.GetString("username"));

            PlayerPrefs.SetString("Token", www.downloadHandler.text);
        }

    }

    public void Logout() {
        PlayerPrefs.DeleteKey("Token");
        Debug.Log("Token deletado");
    }

}
