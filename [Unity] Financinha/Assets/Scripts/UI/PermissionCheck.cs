using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermissionCheck : MonoBehaviour
{
    public GameObject[] buttonsHiddenForResponsible;
    public GameObject[] buttonsHiddenForApprentice;

    void OnEnable()
    {
        ShowHideButtons();
    }

    public void ShowHideButtons()
    {
        if (PlayerPrefs.GetString("permission") == "resp")
        {
            foreach (GameObject btn in buttonsHiddenForResponsible)
            {
                btn.SetActive(false);
            }
        }
        else
        {
           foreach (GameObject btn in buttonsHiddenForApprentice)
           {
               btn.SetActive(false);
           }
        }
    }
}
