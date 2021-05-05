using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elimina : MonoBehaviour
{
    public GameObject ganar;
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
        if (other.tag == "Player")
        {
            ganar.SetActive(false);
        }
    }
}
