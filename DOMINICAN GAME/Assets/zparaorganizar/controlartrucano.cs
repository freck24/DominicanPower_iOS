using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class controlartrucano : MonoBehaviour
{
    public float velocidad;
    public Transform objetivo;
    public Transform way;
    public bool adelante = false;
    public float siguiente = 0f;
    public bool satar = false;
    public bool prueba = true;
    public bool esperando = true;
    public bool s = true;
    public SimpleCharacterControlFree simple;
    public GameObject ba;
    public GameObject bs;
    public GameObject iz;
    public GameObject de;

    public Transform p1;
    public Transform p2;
    public Transform p3;
    public Transform p4;
    public Transform p5;
    public Transform p6;
    public Transform p7;
    public Transform p8;
    public Transform p9;
    public Transform p10;
    public Transform p11;
    public Transform p12;
    public Transform p13;
    public Transform p14;
    public Transform p15;
    public Transform p16;
    public AudioClip jump;
    
    private AudioSource asd;
    public bool dificil = true;
    Animator anin;
    // Start is called before the first frame update
    void Start()
    {
        asd=GetComponent<AudioSource>();

        transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
        Time.timeScale = 1f;

       
    }

    // Update is called once per frame
    public Vector3 a;
    Vector3 b;
    public bool espera = true;
    void Update()
    {
        
        if(espera)
        {

            ba.SetActive(true);
            bs.SetActive(true);
            iz.SetActive(true);
            de.SetActive(true);
        }
        else 
        {
            ba.SetActive(false);
            bs.SetActive(false);
            iz.SetActive(false);
            de.SetActive(false);
            
            
        }

        a = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        b = new Vector3(transform.position.x, (transform.position.y +10f), transform.position.z);
        if (simple.suel)
        {
            way.transform.position = Vector3.MoveTowards(way.transform.position, a, 30*Time.deltaTime);
           
        }
        else
        {
           
            way.transform.position = Vector3.MoveTowards(way.transform.position, b, 200);
        }

      if (adelante)
        {
            transform.Translate(new Vector3(0, 0, velocidad * Time.deltaTime));
        }

    }
    private IEnumerator boton()
    {
        yield return new WaitForSeconds(.7f); 
        espera = true;
       
    }



    public GameObject perder;
    public void OnTriggerExit(Collider other)
    {
        if(other.tag== "zonadejuego")
        {
          
            perder.SetActive(true);
            Time.timeScale = 0f;
        }
   
    
    }


    public void OnTriggerEnter(Collider other)
    {
        if (s)
        {
            if (other.tag == "siguiente" && esperando)
            {
               

                objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
                //vamoaver += 1;
                if (satar == false)
                {
                    adelante = false;

                }
                satar = false;
                //  prueba = false;
            }
        }


        if (s == false)
        {

            if (other.tag == "siguientev"&& esperando)
            {
               

                objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
                //amoaver += 1;
                if (satar==false)
                {
                    adelante = false;

                }
                satar = false;
            }


        }
        }



    public IEnumerator ESPERAMAS()
    {
        yield return new WaitForSeconds(0.1f);
        esperando = true;
    }

    public void gestorpasos()
        {



            //  transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+3f);
            /*siguiente += 1f;
satar = false;
anin.SetBool("salter", satar);

anin.SetFloat("siguiente", siguiente);*/

        }

    Vector3 r;
      public void GIR()
    {
        transform.Rotate(transform.rotation.x, 20f, transform.rotation.z);

      
       
    } public void GIR2()
    {
        transform.Rotate(transform.rotation.x, -20f, transform.rotation.z);
    }


    public void cambiar()
    {
       
        if (way.transform.position.y == a.y)
        {
            asd.clip = jump;
            asd.Play();

            adelante = true;
            satar = false;
            espera = false;
            StartCoroutine(boton());
            esperando = false;
            StartCoroutine(ESPERAMAS());
            if (dificil)
            {
                aleab();
            }
        }
    }





    public void saltar()
    {
        if (way.transform.position.y == a.y)
        {
            asd.clip = jump;
            asd.Play();

            espera = false;
            satar = true;
            adelante = true;
            StartCoroutine(boton());
            esperando = false;
            StartCoroutine(ESPERAMAS());
            if (dificil)
            {
                aleab();
            }
        }
    }



    public Transform boton1;
    public Transform boton2;
    public Transform boton3;
    public Transform boton4;



    public float b1 = 1;
    public float b2 = 1;
    public float b3 = 1;
    public float b4 = 1;
    public void aleab()
    {
        b1 = Random.Range(0, 6);
        b2 = Random.Range(0, 6);
        b3= Random.Range(0, 6);
        b4 = Random.Range(0, 6);
        b1 = b1 - b1 % 1;
        b2 = b2 - b2 % 1;
        b3 = b3 - b3 % 1;
        b4 = b4 - b4 % 1;
       
        if (b1 == 0)
        {
            boton1.transform.position = boton1.transform.position;
        }  if (b1 == 1)
        {
            boton1.transform.position = p2.transform.position;
        } if (b1 == 2)
        {
            boton1.transform.position = p3.transform.position;
        } if (b1 == 3)
        {
            boton1.transform.position = p4.transform.position;
        }if (b1 > 4)
        {
            boton1.transform.position = p5.transform.position;
        }





        if (b2 == 0)
        {
            boton2.transform.position = boton2.transform.position;
        }  if (b2 == 1)
        {
            boton2.transform.position = p7.transform.position;
        } if (b2 == 2)
        {
            boton2.transform.position = p8.transform.position;
        } if (b2 == 3)
        {
            boton2.transform.position = p9.transform.position;
        }if (b2 > 3)
        {
            boton2.transform.position = p10.transform.position;
        }
        
        
        

        
        if (b3 == 0)
        {
            boton3.transform.position = boton3.transform.position;
        }  if (b3 == 1)
        {
            boton3.transform.position = p6.transform.position;
        } if (b3 == 2)
        {
            boton3.transform.position = p1.transform.position;
        } if (b3 == 3)
        {
            boton3.transform.position = p12.transform.position;
        }if (b3 > 3)
        {
            boton3.transform.position = p11.transform.position;
        }




         if (b4 == 0)
        {
            boton4.transform.position = boton4.transform.position;
        }  if (b4 == 1)
        {
            boton4.transform.position = p16.transform.position;
        } if (b4 == 2)
        {
            boton4.transform.position = p15.transform.position;
        } if (b4 == 3)
        {
            boton4.transform.position = p14.transform.position;
        }if (b4 > 3)
        {
            boton4.transform.position = p13.transform.position;
        }





    }


} 

