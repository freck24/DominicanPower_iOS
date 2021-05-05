using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOCADO : MonoBehaviour
{
   // public GameObject p;
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
        if(collision.tag== "Player")
        {
          //  p.SetActive(false);
         //   p.SetActive(true);

        }
    }
}
