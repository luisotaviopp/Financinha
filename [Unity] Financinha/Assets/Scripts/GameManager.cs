using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string token;

    // REGRAS DO GAME;
    public static bool win;
    public static bool lose;
    public static bool gameIsPlaying = false;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public static string getToken() {
        return token;
    }
}
