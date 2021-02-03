using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizzSuporte : MonoBehaviour
{
    public int ID;
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text respostaE;

    public void ApertoToggle(int numero)
    {
        if(numero == Quizz.perguntaCorreta)
        {
            pergunta.text = "acertomizerave";
        }
    }
    
}
