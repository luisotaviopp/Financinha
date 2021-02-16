using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logout : MonoBehaviour
{
    public Text statusDisplay;

    public void PlayerLogout()
    {
        PlayerPrefs.DeleteKey("token");
        statusDisplay.text = "Logout Efetuado com Sucesso!";
    }
}