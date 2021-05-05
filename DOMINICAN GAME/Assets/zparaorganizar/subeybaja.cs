using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subeybaja : MonoBehaviour
{
   float arriba;
    public float cuantosube=2;
    public float velocidad=2;
    public bool sube = true;
    public bool baja = false;
    public bool unavez = true;
    // Start is called before the first frame update
    void Start()
    {
        arriba = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > arriba + cuantosube && sube)
        {
            baja = true;
            sube = false;
          
           
        } 
        
        
         if (transform.position.y < arriba - cuantosube && baja)
        {
            baja = false;
            sube = true;
          


          
        }

        if (sube)
        {
            transform.Translate(0, velocidad * Time.deltaTime, 0);
        }else
        if (baja)
        {
            transform.Translate(0, -velocidad * Time.deltaTime, 0);
        }
    }
}
