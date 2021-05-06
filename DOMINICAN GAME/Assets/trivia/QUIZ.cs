
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class QUIZ : MonoBehaviour
{

    [SerializeField] private Text npregunta = null;
    [SerializeField] private List<Opcionesbotones> mbotones = null;


    public void Construir(preguntas p, Action<Opcionesbotones> llamar)

    { npregunta.text = p.texto;
    

        for (int n = 0 ; n < mbotones.Count; n++)
        {
            mbotones[n].Construir(p.opciones[n], llamar);
        }
    }
}