using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistributeObjectiveValues : MonoBehaviour
{
	[SerializeField] private float objectiveValue = 0;
	[SerializeField] private Text[] valueTexts;

	public Sprite cadeadoVerde;
	public Sprite cadeadoVermelho;
	public Image[] cadeadosHabilidade;

	public Image luaVovo;
	public Sprite luaVovoNave;

	public List<float> values;

    public Button first_level_button;

	void OnEnable()
	{
		
		if (PlayerPrefs.HasKey("objective_value"))
		{
			objectiveValue = PlayerPrefs.GetFloat("objective_value");
		}

		foreach (Image img in cadeadosHabilidade)
		{
			img.sprite = cadeadoVermelho;
		}

		float partial = objectiveValue / valueTexts.Length;
		int expoent = 1;

		foreach (var txt in valueTexts)
		{
			float partialMultiplication = partial * expoent;

			txt.text = partialMultiplication.ToString();

			values.Add(partialMultiplication);

			expoent++;
		}

		for (int i = 0; i < values.Count; i++)
		{
			if (values[i] <= PlayerPrefs.GetFloat("bank_amount"))
			{
				cadeadosHabilidade[i].sprite = cadeadoVerde;

				if(cadeadosHabilidade[cadeadosHabilidade.Length - 1].sprite.name == "cadeado-aberto")
                {
					luaVovo.sprite = luaVovoNave;
                }
			}
		}

        // Libera a primeira fase se o valor da carteira for maior que o valor da fase
        if(values[0] <= PlayerPrefs.GetFloat("bank_amount"))
        {
            first_level_button.interactable = true;
            cadeadosHabilidade[0].sprite = cadeadoVerde;
        }
    }
}
