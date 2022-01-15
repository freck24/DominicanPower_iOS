﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class codigogallina : MonoBehaviour
{

    
   public Animator anim;
    private Rigidbody2D r;
    public float velocidad = -5;
    public GESTORPRINCIPAL gestor;
  

   
    // Start is called before the first frame update
    void Start()
    {
       
 
        r = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        r.AddForce(Vector2.right*velocidad*Time.deltaTime);
    }
  
    public void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.tag == "enemy" || collision.tag == "destroy" )
        {
         
            Destroy(gameObject);
            PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) - 1);
           
        
        }

        if (collision.gameObject.tag == "suelo")
        {
            anim.SetBool("suelo", true);

        }

    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            anim.SetBool("suelo", false);

        }
    }
}
