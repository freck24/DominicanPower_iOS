using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desctador : MonoBehaviour
{
    public gestorddd d;
    public int zona;
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
        if (other.tag == "d1")
        {
            d.pj1 = zona;
        } 
        if (other.tag == "d2")
        {
            d.pj2 = zona;
        }
    }



}
