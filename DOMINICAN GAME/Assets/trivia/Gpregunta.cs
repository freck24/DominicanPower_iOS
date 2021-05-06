using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gpregunta : MonoBehaviour {

	[SerializeField] private List<preguntas> mpreguntas = null;

	public Text letra = null;
	public GameObject pantallagana;
	public GameObject pantalla;
	public controladorP controla;
	public bool trivia = false;
	public int numerodepreguntas = 150;
	public int preguntasdisponibles = 200;
	public int ash;
	public int a;
	

	float t = 0;
	public float cantidaddepregunta = 10f;
	string cont = "Usted es Dominicano en un ";
	string po = "%";

	public preguntas random(bool remove = true)
	{    
		if(mpreguntas.Count == 0)
		{
			// AQUI CODIGO SIGUIENTE NIVEL
			
			t = controla.puntos*100;
			t = t / cantidaddepregunta; ;
			letra.text = cont + t + po;

			if (trivia)
			{
				pantallagana.gameObject.SetActive(true);
			}



		}
	
		if (PlayerPrefs.GetFloat("primera", 0) == 0)  //arreglar
		{
			a = Random.Range(0, mpreguntas.Count);
			PlayerPrefs.SetInt("preguntas", a);
			PlayerPrefs.SetFloat("primera", 1);
		}
		
	
		a = PlayerPrefs.GetInt("preguntas", 0) + 1;
		PlayerPrefs.SetInt("pd", PlayerPrefs.GetInt("pd", 0) + 1);
		preguntasdisponibles = numerodepreguntas - PlayerPrefs.GetInt("pd", 0);
		PlayerPrefs.SetInt("preguntasd", preguntasdisponibles);


		if (!remove)
			
			return mpreguntas[a];

		ash = a;
		PlayerPrefs.SetInt("preguntas", a);
		// si lo daa;as quita esto

		if (a >= numerodepreguntas-1)
		{
			a = 0;
			PlayerPrefs.SetInt("preguntas", a);
		}
	
			preguntas q = mpreguntas[a];
		   // mpreguntas.RemoveAt(a);       
		
		return q;
	}

}
