using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GiftGetter : MonoBehaviour
{
    public Text statusDisplay;

    public void GetInfo()
    {
        StartCoroutine(GetGift());
    }

    IEnumerator GetGift()
    {
        WWWForm form = new WWWForm();
        form.AddField("post_token", PlayerPrefs.GetString("token"));

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_GIFT_URL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "Erro ao Logar";
        }
        else
        {

            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            GiftList giftList = JsonUtility.FromJson<GiftList>("{\"gifts\":" + result + "}");

            //Texto de Retorno
            statusDisplay.text = www.downloadHandler.text;

            Debug.Log(www.downloadHandler.text);

            statusDisplay.text = "";

            foreach (Gift gift in giftList.gifts)
            {
                statusDisplay.text += gift.name + "\n" + gift.description + "\nR$" + gift.value + "\nR$" + gift.weekly_value +"\n\n";
            }
        }
    }
}
