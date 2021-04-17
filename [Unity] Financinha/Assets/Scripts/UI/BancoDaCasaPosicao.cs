using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BancoDaCasaPosicao : MonoBehaviour
{

    // 1660 (posicao mais alta)
    // -1400 (posicao mais baixa)
    // 3060 (quantidade de pixels entre o ponto mais alto e o mais baixo) / valor da conquista
    // 3060 / 110 = 27.81
    // pos = (3060 / valor da conquista) * valor carteira

    public RectTransform botaoCofrinho;
    public float quantidadePixels = 3110;


    // Start is called before the first frame update
    private void Update()
    {
        float valorObjetivo = PlayerPrefs.GetFloat("objective_value");
        float valorBanco = PlayerPrefs.GetFloat("bank_amount");

        float newPos;

        if(PlayerPrefs.HasKey("objective_value"))
        {
            newPos = -1450 + (quantidadePixels / valorObjetivo * valorBanco);
        }
        else
        {
            newPos = -1450f;
        }

        botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, newPos);
    }
}
