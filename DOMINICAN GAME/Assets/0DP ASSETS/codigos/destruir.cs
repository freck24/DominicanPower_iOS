using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destruir : MonoBehaviour {
	

	public controler con;
	//public GameObject partiuclas;
	///public GameObject sayayin;
	//public AudioClip poder;
	//private AudioSource a;
	//public float contadorpower = 0;
	// Use this for initialization
	void Start () {
	//	a = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D( Collider2D otro)
	{
		if (otro.gameObject.tag == "Player")
		{
			//partiuclas.SetActive(false);
			//partiuclas.SetActive(true);
			StartCoroutine(particua());
		//	con.g = con.platano;
		//	con.platano +=  1; 
		
		}
	}




	public IEnumerator particua()
	{
		yield return new WaitForSecondsRealtime(0.01f);
		Destroy(gameObject);
	}

}
