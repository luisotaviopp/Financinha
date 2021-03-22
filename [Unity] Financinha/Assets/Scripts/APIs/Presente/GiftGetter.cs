using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GiftGetter : MonoBehaviour
{
	public Text giftValueTxt;
	public Text giftNameTxt;
	public Text causeValueTxt;
	public Text causeNameTxt;
	public Text sumTxt;

	private void OnEnable()
	{
		GetInfo();
	}

	public void GetInfo()
	{
		StartCoroutine(GetGift());
	}

	IEnumerator GetGift()
	{
		WWWForm form = new WWWForm();
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_GIFT_URL, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error);
			//statusDisplay.text = "Erro na solicitação";
		}
		else
		{
			string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
			GiftList giftList = JsonUtility.FromJson<GiftList>("{\"gifts\":" + result + "}");

			Debug.Log(www.downloadHandler.text);

			foreach (Gift gift in giftList.gifts)
			{
				//statusDisplay.text += gift.cause_name + "\n" + gift.cause_value + "\nR$" + gift.gift_name + "\nR$" + gift.gift_value +"\n\n";
				giftValueTxt.text   = "R$" + gift.gift_value.ToString();
				giftNameTxt.text    = gift.gift_name.ToString();
				causeValueTxt.text  = "R$" + gift.cause_value.ToString();
				causeNameTxt.text   = gift.cause_name.ToString();
				sumTxt.text = "R$" + (gift.cause_value + gift.gift_value).ToString();
			}
		}
	}
}
