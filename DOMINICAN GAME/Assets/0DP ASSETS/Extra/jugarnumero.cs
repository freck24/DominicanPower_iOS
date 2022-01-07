﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class jugarnumero : MonoBehaviour
{
    public bool Jugado;
    // Start is called before the first frame update
    public Text t;
    public int numero = 0;
    public AudioSource a;
    public AudioClip dinero;
    public AudioClip facil;
    public Image yo;

    public Sprite Selected;
    public Sprite NoSelected;


    public void Start()
    {
        numero = transform.GetSiblingIndex();
        t.text = "" + numero;

        if(PlayerPrefs.GetInt("n" + numero, 0) != 0)
        {
            Jugado = true;
            yo.sprite = Selected;
        }

    }
    public void jugar()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > 99)
        {
            Jugado = true;

            PlayerPrefs.SetString("fecha", DateTime.Now.ToString());
            yo.sprite = Selected;
            PlayerPrefs.SetInt("n" + numero, PlayerPrefs.GetInt("n" + numero, 0) + 100);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 100);
            a.PlayOneShot(dinero);

            PlayerPrefs.SetInt("hoycobre", 0);
        }
        else
        {
            a.PlayOneShot(facil); //quise decir faile
        }
       
    }
}
