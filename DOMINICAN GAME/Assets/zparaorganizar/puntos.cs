using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class puntos : MonoBehaviour
{

    public AudioClip der;
    private AudioSource audi;
    public bool soni = false;
    // Start is called before the first frame update
    void Start()
    {
        audi = GetComponent<AudioSource>();
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if (soni) {
            audi.clip = der;
            audi.Play();
            soni = false;
        } }
}
