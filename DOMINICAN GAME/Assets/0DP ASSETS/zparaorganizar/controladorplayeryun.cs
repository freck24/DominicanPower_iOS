using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class controladorplayeryun : MonoBehaviour
{
    public bool UNA = true;


// Vector3 target;
    public float velocidad = 10f;
    public float gz;
    public Seguidor seguidor;
    public Seguidor2a seguidor2;
    public bool j1 =true;
    public controladorplayer2 cont2;
    public GameObject mitad1;
    public GameObject ganar;
    public Text pmax;
    public Text moni;
    public Text premio;
    public Text moni2;
    public TIMER timer;
    public AudioClip gano;
    public AudioClip fail;
    private AudioSource a;
    public GameObject botoncabrar;
    public GameObject nobotoncabrar;  
    
    public void continuarr()
    {
        PreLoaderLevel.preload.CargaLvl("LEVEL 1 CLONE"); 
    }
    public void menuss()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }

    // Start is called before the first frame update
    void Start()
    {
       



        premio.text = "NO HA SIDO TAN RAPIDO COMO PARA GANAR PREMIOS";
        a = GetComponent<AudioSource>();
       // target = transform.position;
    //    gz = transform.position.y;
     //   Time.timeScale = 1f;    
    }

    public void cambiardejugador()
    {
        j1 = !j1;
        cont2.j2 = !cont2.j2;
    }

    public GameObject z1;
    public GameObject z2;
    void OnTriggerEnter(Collider otr)
    {
        if (otr.gameObject.tag == "area1")
        {
            seguidor.estoyena1 = true;
            seguidor.sigue1 = true;
            seguidor.sigue2 = false;


        }   if (otr.gameObject.tag == "area2")
        {
            seguidor2.estoyena2 = true;
            seguidor2.sigue1 = true;
            seguidor2.sigue2 = false;

        }
        if (otr.gameObject.tag == "mitad1")

        {
            mitad1.SetActive(true);
            z1.SetActive(false);
            z2.SetActive(true);
        }
         if (otr.gameObject.tag == "ganar"  && UNA)

        {
            ganar.SetActive(true);
            perder.ft = 5f;
            z2.SetActive(false);
            
          



                if (PlayerPrefs.GetFloat("tiempoyun", 100f) > timer.tiem)
            {
                PlayerPrefs.SetFloat("tiempoyun", timer.tiem);
                pmax.text = "NUEVO RECORD:" + PlayerPrefs.GetFloat("tiempoyun", 100f).ToString("f2") + " segundos";
            }
            else
            {
                pmax.text = "RECORD:" + PlayerPrefs.GetFloat("tiempoyun", 100f).ToString("f2") + " segundos";
            }




            if (timer.tiem < 20f && timer.tiem > 15)
            {
                premio.text = "Ha ganado $500";
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) + 500f);
                a.clip = gano;
                a.Play();

            }
            if (timer.tiem < 15f && timer.tiem > 10)
            {
                premio.text = "Ha ganado $750";
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) + 750f);
                a.clip = gano;
                a.Play();

            }
            if (timer.tiem < 10f)
            {
                premio.text = "Ha ganado $1000";
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) + 1000f);
                a.clip = gano;
                a.Play();

            }

            //Time.timeScale = 0f;
            timer.corriendo = false;
            
            UNA = false;
        }


    }

    public void menu()
    {

        PreLoaderLevel.preload.CargaLvl("inicio");


        PlayerPrefs.SetFloat("pyun", 1);
      //  PlayerPrefs.SetFloat("tiempoyun", 100f);
    }


    public perderyyun perder;
    public void jugarotravez()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > perder.ft - 1f)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - perder.ft);
            SceneManager.LoadScene("yun");

            a.clip = gano;
            a.Play();
        }

        else
        {
            a.clip = fail;
            a.Play();
        }


      



    }
    public void jugarotravezgratis()
    {

        SceneManager.LoadScene("yun");
    }


    void OnTriggerExit(Collider otr)
    {
        if (otr.gameObject.tag == "area1")
        {
            seguidor.estoyena1 = false;
        } if (otr.gameObject.tag == "area2")
        {
           seguidor2.estoyena2 = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("pyun", 0) == 0)
        {
            botoncabrar.SetActive(false);
            nobotoncabrar.SetActive(true);

        }


        moni.text= "$" + PlayerPrefs.GetFloat("dinero", 0f).ToString("f0");
        moni2.text= "$" + PlayerPrefs.GetFloat("dinero", 0f).ToString("f0");

        /* if (Input.GetMouseButtonDown(0) && j1)
         {
             target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             target.y = gz;
         }

         if (j1 && target.x > -11)
         {
             transform.position = Vector3.MoveTowards(transform.position, target, velocidad * Time.deltaTime);
         }

         Debug.DrawLine(transform.position, target, Color.blue);*/
    }



}
