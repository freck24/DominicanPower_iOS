using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Rendering;

public class way : MonoBehaviour
{
    public controlartrucano truc;
    public siguientenivel siguientenivel;
    public acvtivador act;
    public SimpleCharacterControlFree simple;



   // public bool pd;  // pies derecho
   // public bool pi ;// pies izquierdo
  //  public bool cambiop ;// pies izquierdo
   // public GameObject pider;
  //  public GameObject pizq;

    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    public GameObject w5;
    public GameObject w6;
    public GameObject w7;
    public GameObject w8;
    public GameObject w9;
    public float vamoaver = 0f;   // public GameObject cualpies;
   // public GameObject cambiarc1;
  //  public GameObject cambiarc2;
   // public GameObject cambiarc3;
  public float contador = 1f;
    public bool su;
    public Transform truco;
    // Start is called before the first frame update
   
    void Start()
    {
        findeljuego.SetActive(false);
     // ycosita = cosita.transform.position;
       
        Time.timeScale = 1f;
        contador = 1f;
    }

    // Update is called once per frame
    void Update()
    {


       
        /*if (contador == 4 || contador == 5 || contador == 7 || contador == 8)
        {
           // cualpies.SetActive(true);
        }
        else
        {
           // cualpies.SetActive(false);
        }*/
    }
    public void prenderida()
    {
        w1.SetActive(true);
        w2.SetActive(true);
        w3.SetActive(true);
        w4.SetActive(true);
        w5.SetActive(true);
        w6.SetActive(true);
        w7.SetActive(true);
        w8.SetActive(true);
        w9.SetActive(true);
       
    }


    public void piz()
    {
      //  pi = true;
       // pider.SetActive(false);
      //  pizq.SetActive(true);
      //  cualpies.SetActive(false);
        
    } public void pied()
    {
       // pd = true;
      //  pizq.SetActive(false);
      //  pider.SetActive(true);
       // cualpies.SetActive(false);
    }
   //ublic Transform cosita; // la vaina esa ue elimina la colision
    public GameObject perdermensaje;
    //blic GameObject cosit;
    public GameObject findeljuego;
 //Vector3 ycosita;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "destroy" )
        {
            perdermensaje.SetActive(true);
         Time.timeScale = 0f;
           
        }


       if( other.tag == "piesderecho")
        {
            perdermensaje.SetActive(true);
        }

        if (other.tag == "findeljuego")
        {
            findeljuego.SetActive(true);
            Time.timeScale = 0;
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) +1000f);

        }

        if (other.tag == "ganar")
        {
            siguientenivel.adelante = true;
            siguientenivel.siguientepiedra = true;
            truc.s = true;
            prenderida();
            act.uno = true;
          //cosita.transform.position = new Vector3(cosita.position.x, ycosita.y, cosita.position.z);
         // cosit.SetActive(false);
          contador += 1f;

        }


      


/*
       if (truc.s)
        {
            if (other.tag == "siguiente" )
            {
                truc.objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                truco.transform.LookAt(new Vector3(truc.objetivo.position.x, truco.transform.position.y, truc.objetivo.position.z));
                vamoaver += 1;
                if (truc.satar == false)
                {
                    truc.adelante = false;
                    
                }
                truc.satar = false;
                //  prueba = false;
                }
            }*/
            


            /*else  if (pi)
            {
                if (other.tag == "piesizquierdo")
                {
                    truc.objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                    truco.transform.LookAt(new Vector3(truc.objetivo.position.x, truco.transform.position.y, truc.objetivo.position.z));
                    if (truc.satar == false)
                    {
                        truc.adelante = false;

                    }
                    truc.satar = false;
                }
            } else if (pd)
            {
                if (other.tag == "piesderecho")
                {
                    truc.objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                    truco.transform.LookAt(new Vector3(truc.objetivo.position.x, truco.transform.position.y, truc.objetivo.position.z));
                    if (truc.satar == false)
                    {
                        truc.adelante = false;

                    }
                    truc.satar = false;
                }

            }*/




       /*      if (truc.s== false)
        {

            if (other.tag == "siguientev")
            {
                truc.objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                truco.transform.LookAt(new Vector3(truc.objetivo.position.x, truco.transform.position.y, truc.objetivo.position.z));
                vamoaver += 1;
                if (!truc.satar)
                {
                    truc.adelante = false;
                
                }
                truc.satar = false;
            }}
            /*else if (pi)
            {
                if (other.tag == "piesizquierdo")
                {
                    truc.objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                    truco.transform.LookAt(new Vector3(truc.objetivo.position.x, truco.transform.position.y, truc.objetivo.position.z));
                    if (truc.satar == false)
                    {
                        truc.adelante = false;

                    }
                    truc.satar = false;
                }
            }
            else if (pd)
            {
                if (other.tag == "piesderecho")
                {
                    truc.objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
                    truco.transform.LookAt(new Vector3(truc.objetivo.position.x, truco.transform.position.y, truc.objetivo.position.z));
                    if (truc.satar == false)
                    {
                        truc.adelante = false;

                    }
                    truc.satar = false;
                }

            }*/








       //
    }

}
