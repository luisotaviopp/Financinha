using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelIncreaser : MonoBehaviour
{
    public Text levelDisplay;

    public void UpdateLevel()
    {
        StartCoroutine(IncreaseLevel());
    }

    IEnumerator IncreaseLevel()
    {
        // Inicia o form e pega o token ativo
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        //Debug.Log(username + "  " + password);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.INCREASE_LEVEL_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Sempre que algo retornar como texto, basta pegar o www.downloadHandler.text, ao invés de converter o json em uma lista.
            PlayerPrefs.SetInt("level", int.Parse(www.downloadHandler.text));
            PlayerPrefs.Save();

            levelDisplay.text = "Level: " + PlayerPrefs.GetInt("level");
        }
    }
}