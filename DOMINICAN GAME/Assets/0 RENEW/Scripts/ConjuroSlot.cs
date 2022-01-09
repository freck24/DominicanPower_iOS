using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConjuroSlot : MonoBehaviour
{
    public bool Setup;
    public bool Comprado;
    public int IDConjuro;
    public string NombreConjuro;
    [Multiline(5)] public string Descripcion;
    public int PrecioConjuro;

    public GameObject LockedItem;


    [Header("Componentes")]
    public Image img;
    public Image imgColor;
    public Color Tienes;
    public Color NoTienes;
    public Text NombreTx;

    void Start() => CheckMe();
    private void CheckMe()
    {
        NombreTx.text = NombreConjuro;
        Comprado = PlayerPrefs.GetInt("conjuro" + IDConjuro, 0) == 1;
        imgColor.color = Comprado ? Tienes : NoTienes;
        LockedItem.SetActive(!Comprado);

        GetComponent<Button>().interactable = Comprado;
    }

    

    public void OpenInfo() => LIBRO.Libro.AbrirInfo(this);

    public void ComprarConjuro()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) >= PrecioConjuro && !Comprado)
        {
            print("Se - Compro");
            Comprado = true;
            LIBRO.Libro.Informacion.SetActive(false);
            PlayerPrefs.SetInt("conjuro" + IDConjuro, 1);
            //   a.PlayOneShot(compr);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - PrecioConjuro);
            CheckMe();
        }
        else
        {
            //  a.PlayOneShot(faile);
        }

    }
}



