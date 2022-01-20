using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorP : MonoBehaviour {
	

	[SerializeField] private Color ccolor = Color.black;
	[SerializeField] private Color incolor = Color.black;
	[SerializeField] private float wait = 1f;
	[SerializeField] private float timeanima = 1f;


	public float puntos = 0f;
	private Gpregunta gepre = null;
	private QUIZ quiz = null;
	public GameObject pregunt;
//public GameObject activar;
	public GameObject mens;
//	public GameObject menos;
	public controler contr;
//	public alarma al;
	public mov m;
	public AudioSource a;
	public AudioClip win;
	public AudioClip lose;
	public GameObject PANEL;

	private AudioSource aud;
	// Use this for initialization
	void Start () {
		gepre = GameObject.FindObjectOfType<Gpregunta>();
		quiz = GameObject.FindObjectOfType<QUIZ>();
	//	menos.SetActive(false);
		

		ProxPre();
	}


	public void ProxPre()
	{
		quiz.Construir(gepre.random(), GiveAnswer);
		PANEL.SetActive(false);
	}

	private void GiveAnswer(Opcionesbotones opcionesbotones)
	{
		StartCoroutine(Giveco(opcionesbotones));
		//ProxPre();
	}

	

	private IEnumerator Giveco( Opcionesbotones opcionesbotones)

	{
		print("GIVE CO CALLED");
		opcionesbotones.SetColor(opcionesbotones.Opciones.correcta ? ccolor : incolor);

		PANEL.SetActive(true);
		if (opcionesbotones.Opciones.correcta)   // aqui es pregunta correcta
		{
			if (PlayerPrefs.GetInt("preguntasd", 200) > 0)
			{
				PlayerPrefs.SetFloat("niveld", PlayerPrefs.GetFloat("niveld", 0) + 50); //subir
				PlayerPrefs.SetInt("correct", PlayerPrefs.GetInt("correct", 0) + 1);
			}



			if(SceneManager.GetActiveScene().name.Contains("INSIGNIA"))
            {
				print("SE GANO UNA INSIGNIA");
				FindObjectOfType<LoaderLevSign>().CompletarNivel();
            }



			if (PlayerPrefs.GetInt("ff", 0) == 0)
			{
			//	ProxPre();

				print("FF ES = 0");
				contr.f = true;
				contr.ga = true;
				contr.h = 1;
				//	activar.gameObject.SetActive(true);
				contr.iniciarpld();

			//	contr.planeta.

				yield return new WaitForSeconds(wait);

			//	al.correc = true;
				contr.continuar = true;
				puntos += 1f;
			}
            else
            {
				print("FF ES = 1");

				a.PlayOneShot(win);
            }


			yield return new WaitForSeconds(1);
			
			ProxPre(); 

		//	pregunt.gameObject.SetActive(false);

		}

		else
		{ // aqui pregunta incorrecta
			PlayerPrefs.SetFloat("niveld", PlayerPrefs.GetFloat("niveld", 0) - 50);
			PlayerPrefs.SetInt("incorrect", PlayerPrefs.GetInt("incorrect", 0) + 1);
			if (PlayerPrefs.GetInt("ff", 0) == 0)
			{
				contr.pe = true;
				contr.canva.SetActive(true);
				
				//activar.gameObject.SetActive(true);
				mens.gameObject.SetActive(true);
				contr.boto.SetActive(true);

			}
			else
			{
				a.PlayOneShot(lose);
			}
			yield return new WaitForSeconds(wait);
			
			ProxPre();// camnia la pregunta al perder

			if (PlayerPrefs.GetInt("ff", 0) == 0)
			{
			//	al.correc = true;
			}
			
			puntos -= 1f;


			

			
			
		}


	}
	
	
}
