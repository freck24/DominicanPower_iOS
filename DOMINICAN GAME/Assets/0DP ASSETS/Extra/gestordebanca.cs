using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class gestordebanca : MonoBehaviour
{
    // Start is called before the first frame update

    public jugarnumero[] j;
    public Text numerosjugados;
    public GameObject jugar;
    public GameObject revisartiket;
    public GameObject COBRAR;

    public int primern;
    public int segundon;
    public int tercern;
    DateTime tiempoactual;
    TimeSpan diferencia;

    public TextMeshPro n1;
    public TextMeshPro n2;
    public TextMeshPro n3;

    public Text timpo;
    void Start()
    {
       // PlayerPrefs.SetFloat("dinero",10000);
        tiempoactual = DateTime.Now;
 
        diferencia = tiempoactual - Convert.ToDateTime( PlayerPrefs.GetString("fecha", tiempoactual.ToString()));
      //  timpo.text = "Tiempo para proximo sorteo: " + diferencia.Hours.ToString() + " horas " + diferencia.Minutes.ToString() + " minutos" + diferencia.Days.ToString();
        if (diferencia.Days > 0)
        {
            LOTERIA();
        }
        n1.text = PlayerPrefs.GetInt("nnn1", 24).ToString();
        n2.text = PlayerPrefs.GetInt("nnn2", 20).ToString();
        n3.text = PlayerPrefs.GetInt("nnn3", 28).ToString();
        for (int i = 0; i<j.Length; i++)
        {
            j[i].numero = i;
            j[i].ponmenumero();
        }


    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void LOTERIA()
    {
        primern = UnityEngine.Random.Range(0, 100);
        segundon = UnityEngine.Random.Range(0, 100);
        tercern = UnityEngine.Random.Range(0, 100);
        PlayerPrefs.SetInt("nnn1", primern);
        PlayerPrefs.SetInt("nnn2", segundon);
        PlayerPrefs.SetInt("nnn3", tercern);
       

    }
    bool puedeabrir = true;

    public void numerojugados()
    {
        numerosjugados.text = "";
        for (int i = 0; i < j.Length; i++)
        {
            if (PlayerPrefs.GetInt("n" + i,0) > 0)
            {
                numerosjugados.text += " $"+PlayerPrefs.GetInt("n" + i,0).ToString()+ " al "+i;
                puedeabrir = false;
            }
        
        }
        } 
    
    
    
    public void borrar()
    {
        numerosjugados.text = "";
        for (int i = 0; i < j.Length; i++)
        {

            PlayerPrefs.SetInt("n" + i, 0);
               
           
        
        }
        }

    public Text textcobrar;
    public Text textcobrart;

    public int total;

    public void numerojugadosCOBRAR()
    {
        textcobrar.text = "";
        if (PlayerPrefs.GetInt("n" + PlayerPrefs.GetInt("nnn1", 0)) > 0)
        {
           
            textcobrar.text += "Te sacaste en primera\n";
            total = 80 * PlayerPrefs.GetInt("n" + PlayerPrefs.GetInt("nnn1", 0));
        }

        if (PlayerPrefs.GetInt("n" + PlayerPrefs.GetInt("nnn1", 0)) > 0)
        {
            textcobrar.text += "Te sacaste en segunda\n";

            total = total + 15 * PlayerPrefs.GetInt("n" + PlayerPrefs.GetInt("nnn1", 0));
        }
        if (PlayerPrefs.GetInt("n" + PlayerPrefs.GetInt("nnn1", 0)) > 0)
        {
            textcobrar.text += "Te sacaste en tercera";
            total = total + 5 * PlayerPrefs.GetInt("n" + PlayerPrefs.GetInt("nnn1", 0));

        }
        textcobrart.text = "Total a cobrado: " + total;

        if (total == 0)
        {
            textcobrar.text = "No te has sacado. SALAO";
        }
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + total);

    }


    public AudioSource a;
    public AudioClip faile;
    

    public GameObject mensaje;
    public void abrirj()
    {
        puedeabrir = true;
        numerojugados();
        if (puedeabrir)
        {
            jugar.SetActive(true);
        }
        else
        {
            mensaje.SetActive(false);
            mensaje.SetActive(true);
        }
    }   public void cerrarj()
    {
        jugar.SetActive(false);
    }  public void abrirT()
    {
        revisartiket.SetActive(true);
        numerojugados();
    }   public void cerrarT()
    {
        revisartiket.SetActive(false);
    }
    public GameObject men;
    public void abrirC()
    {
        diferencia = tiempoactual - Convert.ToDateTime(PlayerPrefs.GetString("fecha", tiempoactual.ToString()));
        print(diferencia.Days);
        if (diferencia.Days > 0 && PlayerPrefs.GetInt("hoycobre",1)==0)
        {
            COBRAR.SetActive(true);
            numerojugadosCOBRAR();
            borrar();

            PlayerPrefs.SetInt("hoycobre", 1);
        }
        else{
            a.PlayOneShot(faile);

            men.SetActive(false);
            men.SetActive(true);
        }
    }   public void cerrarC()
    {
        COBRAR.SetActive(false);
    }


}
