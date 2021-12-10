﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin3D : MonoBehaviour
{
    public enum Dinero
        {
        _5,
        _10,
        _20,
        _25,
        _50,
        _100,
        _200,
        _500,
        _1000,
        _2000
    }

    public Dinero DineroValor;

    public int Valor;
    public Animator anim;

    [Header("Objetos Dinero")]
    public List<GameObject> Dineros;

    private void Start()
    {
        string DineroValorX = DineroValor.ToString().Replace("_", "");
        print(DineroValorX);

    Instantiate(Dineros[(int)DineroValor], transform);
        Valor = System.Convert.ToInt32(DineroValorX.ToString());
    }

    public void ObtenerMonedas()
    {
    PlayerRunner.pr.Player.PlayOneShot(PlayerRunner.pr.RecogerDinero);
    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + Valor);
    Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "yun")
        {
            DestroyImmediate(gameObject);
            print("coin mala destruyendo"); 
        }
    }
}
