using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetworkCheck : MonoBehaviour
{
    public GameObject internetOfflineMessage;
    void Start()
    {
        if(Application.internetReachability != NetworkReachability.NotReachable)
        {
            internetOfflineMessage.SetActive(false);
        }
        else
        {
            internetOfflineMessage.SetActive(true);
        }
    }
}
