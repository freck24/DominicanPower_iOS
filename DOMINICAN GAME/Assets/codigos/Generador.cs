﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Generador : MonoBehaviour {
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

	Vector3 g;
	Vector3 h;

	public float nivel;
	 public Material m;
    public Color c1;
    public Color c2;
    public Color c3;
    public Color c4;
    public Color c5;
    public Color c6;
    public Color c7;
    public Color c8;
    public Color c9;
    public int n;
    // Start is called before the first frame update
   
   
    
    void Awake()
    {
        n = Random.Range(0, 9);
		
        switch (n)
        {
            case 0:
                m.color = c1;
                break; 
            case 1:
                m.color = c2;
                break; 
            case 2:
                m.color = c3;
                break; 
            case 3:
                m.color = c4;
                break; 
            case 4:
                m.color = c5;
                break; 
            case 5:
                m.color = c6;
                break; 
            case 6:
                m.color = c7;
                break; 
            case 7:
                m.color = c8;
                break;
            case 8:
                m.color = c9;
                break; 

        }
        
    }
	void Start()
	{
		GENERAR();
		
		g = transform.position;

	
		
	}


	public void GENERAR()
    {
		cancelargen();
		nivel = PlayerPrefs.GetFloat("nivel", 1);
		if (nivel != 1 && nivel != 6 && nivel != 5 && nivel != 1 && nivel != 7 && nivel != 9 && nivel != 13 && nivel != 14 && nivel != 16 && nivel != 17 && nivel != 18 && nivel != 19 && nivel != 21 && nivel != 23 && nivel != 24 && nivel != 31 && nivel != 34 && nivel != 36 && nivel != 37 && nivel != 44 && nivel != 45 && nivel != 46 && nivel != 48 && nivel != 50 && nivel != 51 && nivel != 52 && nivel != 53 && nivel != 58 && nivel != 11)
			comenzar();


	}

	public float ale = 1;
	public void crear()
	{
		h = new Vector3(transform.position.x, g.y, g.z);


			ale = Random.Range(0, 15);  //9
		ale = ale - ale % 1;
		//ale = 1;
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
		else if (ale == 3)
		{
			Instantiate(ene4, h, Quaternion.identity);

		}
		else if (ale == 4)
		{
			Instantiate(ene5, h, Quaternion.identity);

		}
		else if (ale == 5)
		{
			Instantiate(ene6, h, Quaternion.identity);

		}else if (ale == 6)
		{
			Instantiate(ene7, h, Quaternion.identity);

		}else if (ale == 7)
		{
			Instantiate(ene9, h, Quaternion.identity);

		}else if (ale >7)
		{
			Instantiate(ene8, h, Quaternion.identity);

		}

	}
	public bool tuto = false;

	public void comenzar()
	{  if(tuto==false)
		InvokeRepeating("crear", 0f, tiempo);
		
	}

	public void cancelargen()
	{
		CancelInvoke("crear");
	}
	
	

}
