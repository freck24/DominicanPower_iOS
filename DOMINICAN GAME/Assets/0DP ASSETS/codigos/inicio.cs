using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SceneManagement;



public class inicio : MonoBehaviour
{

	public GameObject me;
	public GameObject CM;
	public float primeravez =0f;
	public AudioClip pop;
	private AudioSource p;

	// Use this for initialization
	void Start()
	{
		p = GetComponent<AudioSource>();
		//me.SetActive(false);

		//CM.SetActive(false);
		Time.timeScale = 1f;

		primeravez = PlayerPrefs.GetFloat("prime", 0f);

		nivel = PlayerPrefs.GetFloat("nivel", 1);
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	public float nivel;
	public void Comenzar ()
	{
		p.clip = pop;
		p.Play();

		PreLoaderLevel.preload.CargaLvl("inicio");
	}
	public void Continuar()
	{
		p.clip = pop;
		p.Play();


	
		//	SceneManager.LoadScene("nivel1");
	
	}


	public void IniCIo()
	{
		p.clip = pop;
		p.Play();

		me.SetActive(true);
	}

	public void IniC()
	{
		p.clip = pop;
		p.Play();

		if (PlayerPrefs.GetFloat("prime", 0f) == 0)
		{// CM.SetActive(true);
		}
		else
		{
		//	SceneManager.LoadScene("nivel1");
		}

	}

	public void salir()
	{
		p.clip = pop;
		p.Play();

		Application.Quit();
	}public void trivi()
	{
		p.clip = pop;
		p.Play();

		SceneManager.LoadScene("triviar");
	}


}