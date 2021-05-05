using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJETO : MonoBehaviour
{
    public bool SOYYO;
    public gestorminijuego5 gestor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void KLK()
    {
        if (SOYYO)
        {
            gestor.gane = true;
            gestor.tiempo = gestor.tiempolimite;
            SOYYO = false;

        } else
        {
            gestor.tiempo = gestor.tiempolimite;
        }
    }

}
