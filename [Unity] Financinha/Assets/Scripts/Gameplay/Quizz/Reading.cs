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
    public Sprite[] img;
    public int imgSelect;

    public void Start()
    {
        readHistory.sprite = img[imgSelect];
    }
    public void Set_NextImg()
    {

        if (imgSelect < img.Length-1)
        {
            imgSelect++;
            readHistory.sprite = img[imgSelect];
           
            return;
        }
        if (imgSelect == img.Length - 1)
        {
            btn_Reading.SetActive(false);
            btn_Quiz.SetActive(true);
        }
    }
    public void Set_PreviousImg()
    {

            imgSelect--;
            if (imgSelect < 0)
                {
                    SceneManager.LoadSceneAsync(SceneLoader.refLevel);
                }
            
            readHistory.sprite = img[imgSelect];       
            if (imgSelect < img.Length - 1)
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
