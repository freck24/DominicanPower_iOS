using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop : MonoBehaviour
{
    public AudioSource a;
    public AudioClip pops;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void po()
    {
        a.PlayOneShot(pops);
    }
}
