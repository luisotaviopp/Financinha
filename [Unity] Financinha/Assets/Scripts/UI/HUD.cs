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
}
