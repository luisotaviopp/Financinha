using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reading : MonoBehaviour
{
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
    }
    public void Set_PreviousImg()
    {
        
        if (imgSelect > 0)
        {
            imgSelect--;
            readHistory.sprite = img[imgSelect];
            return;
        }
    }

}
