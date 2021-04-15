using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscenes : MonoBehaviour
{
    public Sprite[] cutscene1;
    public Sprite[] cutscene2;
    public Image renderImg;
    public int currentLevel;

    void OnEnable()
    {
        renderImg = GetComponent<Image>();

        currentLevel = PlayerPrefs.GetInt("quiz_level_to_load");

        switch (currentLevel) 
        {
            case 1:
                LoadCutscene(cutscene1);
                break;

            case 2:
                LoadCutscene(cutscene2);
                break;

            default:
                LoadCutscene(cutscene1);
                break;
        }
    }

    private void LoadCutscene(Sprite[] cs)
    {
        int currentIndex = 0;
        renderImg.sprite = cs[currentIndex];
    }
}
