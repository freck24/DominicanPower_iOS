using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dest1000 : MonoBehaviour
{
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
        if(collision.tag == "Player" || collision.tag == "cabezap")
        {
            Destroy(gameObject);
        }
    }
}
