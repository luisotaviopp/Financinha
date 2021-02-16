using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quizz : MonoBehaviour
{
    public int score;
    public  int respostaCorreta;
    public int questaoAtual;
    public List<QuizzSuporte> quiz_GO= new List<QuizzSuporte>();
    public List<Respostas> respostass = new List<Respostas>();
    [System.Serializable]public class Respostas 
    {
        public string pergunta;
        public string repostaA;
        public string repostaB;
        public string repostaC;
        public string repostaD;
        public string repostaE;
        public Sprite quizImg;
        public int respostaCorretaID;
        public bool imagem;

    }
    [System.Serializable]
    public class FivePoints
    {
        public string pergunta;
        public string repostaA;
        public Sprite quizImg;
        public bool imagem;

    }

    public void Start()
    {
        Set_Quizz();
       
    }
    public void Set_Quizz()
    {
       
            foreach(QuizzSuporte quizsup in quiz_GO)
            {
                quizsup.pergunta.text = respostass[questaoAtual ].pergunta;
                quizsup.respostaA.text = respostass[questaoAtual ].repostaA;
                quizsup.respostaB.text = respostass[questaoAtual ].repostaB;
                quizsup.respostaC.text = respostass[questaoAtual ].repostaC;
                quizsup.respostaD.text = respostass[questaoAtual ].repostaD;
                quizsup.respostaE.text = respostass[questaoAtual ].repostaE;
                respostaCorreta = respostass[questaoAtual].respostaCorretaID;
                if (respostass[questaoAtual].imagem)
                {
                    quizsup.img.sprite = respostass[questaoAtual].quizImg;
                }
                else
                {
                quizsup.img.sprite = null;
                }

                
            }
    }  
    public void Set_Five_Points_Quiz()
    {
        foreach (QuizzSuporte quizsup in quiz_GO)
        {
            quizsup.pergunta.text = respostass[questaoAtual].pergunta;
            quizsup.respostaA.text = respostass[questaoAtual].repostaA;
            if (respostass[questaoAtual].imagem)
            {
                quizsup.img.sprite = respostass[questaoAtual].quizImg;
            }
            else
            {
                quizsup.img.sprite = null;
            }


        }
    }

}
