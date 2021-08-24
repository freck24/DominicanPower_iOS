using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class jugadorep : MonoBehaviour
{
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public AudioClip gana;
    public AudioClip PAN;
    public AudioClip pierdeau;
    public AudioSource au;
    public float velocidad = 5;
    public bool stop = true;
    public Transform objetivo;
    public Transform meta;
    public GETOR gestor;
    public float numerodejugador;
    public Transform enemy;
    public bool rosa = true;
    public bool tengoelpa = false;
    public bool panu = false;
    public bool reinicio = false;
    public bool llegada = false;
    public ENEMY en;
    public GameObject reductor;

    Vector3 a;
    // Start is called before the first frame update
    void Start()
    {
        au = GetComponent<AudioSource>();
        a = transform.position;
        transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
    }

    // Update is called once per frame
    void Update()
    {


        if (en.tengopa)
        {
            reductor.SetActive(false);
        }
        if (stop == false)
        {


            if (panu == false)
            {

                transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
            }
            if (llegada == true && panu == false)
            {
                transform.LookAt(new Vector3(enemy.position.x, transform.position.y, enemy.position.z));
            }



            if (panu == true)
            {     transform.LookAt(new Vector3(-meta.position.x, transform.position.y, meta.position.z));
            }
           
        
        }

    } 






    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy" && sigu && rosa)
        {



         transform.LookAt(new Vector3(enemy.position.x, transform.position.y, enemy.position.z));

           
        }



        if (other.tag == "panu")
        {
            panu = true;
            au.clip = PAN;
            au.Play();


        }  
        if (other.tag == "enemy" && panu)
        {
            pierde();
            m1.SetActive(false);
            m1.SetActive(true); // taagarrao
        }
        
        if (other.tag == "lineaj" && panu)
        {
            GANA();
            m2.SetActive(false);
            m2.SetActive(true);
           panu = false;

        } if (other.tag == "derecha" && panu)
        {
            pierde();
            m3.SetActive(false);
            m3.SetActive(true); // tocaste linea
            panu = false;

        }


        if(other.tag== "llegada")
        {
            llegada = true;
        }


    }


        public void pierde()
    {
        stop = true;
        gestor.puntosB += 1F;
       gestor.PB.text = ""+ gestor.puntosB.ToString("f0");
        gestor.start = true;


        if (numerodejugador == gestor.numero)
        {
            au.clip = pierdeau;
            au.Play();
        }

       


    }
    public void GANA()
    {
        stop = true;
        gestor.puntosA += 1F;
       gestor.PA.text = ""+ gestor.puntosA.ToString("f0");
        gestor.start = true;


        if (numerodejugador == gestor.numero)
        {
            au.clip = gana;
            au.Play();
        }

    }


    public bool sigu = false;

     public void sigue()
    {

        if (numerodejugador == gestor.numero)

        {
            sigu = true;
          
        }
    }  
    public void atras()
    {

        if (numerodejugador == gestor.numero)

        {
          sigu = false;
       
        }
    }

    public bool avisador = true;
    public void mover()
    {
        //  reinicio = false;

        stop = false;
        reductor.SetActive(true);
        gestor.b1.SetActive(false);
        gestor.b2.SetActive(false);
        gestor.b3.SetActive(false);
        gestor.b4.SetActive(false);
        gestor.b5.SetActive(false);
       
        if (numerodejugador == gestor.numero)

        {
            gestor.b6.SetActive(false);
           

        }else
        {

            pierde();
            m4.SetActive(false);
            m4.SetActive(true);
            avisador = false;
            au.clip = pierdeau;
            au.Play();

        }



    }
}