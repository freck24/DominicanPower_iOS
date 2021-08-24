using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class ganador : MonoBehaviour

{ 
 

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject perder;
    public GameObject perderns;
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "perder")
        {
            perder.SetActive(false);
            perderns.SetActive(false);
        }
        if (other.tag == "destroy")
        {
            perder.SetActive(false);
            perderns.SetActive(false);
        }


    }
}
