using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mango : MonoBehaviour
{
    public controler con;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            PlayerPrefs.SetFloat("mango", PlayerPrefs.GetFloat("mango", 0) + 1);
           // con.g = con.platano;

        }
    }
}
