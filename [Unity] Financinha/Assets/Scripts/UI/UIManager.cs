using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panelLogin;
    public GameObject panelRegistration;
    public GameObject panelWallet;
    public GameObject panelEconomy;
    public GameObject panelFamily;
    public GameObject panelSettings;
    public GameObject panelRules;
    public GameObject panelSavings;
    public GameObject panelPhilantrophy;
    public GameObject panelQuizz;
    public GameObject panelLevelSelector;
    public GameObject panelPreQuizz;


    public void OpenLogin()
    {
        panelLogin.SetActive(true);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenRegistration()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(true);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenWallet()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(true);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenEconomy()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(true);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenFamily()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(true);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenSettings()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(true);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenRules()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(true);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenQuizz()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(true);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
    }

    public void OpenLevelSelector()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(true);
        panelPreQuizz.SetActive(false);
    }

    public void OpenPreQuizz()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelWallet.SetActive(false);
        panelEconomy.SetActive(false);
        panelFamily.SetActive(false);
        panelSettings.SetActive(false);
        panelRules.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(true);
    }
}
