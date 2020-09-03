using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logout : MonoBehaviour
{
    public void PlayerLogout()
    {
        PlayerPrefs.DeleteAll();
        if (PlayerPrefs.HasKey("token"))
        {
            Debug.Log("User Logged In");
        }
        else
        {
            Debug.Log("User Not Logged In");
        }
    }
}