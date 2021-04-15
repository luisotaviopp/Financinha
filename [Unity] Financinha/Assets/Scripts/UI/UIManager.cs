using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
	public GameObject panelLevelSelector;           // Menu principal
	public GameObject panelLogin;                   // Login
	public GameObject panelRegistration;            // Registro
//	public GameObject panelPreQuizz;
	public GameObject panelSettings;                // Opcoes

	public GameObject panelBanco_da_Casa;           // Lista os eventos do banco
	public GameObject panelBanco_da_Casa_Lancar;    // Operacao no banco
	public GameObject panelCarteira;                // Lista as operacoes da carteira
	public GameObject panelCarteiraLancar;          // Novo evento na carteira
	public GameObject panelRegras;                  // Lista as regras da casa
	public GameObject panelRegras_Cadastrar;        // Cadastra nova regra
	public GameObject panelSemanadas;               // Simulador de semanadas
	public GameObject panelConquista;               // Mostra objetivo e conquista
	public GameObject panelConquista_editar;        // Adicionar ou editar conquista
	public GameObject panelAvaliacao;               // Para o pai avaliar a resposta do aprendiz
	public GameObject panelListaAprendizes;         // Lista de aprendizes
	public GameObject panelRegistrarAprendiz;       // Cadastra novo aprendiz

	public GameObject panelSubMenu;                 // Manu hamburger no canto da tela

	public GameObject panelPreGame;                 // Seleciona entre desafio de habilidades e quiz
	public Image nuvem;

	public Image pig;
	public Sprite[] pigs;

	public Button btQuiz;

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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(true);
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
		//panelPreQuizz.SetActive(false);
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
		//panelPreQuizz.SetActive(false);
		panelPreGame.SetActive(false);
		panelSettings.SetActive(false);
		panelListaAprendizes.SetActive(false);
		panelRegistrarAprendiz.SetActive(true);
	}
	
	#endregion
	public void OpenPreLevel(int level)
	{
		SceneLoader.refLevel = level;

		GetHabilityProgress habilidade = GameObject.Find("LevelSelector").GetComponent<GetHabilityProgress>();

		btQuiz.interactable = false;

		PlayerPrefs.SetInt("quiz_level_to_load", level);

		if (level == 1 && habilidade.levelProgressorList.progressor[0].lvl_1_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_1_habilidade}");
		}

		if (level == 2 && habilidade.levelProgressorList.progressor[0].lvl_2_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_2_habilidade}");
		}

		if (level == 3 && habilidade.levelProgressorList.progressor[0].lvl_3_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_3_habilidade}");
		}

		if (level == 4 && habilidade.levelProgressorList.progressor[0].lvl_4_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_4_habilidade}");
		}

		if (level == 5 && habilidade.levelProgressorList.progressor[0].lvl_5_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_5_habilidade}");
		}

		if (level == 6 && habilidade.levelProgressorList.progressor[0].lvl_6_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_6_habilidade}");
		}

		if (level == 7 && habilidade.levelProgressorList.progressor[0].lvl_7_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_7_habilidade}");
		}

		if (level == 8 && habilidade.levelProgressorList.progressor[0].lvl_8_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_8_habilidade}");
		}

		if (level == 9 && habilidade.levelProgressorList.progressor[0].lvl_9_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_9_habilidade}");
		}

		if (level == 10 && habilidade.levelProgressorList.progressor[0].lvl_10_habilidade)
		{
			btQuiz.interactable = true;
			Debug.Log($" Abriu {habilidade.levelProgressorList.progressor[0].lvl_10_habilidade}");
		}
		pig.sprite = pigs[level];
		OpenPreGame();
	}

	public void ToogleSubMenu()
	{
		if (panelSubMenu.activeInHierarchy)
		{
			panelSubMenu.SetActive(false);
		}
		else 
		{
			panelSubMenu.SetActive(true);
		}
	}
	
	public void OpenSceneQuiz()
	{
		SceneManager.LoadSceneAsync("Quiz");
	}
}
