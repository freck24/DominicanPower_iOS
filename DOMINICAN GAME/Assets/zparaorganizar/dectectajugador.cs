﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dectectajugador : MonoBehaviour
{
    public movimientocamara mov;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Player")
        {
            mov.sigue = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            mov.sigue = false;
        }
    }
}
