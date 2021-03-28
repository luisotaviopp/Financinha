using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SimuladorSemanada : MonoBehaviour
{
   public InputField _inputPresente;
   public InputField _inputGuardado;
   public InputField _inputMinimo;
   public InputField _inputSemanal;

   public Text txtCausa;
   public Text txtConquista;
   public Text txtQtSemana;
   public Text txtSemanada;

   [SerializeField] private float valorPresente;
   [SerializeField] private float valorGuardado;
   [SerializeField] private float valorMinimo;
   [SerializeField] private float valorMetaSemanal;

   [SerializeField] private float valorSemanada = 0;
   [SerializeField] private float valorConquista = 0;
   [SerializeField] private float valorCausa = 0;
   [SerializeField] private float qtSemanas = 0;

	void Start ()
	{
		_inputPresente.onValueChange.AddListener(delegate {MudaPresente(_inputPresente); });
		_inputGuardado.onValueChange.AddListener(delegate {MudaGuardado(_inputGuardado); });
		_inputMinimo.onValueChange.AddListener(delegate {MudaMinimo(_inputMinimo); });
		_inputSemanal.onValueChange.AddListener(delegate {MudaSemanal(_inputSemanal); });
	}

	void MudaPresente(InputField input)
	{
		valorPresente = float.Parse(input.text);
		Calcula();
	}

	void MudaGuardado(InputField input)
	{
		valorGuardado = float.Parse(input.text);
		Calcula();
	}

	void MudaMinimo(InputField input)
	{
		valorMinimo = float.Parse(input.text);
		Calcula();
	}

	void MudaSemanal(InputField input)
	{
		valorMetaSemanal = float.Parse(input.text);
		Calcula();
	}

	void Calcula()
	{
		valorCausa = (valorPresente*0.1f);
		txtCausa.text = valorCausa.ToString();

		valorConquista = (valorPresente + valorCausa);
		txtConquista.text = valorConquista.ToString();

		qtSemanas = (valorConquista-valorGuardado)/(valorMinimo+valorMetaSemanal);
		txtQtSemana.text = Mathf.Round(qtSemanas).ToString();

		valorSemanada = (valorConquista-valorGuardado)/qtSemanas;
		txtSemanada.text = valorSemanada.ToString();

		UpdateSemanadaOnDb(valorSemanada);

		PlayerPrefs.SetFloat("semanada", valorSemanada);
		PlayerPrefs.Save();
		
		// Debug.Log($"valorPresente: {valorPresente}, valorGuardado: {valorGuardado }, valorMinimo: {valorMinimo }, valorMetaSemanal: {valorMetaSemanal }");
	}

	void UpdateSemanadaOnDb(float semanada)
	{
		StartCoroutine(UpdateSemanadaCoroutine(semanada));
	}

	IEnumerator UpdateSemanadaCoroutine(float semanada)
	{
		WWWForm form = new WWWForm();
		form.AddField("post_semanada", semanada.ToString());
		form.AddField("post_id", PlayerPrefs.GetInt("id_aprendiz"));

		UnityWebRequest www = UnityWebRequest.Post(ApiConfig.UPDATE_SEMANADA, form);
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error); 
		}
		else
		{
			Debug.Log(www.downloadHandler.text);
		}
	}
}
