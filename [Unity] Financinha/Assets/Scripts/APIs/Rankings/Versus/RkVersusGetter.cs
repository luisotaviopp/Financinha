using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RkVersusGetter : MonoBehaviour
{
    public string link;
    public Text ranking1Name;
    public Text ranking2Name;
    public Text ranking3Name;
    public Text ranking1Victories;
    public Text ranking2Victories;
    public Text ranking3Victories;

    void Start()
    {
        StartCoroutine(GetVersusRanking());
    }

    IEnumerator GetVersusRanking()
    {
        UnityWebRequest www = UnityWebRequest.Get(link);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Pega o dado recebido pelo JSon
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);

            RankingVersusList listaRankingVersus = JsonUtility.FromJson<RankingVersusList>("{\"rankingVersus\":" + result + "}");

            //Nomes
            ranking1Name.text = listaRankingVersus.rankingVersus[0].username;
            ranking2Name.text = listaRankingVersus.rankingVersus[1].username;
            ranking3Name.text = listaRankingVersus.rankingVersus[2].username;

            //Vitórias
            ranking1Victories.text = listaRankingVersus.rankingVersus[0].victories_versus.ToString();
            ranking2Victories.text = listaRankingVersus.rankingVersus[1].victories_versus.ToString();
            ranking3Victories.text = listaRankingVersus.rankingVersus[2].victories_versus.ToString();
        }
    }
}
