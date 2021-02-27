using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class BtnFinancinha
{
    public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}

public class TesteListaRenderizada : MonoBehaviour
{
    [System.Serializable]
    public struct Elementos
    {
        public string nome;
        public string valor;
    }

    [SerializeField] List<Elementos> elementos = new List<Elementos>();

    private void Start()
    {
        GameObject template = transform.GetChild(0).gameObject;
        GameObject g;

        for (int i = 0; i < elementos.Count; i++)
        {
            g = Instantiate(template, transform);
            g.transform.GetChild(0).GetComponent<Text>().text = elementos[i].nome;
            g.transform.GetChild(1).GetComponent<Text>().text = elementos[i].valor;

            g.GetComponent<Button>().AddEventListener(i, ItemClicked);
        }

        Destroy(template.gameObject);
    }

    void ItemClicked (int itemIndex)
    {
        Debug.Log("Clicou no item: " + elementos[itemIndex].nome + elementos[itemIndex].valor);
    }
}




// Altamente inspirado nesse cara aqui: https://www.youtube.com/watch?v=Lq170ztDAPo