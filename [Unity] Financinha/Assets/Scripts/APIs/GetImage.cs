using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GetImage : MonoBehaviour
{
    public RawImage imagemTemplate;

    string passaOLink = "https://static.wikia.nocookie.net/zelda_gamepedia_en/images/8/87/ALttP_Link_Artwork.png/revision/latest/scale-to-width-down/320";

    void Start()
    {
        StartCoroutine(DownloadImage(passaOLink));
    }

    IEnumerator DownloadImage(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
            Debug.Log(request.error);
        else
            imagemTemplate.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
    }
}