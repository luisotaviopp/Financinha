using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscenes : MonoBehaviour
{
    public Sprite[] cutscene1;
    public Sprite[] cutscene2;
    public Sprite[] cutscene3;
    public Sprite[] cutscene4;
    public Sprite[] cutscene5;
    public Sprite[] cutscene6;
    public Sprite[] cutscene7;
    public Sprite[] cutscene8;
    public Sprite[] cutscene9;
    public Sprite[] cutscene10;
    public Sprite[] currentCutscene;
    public Image renderImg;
    public int currentLevel;
    public int currentIndex = 0;
    public GameObject quizPanel;
    public GameObject loadingPanel;

    void OnEnable()
    {

        currentLevel = PlayerPrefs.GetInt("quiz_level_to_load");

        switch (currentLevel) 
        {
            case 1:
                currentCutscene = cutscene1;
                LoadCutscene();
                break;

            case 2:
                currentCutscene = cutscene2;
                LoadCutscene();
                break;

            default:
                currentCutscene = cutscene1;
                LoadCutscene();
                break;
        }
    }

    private void LoadCutscene()
    {
        renderImg.sprite = currentCutscene[currentIndex];
    }

    public void NextSprite()
    {
        if(currentIndex < currentCutscene.Length-1)
        {
            currentIndex++;
            renderImg.sprite = currentCutscene[currentIndex];
        }
        else
        {
            Debug.Log("Abre Quiz");
            quizPanel.SetActive(true);
        }
    }

    public void PrevSprite()
    {
        if(currentIndex > 0)
        {
            currentIndex--;
            renderImg.sprite = currentCutscene[currentIndex];
        }
        else
        {
            loadingPanel.SetActive(true);
            SceneManager.LoadSceneAsync(0);
        }
    }
}
