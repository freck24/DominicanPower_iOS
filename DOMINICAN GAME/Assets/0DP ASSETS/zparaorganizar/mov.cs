using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
//using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class mov : MonoBehaviour
{
	//private Rigidbody2D rigi;
	public float velocidadmoto = -5f;
	Vector3 x = Vector3.left;
	public controler pl;
	public bool c = false;
	bool irse = false;
	
	public GameObject t1;
	public GameObject t2;
	public GameObject t3;
	public GameObject t4;
	public controler co;
	public bool pre = false;
	public bool dom = false;
	public bool prim = true;
	

	// Use this for initialization
	void Start()
	{
		prim = true;
	}

	// Update is called once per frame
	void Update()

		
	{

		transform.position += x * velocidadmoto * Time.deltaTime;
		
		/*if(transform.position.x > 170 && PlayerPrefs.GetFloat("nivel", 0) != 5 && PlayerPrefs.GetFloat("nivel", 0) != 6)
		{
			transform.position = new Vector3(transform.position.x, -7.2f, transform.position.z);
			velocidadmoto = 30;
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}

		if (PlayerPrefs.GetFloat("nivel", 0) == 5 && PlayerPrefs.GetFloat("nivel", 0) == 6)
		{
			if (transform.position.x > 300)
			{
				velocidadmoto = 30;
				transform.position = new Vector3(transform.position.x, -7.5f, transform.position.z+0.1f);
				transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
			}
		}*/


		if (PlayerPrefs.GetFloat("nivel", 0) == 7)
		{
			Destroy(gameObject);
		}







		if (c)
		{
			velocidadmoto =0f;

			if (prim)
			{
			//	co.pregg = true;

			//	StartCoroutine(d1());
				
			//	prim = false;
			}
			
			


		}
		if(irse == true)
		{
			velocidadmoto = -50f;
			t2.gameObject.SetActive(false);
		}


		


	}
	
		private IEnumerator d1()
	{
		//t1.gameObject.SetActive(true);

		yield return new WaitForSeconds(0f);

	}




	void OnTriggerEnter2D(Collider2D otr)
	{
		if (otr.gameObject.tag == "destroy")
		{

			

			Destroy(gameObject);
		
		}

		if (otr.gameObject.tag == "destroy")
		{

			c = true;
		}





		if (otr.gameObject.tag == "activar")
		{

			irse = true;
		}








	}



}
