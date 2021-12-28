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
 

    public void me()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");
    }
    public void j()
    {
        PreLoaderLevel.preload.CargaLvl("LEVEL 1 CLONE");
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
