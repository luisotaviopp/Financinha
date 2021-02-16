using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuizzSuporte : MonoBehaviour
{
    public Sprite[] points;
    public Image points_Img;
    public int pointsIndex;
    public Quizz quiz;
    public int ID;
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text respostaE;
    public Image img;

    public Text pergunta2;
    public Text respostaAA;

    public GameObject quizz_GO;
    public GameObject quizz_FivePoints;
    public void ApertoToggle(int numero)
    {
        ID = numero;
        if(numero == quiz.respostaCorreta)
        {
            pergunta.text += " ___" + "ACERTOMIZERAVI";
            return;
        }
        pergunta.text += " ___"+ "ERRO";
    }
    public void Next_Button()
    {
        if (ID == quiz.respostaCorreta)
        {         
            quiz.score++;
        }
        if (quiz.questaoAtual < quiz.respostass.Count-1)
        {
            quiz.questaoAtual++;
            if (quiz.questaoAtual == quiz.respostass.Count - 1)
            {
                if (pointsIndex == points.Length - 1)

                {
                    pointsIndex++;
                    points_Img.sprite = points[pointsIndex];
                }
                quizz_GO.SetActive(false);
                quizz_FivePoints.SetActive(true);
                quiz.Set_Five_Points_Quiz();
            } 
             if(pointsIndex < points.Length)
            {
                pointsIndex++;
            points_Img.sprite = points[pointsIndex];
            }
        }
        quiz.Set_Quizz();
       
    }
    public void Previous_Button()
    {

        if (quiz.questaoAtual > 0)
        {
            if(pointsIndex > 0)
            {
                pointsIndex--;
                points_Img.sprite = points[pointsIndex];
            }
            quiz.questaoAtual--;
            quiz.score--;
        }
        quiz.Set_Quizz();
    }

    public void FinishQuiz()
    {
        quiz.Set_Five_Points_Quiz();
        SceneManager.LoadSceneAsync(0);
    }
}
