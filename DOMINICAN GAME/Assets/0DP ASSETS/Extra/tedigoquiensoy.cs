using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tedigoquiensoy : MonoBehaviour
{
    public int i = 0;
    public tragaperras1 traga;
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
        if (other.tag == "parador")
        {
            traga.i = i-1;
        }
    }
}
