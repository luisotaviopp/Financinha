using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panelLevelSelector;
    public GameObject panelLogin;
    public GameObject panelRegistration;
    public GameObject panelSavings;
    public GameObject panelPhilantrophy;
    public GameObject panelQuizz;
    public GameObject panelPreQuizz;
    public GameObject panelSettings;

    public GameObject panelBanco_da_Casa;
    public GameObject panelBanco_da_Casa_Lancar;
    public GameObject panelCarteira;
    public GameObject panelCarteiraLancar;
    public GameObject panelRegras;
    public GameObject panelRegras_Cadastrar;
    public GameObject panelSemanadas;
    public GameObject panelConquista;
    public GameObject panelConquista_editar;
    public GameObject panelAvaliacao;

    public GameObject panelPreGame;
    public Image nuvem;
    public Image pig;
    public Sprite[] nuvemLevel;
    public Sprite[] pigLevel;

    public void OpenLogin()
    {
        panelLogin.SetActive(true);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenRegistration()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(true);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenCarteira()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(true);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenCarteiraLancar()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(true);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenBancoDaCasa()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(true);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void OpenBancoDaCasalancar()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(true);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void OpenRegrasDaCasa()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(true);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void OpenRegrasDaCasalancar()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(true);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void OpenSemanadas()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(true);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void OpenConquista()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(true);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void OpenConquistaEditar()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(true);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void OpenAvaliacao()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(true);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenSettings()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(true);
    }

    public void OpenRules()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenQuizz()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(true);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenLevelSelector()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(true);
        panelPreQuizz.SetActive(false);
        panelPreGame.SetActive(false);
        panelSettings.SetActive(false);
    }

    public void OpenPreQuizz()
    {
        panelLogin.SetActive(false);
        panelRegistration.SetActive(false);
        panelBanco_da_Casa.SetActive(false);
        panelBanco_da_Casa_Lancar.SetActive(false);
        panelCarteira.SetActive(false);
        panelCarteiraLancar.SetActive(false);
        panelRegras.SetActive(false);
        panelRegras_Cadastrar.SetActive(false);
        panelSemanadas.SetActive(false);
        panelConquista.SetActive(false);
        panelConquista_editar.SetActive(false);
        panelAvaliacao.SetActive(false);
        panelQuizz.SetActive(false);
        panelLevelSelector.SetActive(false);
        panelPreQuizz.SetActive(true);
        panelSettings.SetActive(false);
    }
    public void OpenPreLevel(int level)
    {
        SceneLoader.refLevel = level;
        nuvem.sprite = nuvemLevel[level];
        pig.sprite = pigLevel[level];
        panelPreGame.SetActive(true);
    }

}
