using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quizz : MonoBehaviour
{
    public static int perguntaCorreta;
    public List<QuizzSuporte> lala = new List<QuizzSuporte>();
    public List<Respostas> respostass = new List<Respostas>();
    [System.Serializable]public class Respostas 
    {
        public string pergunta;
        public string repostaA;
        public string repostaB;
        public string repostaC;
        public string repostaD;
        public string repostaE;
        public int respostaCorretaID;
    }
    public void Start()
    {
        Set_Quizz();
    }
    void Set_Quizz()
    {
        foreach(Respostas respostas in respostass)
        {
            foreach(QuizzSuporte quizsup in lala)
            {
                quizsup.pergunta.text = respostas.pergunta;
                quizsup.respostaA.text = respostas.repostaA;
                quizsup.respostaB.text = respostas.repostaB;
                quizsup.respostaC.text = respostas.repostaC;
                quizsup.respostaD.text = respostas.repostaD;
                quizsup.respostaE.text = respostas.repostaE;
                perguntaCorreta = respostas.respostaCorretaID;
}
        }
    }
}
