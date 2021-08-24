using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salida : MonoBehaviour
{
    public tigre tiger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            tiger.estadentro = false;
        }
    }



}
