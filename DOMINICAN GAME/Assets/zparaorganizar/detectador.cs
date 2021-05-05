using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectador : MonoBehaviour
{
    public SimpleCharacterControlFree simple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "suelo")
        {
            simple.suel = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "suelo")
        {
            simple.suel = false;
        }
    }

}
