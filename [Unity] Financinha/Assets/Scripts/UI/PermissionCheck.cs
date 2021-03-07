using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermissionCheck : MonoBehaviour
{
    public GameObject[] buttons;

    void Start()
    {
        ShowHideButtons();
    }

    public void ShowHideButtons()
    {
        if (PlayerPrefs.GetString("permission") == "resp")
        {
            foreach (GameObject btn in buttons)
            {
                btn.SetActive(true);
            }
        }
        else
        {
           foreach (GameObject btn in buttons)
           {
               btn.SetActive(false);
           }
        }
    }
}
