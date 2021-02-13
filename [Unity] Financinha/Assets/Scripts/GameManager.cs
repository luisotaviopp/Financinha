using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string token;

    public GameObject menuPanel;
    public GameObject loginPanel;
    public GameObject carteiraPanel;
    public GameObject presentePanel;
    public GameObject causasPanel;
    public GameObject regrasPanel;
    public GameObject extratosPanel;
    public GameObject cofrinhoPanel;

    public static bool gameIsPlaying = false;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (PlayerPrefs.HasKey("Token")) {
            OpenMenu();
            Debug.Log(PlayerPrefs.GetString("Token"));
        }
        else {
            //OpenLogin();
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
        carteiraPanel.SetActive(false);
        presentePanel.SetActive(false);
        causasPanel.SetActive(false);
        regrasPanel.SetActive(false);
        extratosPanel.SetActive(false);
        cofrinhoPanel.SetActive(false);
    }

    public void OpenLogin()
    {
        menuPanel.SetActive(false);
        loginPanel.SetActive(true);
        carteiraPanel.SetActive(false);
        presentePanel.SetActive(false);
        causasPanel.SetActive(false);
        regrasPanel.SetActive(false);
        extratosPanel.SetActive(false);
        cofrinhoPanel.SetActive(false);
    }

    public void OpenCarteira()
    {
        menuPanel.SetActive(false);
        loginPanel.SetActive(false);
        carteiraPanel.SetActive(true);
        presentePanel.SetActive(false);
        causasPanel.SetActive(false);
        regrasPanel.SetActive(false);
        extratosPanel.SetActive(false);
        cofrinhoPanel.SetActive(false);
    }

    public void OpenPresente()
    {
        menuPanel.SetActive(false);
        loginPanel.SetActive(false);
        carteiraPanel.SetActive(false);
        presentePanel.SetActive(true);
        causasPanel.SetActive(false);
        regrasPanel.SetActive(false);
        extratosPanel.SetActive(false);
        cofrinhoPanel.SetActive(false);
    }

    public void OpenCausas()
    {
        menuPanel.SetActive(false);
        loginPanel.SetActive(false);
        carteiraPanel.SetActive(false);
        presentePanel.SetActive(false);
        causasPanel.SetActive(true);
        regrasPanel.SetActive(false);
        extratosPanel.SetActive(false);
        cofrinhoPanel.SetActive(false);
    }

    public void OpenRegras()
    {
        menuPanel.SetActive(false);
        loginPanel.SetActive(false);
        carteiraPanel.SetActive(false);
        presentePanel.SetActive(false);
        causasPanel.SetActive(false);
        regrasPanel.SetActive(true);
        extratosPanel.SetActive(false);
        cofrinhoPanel.SetActive(false);
    }

    public void OpenExtratos()
    {
        menuPanel.SetActive(false);
        loginPanel.SetActive(false);
        carteiraPanel.SetActive(false);
        presentePanel.SetActive(false);
        causasPanel.SetActive(false);
        regrasPanel.SetActive(false);
        extratosPanel.SetActive(true);
        cofrinhoPanel.SetActive(false);
    }

    public void OpenCofrinho()
    {
        menuPanel.SetActive(false);
        loginPanel.SetActive(false);
        carteiraPanel.SetActive(false);
        presentePanel.SetActive(false);
        causasPanel.SetActive(false);
        regrasPanel.SetActive(false);
        extratosPanel.SetActive(false);
        cofrinhoPanel.SetActive(true);
    }
}
