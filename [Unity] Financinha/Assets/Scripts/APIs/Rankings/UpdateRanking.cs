using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class UpdateRanking : MonoBehaviour
{
    public string rankingURL;

    public int newScore = 1;
    public int rankingIndex = 1; //1 = singleplayer | 2 = Coop | 3 = Versus | 4 = DeathMatch | 5 = Lost_versus | 6 = Lost_deathmatch 
    public Text statusDisplay;
    public void Start()
    {
        //Criando Switch
        switch (rankingIndex)
        {
            case 1:
                PlayerPrefs.SetInt("best_distance_single", newScore);
                break;
        }
        //Salvando PlayerPrefs
        /*PlayerPrefs.SetInt("best_distance_coop", listaDosPlayers.players[0].best_distance_coop);
        PlayerPrefs.SetInt("victories_versus", listaDosPlayers.players[0].victories_versus);
        PlayerPrefs.SetInt("victories_deathmatch", listaDosPlayers.players[0].victories_deathmatch);
        PlayerPrefs.SetInt("losts_versus", listaDosPlayers.players[0].losts_versus);
        PlayerPrefs.SetInt("losts_deathmatch", listaDosPlayers.players[0].losts_deathmatch);*/
        PlayerPrefs.Save();

    }

    public void SendRanking()
    {
        StartCoroutine(Upload(newScore, rankingIndex));
    }

    IEnumerator Upload(int newScore, int rankingIndex)
    {
        WWWForm form = new WWWForm();
        form.AddField("newScore", newScore);
        form.AddField("rankingIndex", rankingIndex);
        form.AddField("player_id", PlayerPrefs.GetInt("player_id"));


        UnityWebRequest www = UnityWebRequest.Post(rankingURL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            statusDisplay.text = "ranking update Error";
        }
        else
        {
            //Texto de Retorno
            statusDisplay.text = www.downloadHandler.text;

            Debug.Log(PlayerPrefs.GetInt("player_id") + "newScore: " + newScore);

        }

    }
}
