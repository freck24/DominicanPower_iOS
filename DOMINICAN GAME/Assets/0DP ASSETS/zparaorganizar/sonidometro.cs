using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidometro : MonoBehaviour
{ private AudioSource a ;
    public AudioClip metro;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.tag == "Player")
        {
            a.clip = metro;
            a.Play();
        }
    }
}
