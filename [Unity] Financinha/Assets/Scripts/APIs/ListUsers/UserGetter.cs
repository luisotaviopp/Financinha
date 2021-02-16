using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UserGetter : MonoBehaviour
{
    public InputField usernameInput;
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(SearchUser(usernameInput.text));
    }

    IEnumerator SearchUser(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));
        form.AddField("post_username", username);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.LIST_USERS_URL, form);
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
            SearchUserList userList = JsonUtility.FromJson<SearchUserList>("{\"users\":" + result + "}");

            usernameInput.text = "";
            statusDisplay.text = "";

            foreach(UserSingle user in userList.users)
            {
                statusDisplay.text += user.username + "\n\n";
                Debug.Log(user.username);
            }
        }
    }
}
