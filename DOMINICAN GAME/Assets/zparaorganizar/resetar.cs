using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetar : MonoBehaviour
{

	

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		
	}




	void OnTriggerEnter2D(Collider2D otr)
	{
		if (otr.gameObject.tag == "suelo")
		{
			transform.position = new Vector3(transform.position.x,1,transform.position.z);
			gameObject.SetActive(false);

		}
	}

}
