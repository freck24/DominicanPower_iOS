using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volvetea : MonoBehaviour
{
    public Transform personaje;
    public politiroteo tiro;
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
        if (collision.tag == "Player")
        {
            personaje.localScale = new Vector3(-personaje.localScale.x, personaje.localScale.y, -personaje.localScale.z);
            tiro.derecha = !tiro.derecha;
        }
    }
}
