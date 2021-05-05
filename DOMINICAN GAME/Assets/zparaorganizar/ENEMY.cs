using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ENEMY : MonoBehaviour
{
    Animator anim;
    public bool tengopa = false;
    public Transform player;
    public Transform objetivo;
    public Transform objetivo2;
    public float velocidad= 5;
    public float tiempodereaccion;
    public bool corre = false;
    public float numeroenemigo;
    public GETOR gestor;
    public bool llegada = true;
    public bool reinicio = false;
    public llegada nollega;
    public bool nohallegado = true;
    public AudioClip perder;
    public AudioClip noperder;
    private AudioSource au;
    
    public GameObject pe; // imagen perder
    public GameObject gan; // imagen perder
    Vector3 a;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        au = GetComponent<AudioSource>();

        a = transform.position;
        transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
    }

    // Update is called once per frame
    void Update()
    {

        if(gestor.baile == true)
        {
            anim.SetBool("baile", true);
        }

        /*reinicio = gestor.reinicio;

           if (reinicio)
           {
               transform.position = a;

           }*/
       // transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));

        if (corre && numeroenemigo == gestor.numero)
        {

            if (nohallegado==true && tengopa == false)
            {
                transform.Translate(new Vector3(0, 0, velocidad * Time.deltaTime));
                transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
            }
             if (nohallegado == false && tengopa == false)
            {
                transform.Translate(new Vector3(0, 0, velocidad * Time.deltaTime));
                transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
            }


            if (nohallegado == false && tengopa== true)
            {
                transform.Translate(new Vector3(0, 0, velocidad * Time.deltaTime));
                transform.LookAt(new Vector3(objetivo2.position.x, transform.position.y, objetivo2.position.z));
            }
            
           
          
          
        }
    }


    public void OnTriggerEnter(Collider other)
    {if(other.tag == "zona")
        {
            anim.SetBool("zona", true);
        }



        if (other.tag == "Player")
        {
          corre = false;


        }  
        
        if (other.tag == "Finish")
        {
      corre = false;
        }



        if (other.tag == "panuelito" )
        {
            

            
            transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
        }
      
        
        
        if (other.tag == "llegada" )
        {

            nohallegado = false;
          

        }  
        if (other.tag == "panu" )
        {

            tengopa = true;
            velocidad += 3;

        }
        if (other.tag == "linea" && tengopa)
        {    corre = false;
            reinicio = true;
            tengopa = false;
            nohallegado = true;
            gestor.puntosB += 1F;
            gestor.PB.text = "" + gestor.puntosB.ToString("f0");

            if (gestor.numero == numeroenemigo)
            {
                au.clip = perder;
                au.Play();
                pe.SetActive(false);
                pe.SetActive(true);
            }
            StartCoroutine(iniciarpa());
      
       

        }
          



          if (other.tag == "Player" && tengopa )
        {
            corre = false;
            nohallegado = true;
            reinicio = true;

            gestor.puntosA += 1F;
            gestor.PA.text = "" + gestor.puntosA.ToString("f0");
           tengopa = false;
            if (gestor.numero == numeroenemigo)
            {
                au.clip = noperder;
                au.Play();
                gan.SetActive(false);
                gan.SetActive(true);
            }
            StartCoroutine(iniciarpa());
          
        }
        




}


    public void OnTriggerExit(Collider other)
    {
        if(other.tag== "zona")
        {
            anim.SetBool("zona", false);
            //  transform.Rotate(0, 180, 0);

         //   transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
        }
    }
    public IEnumerator iniciarpa()
    {
        yield return new WaitForSeconds(0);
        gestor.start = true;
    }
}