using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarcolideralcaer : MonoBehaviour
{
   // public BoxCollider2D b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "suelo")
        {
            gameObject.tag = "Untagged";
           // b.isTrigger = false;
        }
    }
}
