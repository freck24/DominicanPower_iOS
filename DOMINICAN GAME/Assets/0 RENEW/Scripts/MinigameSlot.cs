using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameSlot : MonoBehaviour
{
    public string Nombre;
    public int NivelNecesario;
    public int NivelJugador;
    public GameObject LockedItem;
    public Text texto;

    void Start()
    {
        CheckStates();
    }

    void CheckStates()
    {
        texto.text = Nombre;
        NivelJugador = Convert.ToInt32(PlayerPrefs.GetFloat("nivel", 0));
        LockedItem.SetActive(NivelJugador <= NivelNecesario);
    }

   
}
