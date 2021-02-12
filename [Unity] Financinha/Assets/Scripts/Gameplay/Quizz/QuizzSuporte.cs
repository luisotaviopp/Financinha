using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizzSuporte : MonoBehaviour
{
    public Quizz quiz;
    public int ID;
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text respostaE;

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
        }
        quiz.Set_Quizz();
    }
    public void Previous_Button()
    {
        if (ID == quiz.respostaCorreta)
        {
            quiz.score--;
        }
        if (quiz.questaoAtual > 0)
        {
            quiz.questaoAtual--;
        }
        quiz.Set_Quizz();
    }

}
