using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colmado : MonoBehaviour
{
    public static colmado _colmado;
    


    public int calidad;
    public void calidadgrafica()
    {
        calidad = PlayerPrefs.GetInt("Q", 5);
        QualitySettings.SetQualityLevel(calidad, true);
        switch (calidad)
        {
            case 0:

                Screen.SetResolution(480, 270, true);
                break;
            case 1:
                Screen.SetResolution(640, 360, true);
                break;
            case 2:
                Screen.SetResolution(960, 540, true);
                break;
            case 3:
                Screen.SetResolution(960, 540, true);
                break;
            case 4:
                Screen.SetResolution(1280, 720, true);
                break;
            case 5:
                Screen.SetResolution(1280, 720, true);
                break;
        }
    }

    public AudioClip regist;
    public AudioClip tunotienes;
    public AudioClip pop;
    public AudioSource j;
  //  public Text text = null;

 

    public GameObject b;
    public GameObject b2;

    public Animator ANIM;


    public float dinero;
    public GameObject vende;
    public GameObject comprae;
    public GameObject mens4;
    public GameObject x;
    public Text dr = null;

    public GameObject m1;
    public GameObject m2;


    float tp = 10000000;
    float tpp = 10000000;
    public Text preciotiempo;
    public Text ptiempo;


    void Start()
    {
        _colmado = this;

        calidadgrafica();
     //   PlayerPrefs.SetFloat("tiempopoder", 0);
        tp = PlayerPrefs.GetFloat("tiempopoder", 0);
        tpp = Mathf.Pow(10, tp+2)/2;
        preciotiempo.text = "$" + tpp.ToString();

        float r = 10 + tp*2;
        ptiempo.text = "" + r + "s";

       
        vende.SetActive(false);
        mens4.SetActive(false);
        comprae.SetActive(false);
        j = GetComponent<AudioSource>();
        dinero = PlayerPrefs.GetFloat("dinero", 0f);
         
        dr.text = "RD$" + dinero;


        if (PlayerPrefs.GetFloat("nivel", 0) < 3)
        {
          //  text.text = "NECESITAS NIVEL 3 PARA COMPRAR";
        }
        else
        {
          //  text.text = "COMPRAR";
        }

     }

    public GameObject[] comprado;


    public void compraplatano()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > 499){
            PlayerPrefs.SetFloat("poder", PlayerPrefs.GetFloat("poder", 0) + 1);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 500);
            j.PlayOneShot(regist);
            comprado[0].SetActive(false);
            comprado[0].SetActive(true);
        }
        else
        {
            j.PlayOneShot(tunotienes);
        }
    }


    public void comprartiempo()
    {
        if (PlayerPrefs.GetFloat("dinero", 0f) > tpp - 1)
        {
            j.PlayOneShot(regist);
            PlayerPrefs.SetFloat("tiempopoder", tp + 1);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - tpp);

            tp = PlayerPrefs.GetFloat("tiempopoder", 0);
            tpp = Mathf.Pow(10, tp + 2)/2;
            preciotiempo.text = "$"+tpp.ToString();
            float r = 10 + tp*2;
            ptiempo.text = "TIEMPO POWER: " + r+" s";
        }
        else
        {
            j.PlayOneShot(tunotienes);
        }
    }




    void Update()
    {
        dinero = PlayerPrefs.GetFloat("dinero", 0f);
        dr.text = "RD$" + dinero;
    }
  




    public GameObject cambiarscena;

    public void menu() => PreLoaderLevel.preload.CargaLvl("inicio");

    public void comprarg()
    {
        if(PlayerPrefs.GetFloat("dinero", 0f) > 4999f && PlayerPrefs.GetFloat("gorras",0)==0)
        {
            
            PlayerPrefs.SetFloat("gorras", 1f);
            dinero -= 5000;
            PlayerPrefs.SetFloat("dinero", dinero);
            j.PlayOneShot(regist);
            dr.text = "RD$" + dinero;
            comprado[1].SetActive(false);
            comprado[1].SetActive(true);

        } else
        {
            j.PlayOneShot(tunotienes);
        }
    }
    
    public void comprargat()
    {
        if (PlayerPrefs.GetFloat("dinero", 0f) > 19999f && PlayerPrefs.GetFloat("gatos", 0) == 0)


        {

            PlayerPrefs.SetFloat("gatos", 1f);
            j.PlayOneShot(regist);
            dinero -= 20000;
            PlayerPrefs.SetFloat("dinero", dinero);
            dr.text = "RD$" + dinero;
        }
        else
        {
            j.PlayOneShot(tunotienes);
        }

    }
    public void comprargaf()
    {
        
        if (PlayerPrefs.GetFloat("dinero", 0f) > 7999f && PlayerPrefs.GetFloat("gafas", 0) == 0)
        {
            
            PlayerPrefs.SetFloat("gafas", 1);
            j.PlayOneShot(regist);
            dinero -= 8000;
            PlayerPrefs.SetFloat("dinero", dinero);
            dr.text = "RD$" + dinero;
            comprado[2].SetActive(false);
            comprado[2].SetActive(true);

        }
        else
        {
            j.PlayOneShot(tunotienes);
        }
    }



    #region Menus Managear

    public void comp()
    {
        if (PlayerPrefs.GetFloat("nivel", 1) > 0)
        {
            j.clip = pop;
            comprae.SetActive(true);
        }
        else
        {
            j.PlayOneShot(tunotienes);
        }
    }
    public void fcomp()
    {
        j.PlayOneShot(pop);
        comprae.SetActive(false);
    }

    public void banca()
    {
        ANIM.SetBool("banca", true);
        b.SetActive(true);
        b2.SetActive(false);
    }

    public void bancac()
    {
        ANIM.SetBool("banca", false);
        b.SetActive(false);
        b2.SetActive(true);
        m1.SetActive(false);
        m2.SetActive(false);
    }

    public void vender()
    {
        j.PlayOneShot(pop);
        vende.SetActive(true);
    } 
    
    public void finalizaventa()
    {
        j.PlayOneShot(pop);
        vende.SetActive(false);
        mens4.SetActive(false);
    }
    
    public void tunotiene() => mens4.SetActive(true);
    
    public void cvendermango()
    {
        j.PlayOneShot(pop);
        mens4.SetActive(false);
    }

    #endregion

}
