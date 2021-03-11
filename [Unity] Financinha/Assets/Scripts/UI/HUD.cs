using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Image[] coin;
    public GameObject Hud;
    public GameObject PauseMenu;
    public GameObject LoseMenu;
    public GameObject WinMenu;
    public GameObject PreGame;
    public Image pig;
    public Sprite[] pigs;

    private void Start()
    {
        ClosePauseMenu();
    }

    public void OpenPauseMenu()
    {
        Time.timeScale = 0;
        Hud.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void ClosePauseMenu()
    {
        Time.timeScale = 1;
        Hud.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        Hud.SetActive(true);
        PauseMenu.SetActive(false);

        SceneManager.LoadScene(0);
    }    
    public void OpenLoseMenu()
    {
        PauseMenu.SetActive(false);
        WinMenu.SetActive(false);
        LoseMenu.SetActive(true);
 

    }
    public void OpenPreGame()
    {
        PauseMenu.SetActive(false);
        WinMenu.SetActive(false);
        LoseMenu.SetActive(false);
        PreGame.SetActive(true);

        pig.sprite = pigs[SceneManager.GetActiveScene().buildIndex];

    }
    public void OpenWinMenu()
    {
        PauseMenu.SetActive(false);
        LoseMenu.SetActive(false);
        WinMenu.SetActive(true);

    }
    public void OpenSceneQuiz()
    {
        SceneManager.LoadSceneAsync("Quiz");
    }
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

}
