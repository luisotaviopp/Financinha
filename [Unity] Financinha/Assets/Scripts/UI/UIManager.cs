using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
	public GameObject panelLevelSelector;
	public GameObject panelLogin;
	public GameObject panelRegistration;
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
	public GameObject panelListaAprendizes;
	public GameObject panelRegistrarAprendiz;

	public GameObject panelSubMenu;

	public GameObject panelPreGame;
	public Image nuvem;

	public Image pig;
	public Sprite[] pigs;


	public void Awake()
	{
	
		if (!PlayerPrefs.HasKey("token"))
		{
			OpenLogin();
		}
		
		OpenLevelSelector();
	}

	#region
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(true);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(true);
		panelPreGame.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(true);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
	}

	public void OpenPreGame()
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelPreGame.SetActive(true);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
	}
	public void OpenListaAprendizes()
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
		panelLevelSelector.SetActive(false);
		panelPreGame.SetActive(false);
		panelSettings.SetActive(false);
		panelRegistrarAprendiz.SetActive(false);
		panelListaAprendizes.SetActive(true);
		ToogleSubMenu();
	}

	public void OpenRegistrarAprendiz()
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelPreGame.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
		panelRegistrarAprendiz.SetActive(true);
	}
	/* public void OpenListaAprendizes()
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
		panelLevelSelector.SetActive(false);
		panelPreGame.SetActive(false);
		panelSettings.SetActive(false);
		panelRegistrarAprendiz.SetActive(false);
		panelListaAprendizes.SetActive(true);
		ToogleSubMenu();
	}

	public void OpenRegistrarAprendiz()
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
		panelLevelSelector.SetActive(false);
		panelPreQuizz.SetActive(false);
		panelPreGame.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
		panelRegistrarAprendiz.SetActive(true);
	}
	*/
	#endregion
	public void OpenPreLevel(int level)
	{
		SceneLoader.refLevel = level;

		pig.sprite = pigs[level];
		OpenPreGame();
	}
	public void ToogleSubMenu()
	{
		if (panelSubMenu.activeInHierarchy)
		{
			panelSubMenu.SetActive(false);
		}
		else {
			panelSubMenu.SetActive(true);
		}
	}
	public void OpenSceneQuiz()
	{
		SceneManager.LoadSceneAsync("Quiz");
	}
}
