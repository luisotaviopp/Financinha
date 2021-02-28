using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DezPorcento : MonoBehaviour
{
    public InputField input;
    public Text display;

    public void ConverteTexto()
    {
        Debug.Log(input.text);
        display.text = (float.Parse(input.text) * 0.1).ToString();
    }
}
