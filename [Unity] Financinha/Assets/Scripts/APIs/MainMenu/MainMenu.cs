using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text bankAmount;
    public Text rulesAmount;
    public Text walletAmount;
    public Text objectiveAmount;

    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("wallet_amount"))
        {
            walletAmount.text = Math.Round(PlayerPrefs.GetFloat("wallet_amount"), 2).ToString();
        }
        else
        {
            walletAmount.text = "0.00";
        }

        if (PlayerPrefs.HasKey("bank_amount"))
        {
            bankAmount.text = Math.Round(PlayerPrefs.GetFloat("bank_amount"), 2).ToString();
        }
        else
        {
            bankAmount.text = "0.00";
        }

        if (PlayerPrefs.HasKey("objective_amount"))
        {
            objectiveAmount.text = Math.Round(PlayerPrefs.GetFloat("objective_amount"), 2).ToString();
        }
        else
        {
            objectiveAmount.text = "0.00";
        }

        if (PlayerPrefs.HasKey("rules_amount"))
        {
            rulesAmount.text = Math.Round(PlayerPrefs.GetFloat("rules_amount"), 2).ToString();
        }
        else
        {
            rulesAmount.text = "0.00";
        }
    }
}
