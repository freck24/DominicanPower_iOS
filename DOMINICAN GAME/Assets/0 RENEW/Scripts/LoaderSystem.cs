﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class LoaderSystem : MonoBehaviour
{

    public static LoaderSystem system;

    public int NivelActual;
    public bool Test;

    public List<GameObject> Niveles;
    public Transform ContentLevel;
    public void CargarNivel()
    {
        Instantiate(Niveles[NivelActual], ContentLevel);
    }

    void Awake()
    {
        system = this;

        if (!Test)
            NivelActual = Convert.ToInt32(PlayerPrefs.GetFloat("nivel", 1f));
    }


}
