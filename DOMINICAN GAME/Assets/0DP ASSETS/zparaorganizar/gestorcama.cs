using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestorcama : MonoBehaviour
{
    private AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }
    public GameObject menu;
    public GameObject jugar;

    public void me()
    {
        menu.SetActive(true);
    }
    public void j()
    {
        jugar.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void parar()
    {
        a.Stop();
    } 
    public void Plays()
    {
        a.Play();
    }
}
