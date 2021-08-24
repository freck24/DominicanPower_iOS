using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRACISOC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	public int calidad;
	public void calidadgrafica()
	{
		calidad = PlayerPrefs.GetInt("Q", 5);
		QualitySettings.SetQualityLevel(calidad, true);
		switch (calidad)
		{
			case 0:

				Screen.SetResolution(270, 480, true);
				break;
			case 1:
				Screen.SetResolution(360, 640, true);
				break;
			case 2:
				Screen.SetResolution(540, 960, true);
				break;
			case 3:
				Screen.SetResolution(540, 960, true);
				break;
			case 4:
				Screen.SetResolution(720, 1280, true);
				break;
			case 5:
				Screen.SetResolution(720, 1280, true);
				break;
		}

		ESCENA.SetActive(true);
	}

	public GameObject ESCENA;
	public void GUAYAHIELO()
    {
		PlayerPrefs.SetInt("Q", 3);
		calidadgrafica();
	}public void GUAYAHIELO2()
    {
		PlayerPrefs.SetInt("Q", 4);
		calidadgrafica();
	}public void GUAYAHIELO3()
    {
		PlayerPrefs.SetInt("Q", 5);
		calidadgrafica();
	}

	
	// Update is called once per frame
	void Update()
    {
        
    }

	public GameObject edad;
	public GameObject anuncio;


	public void menor()
    {
		PlayerPrefs.SetInt("edad", 1);
		edad.SetActive(false);

	
	}public void nomenor()
    {
		PlayerPrefs.SetInt("edad", 0);
		edad.SetActive(false);

	
	}


	public void anuncios()
    {
		    PlayerPrefs.SetInt("anu", 1);
			anuncio.SetActive(false);

	}
	public void SIanuncios()
    {
		    PlayerPrefs.SetInt("anu", 0);
			anuncio.SetActive(false);

	}

}
