using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class gestordebanca : MonoBehaviour
{

    [Header("Lista Numeros Jugados")]
    public Transform JugadosItems;
    public GameObject ItemLayout;


    public void LimpiarTicket()
    {
      foreach (Transform child in JugadosItems) Destroy(child.gameObject);
    }
    public void CreateNewNumero(int Number)
    {
        GameObject obj = Instantiate(ItemLayout, JugadosItems);
        obj.GetComponent<jugarnumero>().t.text = Number + "";
    }


    [Space(5)]
    public bool Cobrar;

    public GameObject jugar;
    public GameObject revisartiket;
    public GameObject COBRAR;

    public int primern;
    public int segundon;
    public int tercern;
    public DateTime tiempoactual;
    public TimeSpan diferencia;

    public TextMeshPro n1;
    public TextMeshPro n2;
    public TextMeshPro n3;

    public Text timpo;
    bool puedeabrir = true;

    public Text textcobrar;
    public Text textcobrart;

    public int total;

    public AudioSource a;
    public AudioClip faile;

    public GameObject men;
    public GameObject mensaje;
    public GameObject MenuBanca;


    void Start()
    {
        tiempoactual = DateTime.Now;

        diferencia = tiempoactual - Convert.ToDateTime(PlayerPrefs.GetString("fecha", tiempoactual.ToString()));
        //  timpo.text = "Tiempo para proximo sorteo: " + diferencia.Hours.ToString() + " horas " + diferencia.Minutes.ToString() + " minutos" + diferencia.Days.ToString();
        if (diferencia.Days > 0)
        {
            LOTERIA();
        }
        n1.text = PlayerPrefs.GetInt("nnn1", 24).ToString();
        n2.text = PlayerPrefs.GetInt("nnn2", 20).ToString();
        n3.text = PlayerPrefs.GetInt("nnn3", 28).ToString();
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

    public void numerojugados()
    {
        LimpiarTicket();

        for (int i = 0; i < 101; i++)
        {
            if (PlayerPrefs.GetInt("n" + i, 0) > 0)
            {
                CreateNewNumero(i);
                puedeabrir = false;
            }

        }
    }



    public void borrar()
    {
        for (int i = 0; i < 101; i++) PlayerPrefs.SetInt("n" + i, 0);
    }


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
            MenuBanca.SetActive(true);
        }
    }

    public void cerrarj()
    {
        jugar.SetActive(false);
    }

    public void abrirT()
    {
        revisartiket.SetActive(true);
        numerojugados();
    }

    public void cerrarT()
    {
        revisartiket.SetActive(false);
    }

    public void abrirC()
    {
        diferencia = tiempoactual - Convert.ToDateTime(PlayerPrefs.GetString("fecha", tiempoactual.ToString()));
        print(diferencia.Days);
        if (diferencia.Days > 0) Cobrar = true;

        if (Cobrar && PlayerPrefs.GetInt("hoycobre", 1) == 0)
        {
            COBRAR.SetActive(true);
            numerojugadosCOBRAR();
            borrar();

            PlayerPrefs.SetInt("hoycobre", 1);
        }
        else
        {
            a.PlayOneShot(faile);

            men.SetActive(false);
            men.SetActive(true);
            MenuBanca.SetActive(true);
        }
    }

    public void cerrarC()
    {
        COBRAR.SetActive(false);
    }


}
