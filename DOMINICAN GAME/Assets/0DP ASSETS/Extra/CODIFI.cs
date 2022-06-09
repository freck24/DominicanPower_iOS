using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CODIFI : MonoBehaviour
{
    public GameObject ob;


    private void Awake() {
        ob.SetActive(false);        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ob.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            ob.SetActive(false);
        }
    }
   

}
