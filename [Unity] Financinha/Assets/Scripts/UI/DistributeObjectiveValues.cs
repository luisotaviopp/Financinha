using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistributeObjectiveValues : MonoBehaviour
{
	[SerializeField] private float objectiveValue;
	[SerializeField] private Text[] valueTexts;

	void Start()
	{
		float partial = objectiveValue / valueTexts.Length;
		int expoent = 1;

		foreach (var txt in valueTexts)
		{
			float partialMultiplication = partial*expoent;

			txt.text = partialMultiplication.ToString();

			expoent++;
		}
	}
}
