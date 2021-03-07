using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCheck : MonoBehaviour
{
    public int level;
    public RectTransform botaoCofrinho;
    public float pos1;
    public float pos2;
    public float pos3;
    public float pos4;
    public float pos5;
    public float pos6;
    public float pos7;
    public float pos8;
    public float pos9;
    public float pos10;

    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        ChangeCofrinhoPosition(level);
    }

    public void ChangeCofrinhoPosition(int lvl)
    {
        switch (lvl)
        {
            case 1:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos1);
                break;
            case 2:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos2);
                break;
            case 3:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos3);
                break;
            case 4:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos4);
                break;
            case 5:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos5);
                break;
            case 6:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos6);
                break;
            case 7:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos7);
                break;
            case 8:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos8);
                break;
            case 9:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos9);
                break;
            case 10:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos10);
                break;
            default:
                botaoCofrinho.anchoredPosition = new Vector2(botaoCofrinho.anchoredPosition.x, pos1);
                break;
        }
    }
}
