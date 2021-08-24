using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generdadorcasa : MonoBehaviour
{
	public GameObject ene;
	public GameObject ene2;
	public GameObject ene3;
	public GameObject ene4;
	public GameObject ene5;
	public GameObject ene6;
	public GameObject ene7;
	public GameObject ene8;
	public GameObject ene9;
	public float tiempo = 10f;
	bool ran = false;
	public float contador = 1f;
	Vector3 g;
	Vector3 h;



	void Start()
	{
		comenzar();

		g = transform.position;

	}

	public void crear()
	{
		h = new Vector3(transform.position.x, g.y, g.z);


	//	while (contador < 10)
		{
			contador = Random.Range(1f, 10f);
			contador = contador - contador % 1;
			if (contador == 1f)
			{
				Instantiate(ene, h, Quaternion.identity);
				
			}
			else
			if (contador == 2f)
			{
				Instantiate(ene2, h, Quaternion.identity);
				
			}else
			if (contador == 3f)
			{
				Instantiate(ene3, h, Quaternion.identity);
				
			}else
			if (contador == 4f)
			{
				Instantiate(ene4, h, Quaternion.identity);
				
			}else
			if (contador == 5f)
			{
				Instantiate(ene5, h, Quaternion.identity);
				
			}else
			if (contador == 6f)
			{
				Instantiate(ene6, h, Quaternion.identity);
				
			}else
			if (contador == 7f)
			{
				Instantiate(ene7, h, Quaternion.identity);
				
			}else
			if (contador == 8f)
			{
				Instantiate(ene8, h, Quaternion.identity);
				
			}else
			if (contador == 9f)
			{
				Instantiate(ene9, h, Quaternion.identity);
				
			}

			contador += 1f;


			/*if(contador == 9)
			{
				contador = 1f;
			}*/
		}
	}
	public bool tuto = false;

	public void comenzar()
	{
		
			InvokeRepeating("crear", 0f, tiempo);

	}

	public void cancelargen()
	{
		CancelInvoke("crear");
	}

	void Update()
	{
		transform.Translate(50f*Time.deltaTime, 0, 0);
	}


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "destroy")
		{
			cancelargen();
			Destroy(gameObject);
		}
	}

}
