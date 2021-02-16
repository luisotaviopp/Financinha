using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RkDeathGetter : MonoBehaviour
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
        StartCoroutine(GetDeathRanking());
    }

    IEnumerator GetDeathRanking()
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

            RankingDeathList listaRankingDeath = JsonUtility.FromJson<RankingDeathList>("{\"rankingDeath\":" + result + "}");

            //Nomes
            ranking1Name.text = listaRankingDeath.rankingDeath[0].username;
            ranking2Name.text = listaRankingDeath.rankingDeath[1].username;
            ranking3Name.text = listaRankingDeath.rankingDeath[2].username;

            //Vitórias
            ranking1Victories.text = listaRankingDeath.rankingDeath[0].victories_deathmatch.ToString();
            ranking2Victories.text = listaRankingDeath.rankingDeath[1].victories_deathmatch.ToString();
            ranking3Victories.text = listaRankingDeath.rankingDeath[2].victories_deathmatch.ToString();
        }
    }
}
