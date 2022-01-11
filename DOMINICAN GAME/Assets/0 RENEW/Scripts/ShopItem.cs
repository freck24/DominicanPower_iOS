using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShopItem : MonoBehaviour
{
    public string ObjetoName;
    public int Precio;
    public int CompradoX;

    public GameObject ComprarBtn;
    public GameObject CompradoBtn;

    public UnityEvent EventoEquipar;
    public UnityEvent EventoComprar;

    [Header("Boton Color")]
    public Image ComprarImg;
    public Sprite PuedeComprarlo;
    public Sprite NoPuedeComprarlo;


    private void Update()
    {
        if(Time.frameCount % 10 == 0)
        {
        float coins = PlayerPrefs.GetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0));

        if (coins >= Precio) ComprarImg.sprite = PuedeComprarlo;
        else ComprarImg.sprite = NoPuedeComprarlo;
        }

    }
    public void EquiparCall()
    {
        EventoEquipar.Invoke();
    }

    public void ComprarCall()
    {
    float coins = PlayerPrefs.GetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0));

        if (coins >= Precio)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - Precio);
            PlayerPrefs.SetInt("Shop_" + ObjetoName, 1);
        }
        else FindObjectOfType<ROPA>().PlayFail();


        CheckDisponible();


    }
    private void Start() => CheckDisponible();

    public void CheckDisponible()
    {
    bool Comprado = PlayerPrefs.GetInt("Shop_" + ObjetoName, 0) == 1;
        CompradoX = PlayerPrefs.GetInt("Shop_" + ObjetoName, 0);
    ComprarBtn.SetActive(!Comprado);
    CompradoBtn.SetActive(Comprado);
    }

}
