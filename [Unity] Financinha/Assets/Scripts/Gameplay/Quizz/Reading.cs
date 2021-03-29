using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Reading : MonoBehaviour
{
    public GameObject quiz;
    public GameObject btn_Quiz;
    public GameObject btn_Reading;
    public GameObject reading;



    public Image readHistory;
    public Sprite[] receptor;

    public Sprite[] story_Level1;
    public Sprite[] story_Level2;
    public Sprite[] story_Level3;
    public Sprite[] story_Level4;
    public Sprite[] story_Level5;
    public Sprite[] story_Level6;
    public Sprite[] story_Level7;
    public Sprite[] story_Level8;

    public int level_Que_Veio; // necessario conseguir essa informação.......


    public int imgSelect;

    public void Start()
    {
        level_Que_Veio = SceneLoader.refLevel;
        switch (level_Que_Veio)
        {
            case 1:
                receptor = story_Level1;
                readHistory.sprite = receptor[0];
                return;
            case 2:
                receptor = story_Level2;
                readHistory.sprite = receptor[0];
                return;
            case 3:
                receptor = story_Level3;
                readHistory.sprite = receptor[0];
                return;
            case 4:
                receptor = story_Level4;
                readHistory.sprite = receptor[0];
                return;
            case 5:
                receptor = story_Level5;
                readHistory.sprite = receptor[0];
                return;
            case 6:
                receptor = story_Level6;
                readHistory.sprite = receptor[0];
                return;
            case 7:
                receptor = story_Level7;
                readHistory.sprite = receptor[0];
                return;
            case 8:
                receptor = story_Level8;
                readHistory.sprite = receptor[0];
                return;
            case 9:
                receptor = story_Level8;
                readHistory.sprite = receptor[0];
                return;
            case 10:
                receptor = story_Level8;
                readHistory.sprite = receptor[0];
                return;
        }
        
       
    }
    public void Set_NextImg()
    {

        if (imgSelect < receptor.Length-1)
        {
            imgSelect++;
            readHistory.sprite = receptor[imgSelect];
           
            return;
        }
        if (imgSelect == receptor.Length - 1)
        {
            btn_Reading.SetActive(false);
            btn_Quiz.SetActive(true);
        }
    }
    public void Set_PreviousImg()
    {

           
            if (imgSelect > 0)
                {
            imgSelect--;
            // SceneManager.LoadSceneAsync(SceneLoader.refLevel);
            }
            
            readHistory.sprite = receptor[imgSelect];       
            if (imgSelect < receptor.Length - 1)
            {
                btn_Quiz.SetActive(false);
                btn_Reading.SetActive(true);
            }
            return;
        
       

    }
    public void OpenQuiz()
    {
        reading.SetActive(false);
        quiz.SetActive(true);
    }

}
