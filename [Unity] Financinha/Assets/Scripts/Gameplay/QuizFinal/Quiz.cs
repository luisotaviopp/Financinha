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

    //Botao para garregar a prox pergunta.
    public Button nextButton;

    //Aquelas imagens da pontuação no canto da tela.
    [Header("Aquelas imagens da pontuação no canto da tela.")]
    public Image pointsImage;
    public Sprite[] pointSprites;

    // Index da questao carregada.
    private int currentQuestionIndex = 0;

    // Volta para a historinha se o index da questao atual for menor que zero.
    public GameObject historinhaPanel;

    public GameObject answerButtons;
    public GameObject openAnswerInput;

    //Input para pegar a resposta aberta
    public InputField answerInput;

    private int quiz_score = 0;

    public List<bool> rightAnswerList;

    private void OnEnable()
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

                //Inicia a lista das respostas das questões.
                rightAnswerList.Add(false);
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
            questionText.text = "";
        }

        // Se nao for uma imagem
        else
        {
            questionImage.gameObject.SetActive(false);
            questionText.text = levelQuestions[currentQuestionIndex].question;
        }

        if (!levelQuestions[currentQuestionIndex].isOpenAnswer) 
        {
            answerButtons.SetActive(true);
            openAnswerInput.SetActive(false);
            answer1Text.text = levelQuestions[currentQuestionIndex].answer1;
            answer2Text.text = levelQuestions[currentQuestionIndex].answer2;
            answer3Text.text = levelQuestions[currentQuestionIndex].answer3;
            answer4Text.text = levelQuestions[currentQuestionIndex].answer4;
            answer5Text.text = levelQuestions[currentQuestionIndex].answer5;
        }
        else
        {
            // Se for a ultima pergunta, abre o input para a resposta aberta.
            answerButtons.SetActive(false);
            openAnswerInput.SetActive(true);
        }
    }

    public void NextQuestion()
    {
        if(currentQuestionIndex < levelQuestions.Count-1)
        {
            currentQuestionIndex++;
            RenderQuestion();
        }

        if(levelQuestions[currentQuestionIndex].isOpenAnswer)
        {
            SendResultToServer();
        }
    }

    public void PreviousQuestion()
    {
        if (currentQuestionIndex > 0)
        {
            currentQuestionIndex--;
            RenderQuestion();
        }
        else
        {
            Debug.Log("Volta pra historinha");
            historinhaPanel.SetActive(true);
        }
    }

    public void SelectAnswer(int num)
    {
        if(num == levelQuestions[currentQuestionIndex].rightAnswer)
        {
            Debug.Log("Acertou");
            rightAnswerList[currentQuestionIndex] = true;
        }
        else
        {
            Debug.Log("Errou");
            rightAnswerList[currentQuestionIndex] = false;
        }

        nextButton.interactable = true;
    }

    public void SendResultToServer()
    {
        StartCoroutine(Upload(answerInput.text));
    }

    IEnumerator Upload(string answer)
    {
        if(answer != "" && answer != null)
        {
            int nota = 0;

            foreach(bool resposta in rightAnswerList)
            {
                if (resposta)
                {
                    nota++;
                }
            }

            Debug.Log($"Acertou {nota} questoes. Resposta aberta: {answer}");

            WWWForm form = new WWWForm();
            form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));
            form.AddField("post_level", PlayerPrefs.GetInt("quiz_level_to_load"));
            form.AddField("post_answer", answer);
            form.AddField("post_quiz_score", nota);

            UnityWebRequest www = UnityWebRequest.Post(ApiConfig.INSERT_ANSWERS, form);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                answerInput.text = "";
            }

            Debug.Log("Envia resultado e pergunta aberta para o servidor");
        }
        else
        {
            Debug.Log("Questao aberta esta nula");
        }
    }
}