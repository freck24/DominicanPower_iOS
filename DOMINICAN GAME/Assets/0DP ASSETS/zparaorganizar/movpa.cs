
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movpa : MonoBehaviour
{
    Animator anim;
    public Transform perso;
    public bool contro = false;
    
    public jugadorep jugador;
    Rigidbody rb;
    public float velocidad;
    public float numerodejugador;
    public GETOR gestor;

    public float vel;
    public float h1 = 0;
    public float h2= 0;

    public bool run = false;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 10;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
             
        if (gestor.numero == numerodejugador && jugador.stop == false)
        {
           
           

            if (h1 == 1)
            {
                h2 = 0;
                vel = h1 * velocidad;
            }

            if (h2 == -1)
            {
                h1 = 0;
                vel = h2 * velocidad;
            }

            // float movv = CrossPlatformInputManager.GetAxis("Vertical") * velocidad;
            //  rb.AddForce(movh, 0, 0);


            transform.Translate(new Vector3(0, 0, vel* Time.deltaTime));
          


        }

        if (vel > 0.2 || vel < -0.2)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }

        if (vel > 0 && contro)
        {
            perso.transform.Rotate(0, 180, 0);
            contro = false;
        }
        if (vel < 0 && contro==false)
        {
            perso.transform.Rotate(0, 180, 0);
            contro = true;
        }



    }
    public void adelante()
    {
        h1 = 1;
    }
    public void adelantesuelta()
    {
        h1 = 0;
        vel = 0;
    }   public void noadelante()
    {
        h2 = -1;
    }
    public void noadelantesuelta()
    {
        h2 = 0;
        vel = 0;
    }


    public void CERO()
    {
        h1 = 0;
        h2 = 0;
        vel = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag== "velocidad")
        {
            velocidad = 5;
        } if(other.tag== "llegada")
        {
            velocidad = 5;
        }



    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "velocidad")
        {
            velocidad = 14;
        }
    }


}
