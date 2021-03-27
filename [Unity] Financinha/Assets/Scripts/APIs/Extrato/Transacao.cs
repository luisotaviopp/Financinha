using UnityEngine.UI;

[System.Serializable]
public class Transacao
{
    public int id;
    public float value;
    public string type;
    public string reason;
    public string created_at;
    public Text refToDelete;
}
