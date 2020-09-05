using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string token;
   // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (PlayerPrefs.HasKey("Token")) {
            UIManager.OpenMenu();
        } else {
            UIManager.OpenLogin();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static string getToken() {
        return token;
    }


}
