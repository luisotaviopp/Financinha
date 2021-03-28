using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetQuestions : MonoBehaviour
{
    #region Variaveis
        public Text questionText;
        public Text option1Text;
        public Text option2Text;
        public Text option3Text;
        public Text option4Text;
        public Text option5Text;

        public GameObject levelPanel;
        public GameObject quizPanel;
        public GameObject openAnswerPanel;
        public GameObject finalPanel;

    private int questionIndex = 0;

        public List<SelectedAnswer> selectedAnswers;

        private QuestionsList questionsList;
    #endregion

    public void GetInfo(int level)
    {
        StartCoroutine(GetQuestionsCorroutine());
    }

    IEnumerator GetQuestionsCorroutine()
    {
        WWWForm form = new WWWForm();

        form.AddField("post_level", 1);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.GET_QUESTIONS_BY_LEVEL, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            //Retorna a lista de questões
            string result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
            questionsList = JsonUtility.FromJson<QuestionsList>("{\"questions\":" + result + "}");

            questionText.text = questionsList.questions[questionIndex].question;
            option1Text.text = questionsList.questions[questionIndex].option_1;
            option2Text.text = questionsList.questions[questionIndex].option_2;
            option3Text.text = questionsList.questions[questionIndex].option_3;
            option4Text.text = questionsList.questions[questionIndex].option_4;
            option5Text.text = questionsList.questions[questionIndex].option_5;

            quizPanel.SetActive(true);
            levelPanel.SetActive(false);
        }
    }

    public void NextQuestion()
    {
        if (questionIndex < 4)
        {
            questionIndex++;

            questionText.text = questionsList.questions[questionIndex].question;
            option1Text.text = questionsList.questions[questionIndex].option_1;
            option2Text.text = questionsList.questions[questionIndex].option_2;
            option3Text.text = questionsList.questions[questionIndex].option_3;
            option4Text.text = questionsList.questions[questionIndex].option_4;
            option5Text.text = questionsList.questions[questionIndex].option_5;
        } 
        else
        {
            openAnswerPanel.SetActive(true);
            levelPanel.SetActive(false);
            quizPanel.SetActive(false);
        }
    }

    public void PreviousQuestion()
    {
        if (questionIndex > 0)
        {
            questionIndex--;
            questionText.text = questionsList.questions[questionIndex].question;
            option1Text.text = questionsList.questions[questionIndex].option_1;
            option2Text.text = questionsList.questions[questionIndex].option_2;
            option3Text.text = questionsList.questions[questionIndex].option_3;
            option4Text.text = questionsList.questions[questionIndex].option_4;
            option5Text.text = questionsList.questions[questionIndex].option_5;
        }
        else
        {
            levelPanel.SetActive(true);
            quizPanel.SetActive(false);
        }
    }

    public void SelectAnswer(int option)
    {
        // Verifica se já tem alguma resposta cadastrada para essa questão
        SelectedAnswer selected = selectedAnswers.Find((x) => x.questionId == questionsList.questions[questionIndex].id);

        if (selected == null)
        {
            // Monta o objeto a ser salvo.
            SelectedAnswer newSelection = new SelectedAnswer
            {
                questionId = questionsList.questions[questionIndex].id,
                selectedAnswer = option
            };

            // Salva a resposta
            selectedAnswers.Add(newSelection);

            Debug.Log("Cadastrando nova resposta");
        }
        else
        {
            // Pega o index onde está a resposta cadastrada.
            int index = selectedAnswers.IndexOf(selected);

            // Remove no index da resposta selecionada anteriormente.
            selectedAnswers.RemoveAt(index);

            //Adiciona mais um registro na lista de respostas selecionadas.
            SelectedAnswer newSelection = new SelectedAnswer()
            {
                questionId = questionsList.questions[questionIndex].id,
                selectedAnswer = option
            };

            // Salva a resposta nova
            selectedAnswers.Add(newSelection);

            Debug.Log("Substituindo a resposta já selecionada.");
        }
    }

    public void SendAnswersToServer()
    {
        selectedAnswers.ForEach((x) => {
            StartCoroutine(SendSelectedAnswers(x));
        });

        levelPanel.SetActive(false);
        quizPanel.SetActive(false);
        openAnswerPanel.SetActive(false);
        finalPanel.SetActive(true);

        selectedAnswers.Clear();
    }

    IEnumerator SendSelectedAnswers(SelectedAnswer answer)
    {
        WWWForm form = new WWWForm();

        form.AddField("post_question_id", answer.questionId);
        form.AddField("post_selected_option", answer.selectedAnswer);

        UnityWebRequest www = UnityWebRequest.Post(ApiConfig.INSERT_QUESTION_RESPONSES, form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
    }

    public void BackToMenu() {
        SceneManager.LoadSceneAsync(0);
    }
}