using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GETOR : MonoBehaviour
{
    public GameObject CARGAR;
   
    public void NIVELREPETIR()
    {
        CARGAR.SetActive(true);
     //   StartCoroutine(CARGANDO());
    }
   // public GameObject josty;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;

   // public GameObject b7;
    public Transform j1;
    public Transform j2;
    public Transform j3;
    public Transform j4;
    public Transform j5;
    public Transform e1;
    public Transform e2;
    public Transform e3;
    public Transform e4;
    public Transform e5;
    public Transform objetivo;
    Vector3 a1;
    Vector3 a2;
    Vector3 a3;
    Vector3 a4;
    Vector3 a5;
    Vector3 a6;
    Vector3 a7;
    Vector3 a8;
    Vector3 a9;
    Vector3 a;
    public AudioClip uno;
    public AudioClip dos;
    public AudioClip tres;
    public AudioClip cuatro;
    public AudioClip cinco;
    private AudioSource au;
    public GameObject panu;
    public GameObject panureal;

    public float puntosA;
    public float puntosB;
    public Text PA;
    public Text PB;
    public float numero;
    public float tiempo;
    public Text textonumero;
    public bool cerca = false;
    public bool tengopa;
    public bool panuj = false;

    public ENEMY ene1;
    public ENEMY ene2;
    public ENEMY ene3;
    public ENEMY ene4;
    public ENEMY ene5;

    public jugadorep cj1;
    public jugadorep cj2;
    public jugadorep cj3;
    public jugadorep cj4;
    public jugadorep cj5;

    public movpa Movpa1;
    public movpa Movpa2;
    public movpa Movpa3;
    public movpa Movpa4;
    public movpa Movpa5;
    public controlaanim controladopan;

    public GameObject repe;
    public GameObject repegratis;


    // Start is called before the first frame update
    void Start()
    {


       

        au = GetComponent<AudioSource>();
        b1.SetActive(false);
        b2.SetActive(false);
        b3.SetActive(false);
        b4.SetActive(false);
        b5.SetActive(false);

        start = true;
        a1 = j1.transform.position;
        a2= j2.transform.position;
        a3 = j3.transform.position;
        a4 = j4.transform.position;
        a5 = j5.transform.position;
        a6 = e1.transform.position;
        a7 = e2.transform.position;
        a8 = e3.transform.position;
        a9 = e4.transform.position;
        a = e5.transform.position;


 
      

        b6.SetActive(true);
       // b7.SetActive(false);
    }
    public bool start = false;
    public bool corre = false;
    public float t2;
    public bool seguir;
    public bool adelantej;



    // Update is called once per frame
    void Update()
    {


        if(cj1.avisador == false || cj2.avisador == false || cj3.avisador == false || cj4.avisador == false || cj5.avisador == false)
        {
            comprueba = true;
        }
        else
        {
            comprueba = false;
          
        }
        

        if (start)
        {
            invocarnumero();
            start = false;
        }
    }

    public void reinicirp()
    {
        controladopan.starpanu = false;

        Movpa1.CERO();
        Movpa2.CERO();
        Movpa3.CERO();
        Movpa4.CERO();
        Movpa5.CERO();
       








         j1.transform.position = a1;
     j2.transform.position = a2;
        j3.transform.position = a3;
         j4.transform.position = a4;
        j5.transform.position= a5;
        e1.transform.position=a6;
       

        e2.transform.position=a7;
        e3.transform.position=a8;
        e4.transform.position=a9;
      e5.transform.position=a;

        e1.transform.LookAt(new Vector3(objetivo.transform.position.x, e1.transform.position.y, objetivo.transform.position.z));
        e2.transform.LookAt(new Vector3(objetivo.transform.position.x, e2.transform.position.y, objetivo.transform.position.z));
        e3.transform.LookAt(new Vector3(objetivo.transform.position.x, e3.transform.position.y, objetivo.transform.position.z));
        e4.transform.LookAt(new Vector3(objetivo.transform.position.x, e4.transform.position.y, objetivo.transform.position.z));
        e5.transform.LookAt(new Vector3(objetivo.transform.position.x, e5.transform.position.y, objetivo.transform.position.z));    
        j1.transform.LookAt(new Vector3(objetivo.transform.position.x, j1.transform.position.y, objetivo.transform.position.z));
        j2.transform.LookAt(new Vector3(objetivo.transform.position.x, j2.transform.position.y, objetivo.transform.position.z));
        j3.transform.LookAt(new Vector3(objetivo.transform.position.x, j3.transform.position.y, objetivo.transform.position.z));
        j4.transform.LookAt(new Vector3(objetivo.transform.position.x, j4.transform.position.y, objetivo.transform.position.z));
        j5.transform.LookAt(new Vector3(objetivo.transform.position.x, j5.transform.position.y, objetivo.transform.position.z));
        



        b1.SetActive(false);
        b2.SetActive(false);
        b3.SetActive(false);
        b4.SetActive(false);
        b5.SetActive(false);

        ene1.nohallegado = true;
        ene2.nohallegado = true;
        ene3.nohallegado = true;
        ene4.nohallegado = true;
        ene5.nohallegado = true;
        
        ene1.tengopa = false;
        ene2.tengopa = false;
        ene3.tengopa = false;
        ene4.tengopa = false;
        ene5.tengopa = false;



        ene1.corre = false;
        ene2.corre = false;
        ene3.corre = false;
        ene4.corre = false;
        ene5.corre = false;
        b6.SetActive(true);


        cj1.stop = true;
        cj2.stop = true;
        cj3.stop = true;
        cj4.stop = true;
        cj5.stop = true;

        cj1.llegada = false;
        cj2.llegada = false;
        cj3.llegada = false;
        cj4.llegada = false;
        cj5.llegada = false; 
        
        cj1.panu = false;
        cj2.panu = false;
        cj3.panu = false;
        cj4.panu = false;
        cj5.panu = false;

        textonumero.text = "";
        //  b7.SetActive(false);
    }



    public GameObject ga;
    public GameObject gb;
    public bool baile = false;


    public bool reinicio = false;


    public void numeros()
    {
        if (numero == 1)
        {
            au.clip = uno;
        }
        if (numero == 2)
        {
            au.clip = dos;
        }
        if (numero == 3)
        {
            au.clip = tres;
        }
        if (numero == 4)
        {
            au.clip = cuatro;
        }
        if (numero == 5)
        {
            au.clip = cinco;
        }

        au.Play();
    }

    public void invocarnumero()
    {
        if (puntosA == 10)
        {
            reinicirp();
            ga.SetActive(true);
            au.clip = win;
            au.Play();


            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 1000);
        }
        else if (puntosB == 10)
        {
            reinicirp();
            gb.SetActive(true);
            baile = true;
            au.clip = win;
            au.Play();
            repegratis.SetActive(false);
            repe.SetActive(true);

        }
        else
        {

            reinicirp();


            tiempo = Random.Range(3.1F, 4);
            t2 = Random.Range(1, 3);
            
            StartCoroutine(numerale());
        }
    }

    public GameObject pa;
    public bool adelante = false;
    public float velocidadenemy = 7;
    public AudioClip win;
    public IEnumerator numerale()
    {
 

        yield return new WaitForSeconds(tiempo);
        panu.SetActive(true);
        panureal.SetActive(true);
        pa.SetActive(true);
        adelante = true;
        numero = Random.Range(1, 6);
       velocidadenemy = Random.Range(3, 4) + t2;
        controladopan.starpanu = true;
        numeros();

        ene1.velocidad = velocidadenemy;
        ene2.velocidad = velocidadenemy;
        ene3.velocidad = velocidadenemy;
        ene4.velocidad = velocidadenemy;
        ene5.velocidad = velocidadenemy;




        numero = numero - numero % 1;
        textonumero.text = numero.ToString("f0");

        b1.SetActive(true);
        b2.SetActive(true);
        b3.SetActive(true);
        b4.SetActive(true);
        b5.SetActive(true);

        cj1.avisador = true;
        cj2.avisador = true;
        cj3.avisador = true;
        cj4.avisador = true;
        cj5.avisador = true;

        yield return new WaitForSeconds(t2);


            ene1.corre = true;
            ene2.corre = true;
            ene3.corre = true;
            ene4.corre = true;
            ene5.corre = true;

        if (comprueba==true)
        {
            ene1.corre = false;
            ene2.corre = false;
            ene3.corre = false;
            ene4.corre = false;
            ene5.corre = false;
        
        }
        
    }
    public bool comprueba = false;
    public void MENU()
    {

        SceneManager.LoadScene("inicio");
        PlayerPrefs.SetFloat("ppa", 1);
    }
    public void PANU()
    {   if (PlayerPrefs.GetFloat("dinero", 0) > 74 && PlayerPrefs.GetFloat("ppa", 0) == 1)
        {

            SceneManager.LoadScene("pa");

            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 75);



        }  
        if (PlayerPrefs.GetFloat("ppa", 0) == 0)
        {

            SceneManager.LoadScene("pa");
        }

     



    }
  
}
