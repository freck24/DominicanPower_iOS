using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instanciador : MonoBehaviour
{
	public Transform p2;
	public Transform p3;
	public GameObject ene;
	public GameObject ene2;
	public GameObject ene3;
	public GameObject ene4;
	public Text dinero;

	public float tiempo = 2f;
	public float time = 0;
	bool ran = false;

	Vector3 g;
	Vector3 h;
	public float ale = 1;
	public float ale2 = 1;
	// Start is called before the first frame update
	void Start()
    {
		PlayerPrefs.SetFloat("velocidad1", -3);
		  time = 0.1f;
		//comenzar();

		g = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
		//time += Time.deltaTime /1000;

		dinero.text = "$ "+PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
		
		
    }
	public void crear()
	{
		PlayerPrefs.SetFloat("velocidad1", PlayerPrefs.GetFloat("velocidad1", -1) - time);

		ale2 = Random.Range(0, 4);
		ale2 = ale2 - ale2 % 1;
		if (ale2 == 1)
		{
			transform.position = p2.transform.position;
		} else if (ale2 == 2)
        {
			transform.position = p3.transform.position;
		} else
        {
			transform.position = g;
		}

		h = new Vector3(transform.position.x, transform.position.y, g.z);
		ale = Random.Range(0, 5);
		ale = ale - ale % 1;
		if (ale == 1)
		{
			Instantiate(ene, h, Quaternion.identity);

		}
		else
		if (ale == 0)
		{
			Instantiate(ene2, h, Quaternion.identity);

		}
		else if (ale == 2)
		{
			Instantiate(ene3, h, Quaternion.identity);

		}
		if (ale > 2)
		{
			Instantiate(ene4, h, Quaternion.identity);

		}

	}

	public void comenzar()
	{
		
			InvokeRepeating("crear", 0f, tiempo);

	}

	public void cancelargen()
	{
		CancelInvoke("crear");
	}









}
