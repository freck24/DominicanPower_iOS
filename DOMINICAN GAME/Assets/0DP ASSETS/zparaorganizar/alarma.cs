using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarma : MonoBehaviour {
	public GameObject mo;
	public GameObject ipo;
	public controler cou;
	public bool correc = true;

	

	// Use this for initialization
	void Start() {
		

	}

	// Update is called once per frame
	void Update() {




		if (cou.paus == 0f && correc==false)
		{
			mo.gameObject.SetActive(false);
			ipo.gameObject.SetActive(false);

			
		}


	}
	void OnTriggerExit2D(Collider2D otr)
	{
		
		if (otr.gameObject.tag == "alertamo")
		{
			mo.gameObject.SetActive(false);
		}

		if (otr.gameObject.tag == "alertapo")
		{

			ipo.gameObject.SetActive(false);
		}
	} 
	




		void OnTriggerEnter2D(Collider2D otr)
		{
			if (otr.gameObject.tag == "alertamo" && cou.paus == 1)
		{
			
			
			
			mo.gameObject.SetActive(true);
			ipo.gameObject.SetActive(false);
		
		


		}


			if (otr.gameObject.tag == "alertapo" && cou.paus == 1)
			{
			
			ipo.gameObject.SetActive(true);
				mo.gameObject.SetActive(false);
		

		}




		}
	} 
