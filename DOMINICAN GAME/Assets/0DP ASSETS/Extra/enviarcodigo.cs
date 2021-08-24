using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enviarcodigo : MonoBehaviour
{
    public float codigo;
    public BRUJERIA b;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void magia()
    {
        b.codigos = codigo;
        b.magia();
    }

}
