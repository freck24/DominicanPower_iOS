using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestiondemusica : MonoBehaviour
{
    public AudioClip serio;
    public AudioClip tigr;

    public bool cam = false;
    public bool nocam = false;
    private AudioSource a;
    public controler co;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {
        if (cam)
        {
            a.clip = tigr;
            a.Play();
            cam = false;
        } 
        
        if (nocam)
        {

                          

            a.Stop();
            nocam = false;
        }
    

          if (co.paus==0)
        {

                          

            a.Stop();
            
        }

    }
}
