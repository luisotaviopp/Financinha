using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logout : MonoBehaviour
{
    public void PlayerLogout()
    {
        PlayerPrefs.DeleteAll();

        GameObject.Find("UIManager").GetComponent<UIManager>().ToogleSubMenu();

        // Volta para o login.
        GameObject.Find("UIManager").GetComponent<UIManager>().OpenLogin();
    }
}