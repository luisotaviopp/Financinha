using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class RkCoopGetter : MonoBehaviour
{
    public string link;
    public Text ranking1Name;
    public Text ranking2Name;
    public Text ranking3Name;
    public Text ranking1Distance;
    public Text ranking2Distance;
    public Text ranking3Distance;

    void Start()
    {
        StartCoroutine(GetCoopRanking());
    }

    IEnumerator GetCoopRanking()
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

            RankingCoopList listaRankingSingle = JsonUtility.FromJson<RankingCoopList>("{\"rankingCoop\":" + result + "}");

            //Nomes
            ranking1Name.text = listaRankingSingle.rankingCoop[0].username;
            ranking2Name.text = listaRankingSingle.rankingCoop[1].username;
            ranking3Name.text = listaRankingSingle.rankingCoop[2].username;

            //Distâncias
            ranking1Distance.text = listaRankingSingle.rankingCoop[0].best_distance_coop.ToString();
            ranking2Distance.text = listaRankingSingle.rankingCoop[1].best_distance_coop.ToString();
            ranking3Distance.text = listaRankingSingle.rankingCoop[2].best_distance_coop.ToString();

            // Imprime os 3 melhores.
            //foreach (RankingSingleEntry player in listaRankingSingle.rankingSingle)
            //{
            //    Debug.Log("Position: " + player.ranking_single + "  |  Name: " + player.username + "  |  Distance: " + player.best_distance);
            //}
        }
    }
}
