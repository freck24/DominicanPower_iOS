using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atras : MonoBehaviour
{
    public enemigomujer enemigo;
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
        if (other.gameObject.tag == "atrassss")
        {
            enemigo.atras = false;
            print( "atras");
        }

        if (other.gameObject.tag == "adelanteeee")
        {
            enemigo.atras = true;
            print( "adelante");
        }
    }
}
