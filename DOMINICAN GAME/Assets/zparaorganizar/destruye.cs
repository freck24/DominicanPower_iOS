using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruye : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter2D(Collider2D otr)
	{
		if (otr.gameObject.tag == "destroy")
		{

			Destroy(gameObject);

		}
	}
	}
