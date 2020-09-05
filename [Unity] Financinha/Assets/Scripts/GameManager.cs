using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string token;

    public GameObject menuPanel;
    public GameObject loginPanel;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (PlayerPrefs.HasKey("Token")) {
            OpenMenu();
            Debug.Log(PlayerPrefs.GetString("Token"));
        }
        else {
            OpenLogin();
            Debug.Log("Usuário não está logado");
        }
    }

    public static string getToken() {
        return token;
    }

    public void OpenMenu()
    {
        menuPanel.SetActive(true);
        loginPanel.SetActive(false);
    }
    public void OpenLogin()
    {
        loginPanel.SetActive(true);
        menuPanel.SetActive(false);
    }
}
