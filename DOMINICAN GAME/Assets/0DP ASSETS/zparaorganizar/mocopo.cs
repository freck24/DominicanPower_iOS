using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mocopo : MonoBehaviour
{
	public float velocidadpoli = 20f;
	Vector3 x = Vector3.left;
	public bool xt = false;
	public bool irse2 = false;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position += x * velocidadpoli * Time.deltaTime;
		if(xt)
		{
			velocidadpoli =0f; 
		}
		/*if (transform.position.x > 170 && PlayerPrefs.GetFloat("nivel", 0) != 5 && PlayerPrefs.GetFloat("nivel", 0) != 6)
		{
			velocidadpoli = 30;
			transform.position = new Vector3(transform.position.x, -7.5f, transform.position.z);
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}*/
		

			if (PlayerPrefs.GetFloat("nivel", 0) == 7)
		{
			Destroy(gameObject);
		}

		if (irse2 == true)
		{
			velocidadpoli = -30f;
		}
	}





	void OnTriggerEnter2D(Collider2D otr)
	{
		if (otr.gameObject.tag == "destroy"|| otr.gameObject.tag == "poli")
		{

			Destroy(gameObject);

		}

		if (otr.gameObject.tag == "caminao")
		{

			//xt = true;
		}

		if (otr.gameObject.tag == "activar")
		{

		//	irse2 = true;
		}



	}
}
