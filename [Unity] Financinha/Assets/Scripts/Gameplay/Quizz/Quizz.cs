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
        public int respostaCorretaID;
        public int idQuiz;
    }
    public void Start()
    {
        Set_Quizz(questaoAtual);
       
    }
    public void Set_Quizz(int escolhendoQuestao)
    {
            foreach(QuizzSuporte quizsup in quiz_GO)
            {
                quizsup.pergunta.text = respostass[questaoAtual + escolhendoQuestao].pergunta;
                quizsup.respostaA.text = respostass[questaoAtual + escolhendoQuestao].repostaA;
                quizsup.respostaB.text = respostass[questaoAtual + escolhendoQuestao].repostaB;
                quizsup.respostaC.text = respostass[questaoAtual + escolhendoQuestao].repostaC;
                quizsup.respostaD.text = respostass[questaoAtual + escolhendoQuestao].repostaD;
                quizsup.respostaE.text = respostass[questaoAtual + escolhendoQuestao].repostaE;
                respostaCorreta = respostass[questaoAtual + escolhendoQuestao].respostaCorretaID;
            }
    }  

}
