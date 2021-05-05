using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization

	 Vector3 x=Vector3.up;
	public float velocity = 3f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += x * velocity * Time.deltaTime;
		
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			x = Vector3.left;		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			x = Vector3.right;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			x = Vector3.up;
			
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			x = Vector3.down;
		}
	}



	/*void OntriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "arriba")
		{
			x = Vector3.down;
			Destroy(gameObject);
	}

		if (other.gameObject.tag == "abajo")
		{
			x = Vector3.up;
		}
		if (other.gameObject.tag == "derecha")
		{
			x = Vector3.right;
		}
		if (other.gameObject.tag == "izquierda")
		{
			x = Vector3.left;
		}
	}*/
}
