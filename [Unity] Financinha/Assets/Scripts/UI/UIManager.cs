using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject loginPanel;

    public void OpenScene(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void CloseScene(GameObject panel)
    {
        panel.SetActive(false);
    }

    public static void OpenMenu(){
        menuPanel.SetActive(true);
        loginPanel.SetActive(false);
    }
    public static void OpenLogin() {
        loginPanel.SetActive(true);
        menuPanel.SetActive(false);
    }
}
