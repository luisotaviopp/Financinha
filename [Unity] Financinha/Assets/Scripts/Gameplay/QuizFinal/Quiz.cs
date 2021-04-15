using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Quiz : MonoBehaviour
{
    //Lista com TODOS os levels.
    [Header("Lista com TODOS os levels.")]
    public List<QuizQuestion> questions;

    //Lista que carrega apenas as questoes do level selecionado
    [Header("Lista com as questoes do level selecionado.")]
    public List<QuizQuestion> levelQuestions;

    // UI para renderizar a questao atual
    [Header("UI para renderizar a questao atual.")]
    public Image questionImage;
    public Text questionText;
    public Text answer1Text;
    public Text answer2Text;
    public Text answer3Text;
    public Text answer4Text;
    public Text answer5Text;

    //Aquelas imagens da pontuação no canto da tela.
    [Header("Aquelas imagens da pontuação no canto da tela.")]
    public Image pointsImage;
    public Sprite[] pointSprites;

    // Index da questao carregada.
    private int currentQuestionIndex = 0;

    public GameObject historinhaPanel;

    private void Start()
    {
        historinhaPanel.SetActive(false);

        Debug.Log("Carregando quiz do level " + PlayerPrefs.GetInt("quiz_level_to_load"));
        LoadLevelQuestions(PlayerPrefs.GetInt("quiz_level_to_load"));
    }

    // Carrega apenas as questões associadas a uma fase.
    public void LoadLevelQuestions(int level)
    {
        //Limpa a lista, pra garantir que nenhuma questao de outro level esteja carregada.
        levelQuestions.Clear();

        foreach (QuizQuestion question in questions)
        {
            // Se a questao for do level selecionado, carrega ela na lista.
            if(question.level == level)
            {
                levelQuestions.Add(question);
            }
        }

        Debug.Log("Carregou a lista de questões");

        // Reinicia o contador.
        currentQuestionIndex = 0;

        // Renderiza a primeira questão.
        RenderQuestion();
    }


    public void RenderQuestion()
    {
        // Se for uma imagem...
        if(levelQuestions[currentQuestionIndex].isImage)
        {
            questionImage.gameObject.SetActive(true);
            questionImage.sprite = levelQuestions[currentQuestionIndex].questionSprite;
        }

        // Se nao for uma imagem
        else
        {
            questionImage.gameObject.SetActive(false);
            questionText.text = levelQuestions[currentQuestionIndex].question;
        }

        answer1Text.text = levelQuestions[currentQuestionIndex].answer1;
        answer2Text.text = levelQuestions[currentQuestionIndex].answer2;
        answer3Text.text = levelQuestions[currentQuestionIndex].answer3;
        answer4Text.text = levelQuestions[currentQuestionIndex].answer4;
        answer5Text.text = levelQuestions[currentQuestionIndex].answer5;
    }

    public void NextQuestion()
    {
        if(currentQuestionIndex < levelQuestions.Count)
        {
            currentQuestionIndex++;
            RenderQuestion();
        }
        else
        {
            Debug.Log("Volta pra historinha");
        }
    }
}