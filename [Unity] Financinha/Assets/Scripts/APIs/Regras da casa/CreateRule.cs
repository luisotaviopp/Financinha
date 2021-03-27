using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CreateRule : MonoBehaviour
{
    public InputField nameInput;
    public InputField valueInput;

    private bool isPenalidade = false;

    public void GetInfo()
    {
        StartCoroutine(Upload(nameInput.text, "descrição", float.Parse(valueInput.text) ));
    }

    IEnumerator Upload(string name, string description, float value)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));
        form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
        form.AddField("post_name", name);
        form.AddField("post_description", description);

        if (isPenalidade && value > 0)
        {
            // Inverte o valor caso seja penalidade.
            value = value*-1;
        }

        Debug.Log(value);

        form.AddField("post_value", value.ToString());

        Debug.Log(PlayerPrefs.GetInt("id_aprendiz"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.CREATE_RULE_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Retorna o estado do registro
            //statusDisplay.text = www.downloadHandler.text;
            Debug.Log(www.downloadHandler.text);
        }
    }

    public void SetPenalidade()
    {
        isPenalidade = true;
    }

    public void SetRecompensa()
    {
        isPenalidade = false;
    }
}
