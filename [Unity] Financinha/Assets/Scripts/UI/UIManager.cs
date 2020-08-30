using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OpenScene(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void CloseScnene(GameObject panel)
    {
        panel.SetActive(false);
    }
}
