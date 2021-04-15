using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[System.Serializable]
public class QuizQuestion
{
    public int level;
    public int rightAnswer;
    public bool isImage;
    public string question;
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
    public string answer5;
    public Sprite questionSprite;
}
