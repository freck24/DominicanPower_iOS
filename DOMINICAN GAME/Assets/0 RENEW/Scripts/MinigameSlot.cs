using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameSlot : MonoBehaviour
{
    public string CondicionX;

    public string Nombre;
    public int NivelNecesario;
    public int NivelJugador;
    public GameObject LockedItem;
    public Text texto;

    public bool Condicion;

    void Start()
    {
        if(!Condicion) CheckStates();

        CheckStates2();
    }

    void CheckStates()
    {
        texto.text = Nombre;
        NivelJugador = Convert.ToInt32(PlayerPrefs.GetFloat("nivel", 0));
        LockedItem.SetActive(NivelJugador <= NivelNecesario);
    }

    void CheckStates2()
    {
        texto.text = Nombre;
        if(CondicionX == "Moto") LockedItem.SetActive(PlayerPrefs.GetFloat("moto", 0) == 0);

    }


}
