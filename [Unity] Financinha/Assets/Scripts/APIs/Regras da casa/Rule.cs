using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

[System.Serializable]
public class Rule
{
    public int id;
    public string name;
    public float value;
    public int quantity;
    public string total_week;
    public Text quantityDisplay;
    public Text totalValueDisplay;
}
