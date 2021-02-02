using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    Question[] questions;

    int selectedQuestion = 0;
    public Text questionText1;
    public Text questionText2;
    public Text questionText3;
    public Text questionText4;

    public Text openQuestion;

    private int score = 0;

    GameObject questionsPanel;
    GameObject openQuestionInput; 

    private void Start()
    {
        questionsPanel.SetActive(true);
        openQuestionInput.SetActive(false); 
        score = 0;
        selectedQuestion = 0;
        RenderQuestion();
    }

    public void SelectOption(int selected)
    {
        if (questions[selectedQuestion].rightAnswer == selected)
        {
            Debug.Log("Acertou");
            score++;
        }

        if (selectedQuestion < questions.Length)
        {
            selectedQuestion++;
            RenderQuestion();
        }
        else
        {
            questionsPanel.SetActive(true);
            openQuestionInput.SetActive(false);
        }
    }

    public void RenderQuestion()
    {
        questionText1.text = questions[selectedQuestion].optionA;
        questionText2.text = questions[selectedQuestion].optionB;
        questionText3.text = questions[selectedQuestion].optionC;
        questionText4.text = questions[selectedQuestion].optionD;
    }
}
