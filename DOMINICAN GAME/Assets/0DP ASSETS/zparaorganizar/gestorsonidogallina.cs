using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestorsonidogallina : MonoBehaviour
{
    private AudioSource a;
    public AudioClip comer;
    public AudioClip volar;
    public AudioClip morir;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    public void comido()
    {
        a.clip = comer;
        a.Play();
    }
}
