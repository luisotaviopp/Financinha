using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class PlayerGetter : MonoBehaviour
{
    public string link;
    public Text nomeJogador;
    public string result;

    // public Jogador[] jogadores;

    void Start()
    {
        StartCoroutine(GetPlayers());
    }

    IEnumerator GetPlayers()
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

            //Cria uma lista, separando CADA PLAYER do array.
            // aquele \"players\": adiciona cada registro do array dentro da lista (que se chama players), dentro da classe PlayerList.
            PlayerList listaDosPlayers = JsonUtility.FromJson<PlayerList>("{\"players\":" + result + "}");

            //Imprime apenas o username do segundo registro da lista (igual o array, começa em 0).
            //Debug.Log(listaDosPlayers.players[1].username);

            // Imprime o user e a senha de cada jogador.
            //foreach (Player player in listaDosPlayers.players)
            //{
            //    Debug.Log("Username: " + player.username + "  |  Senha: " + player.password);
            //}
        }
    }
}