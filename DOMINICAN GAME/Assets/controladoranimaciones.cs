using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladoranimaciones : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject camara;
    public GameObject camara2;
    public GameObject silla;
    public void a1()
    {
        anim.SetBool("a1", true);
    } public void a2()
    {
        anim.SetBool("a2", true);
    }public void camaras()
    {
        anim.SetBool("a3", true);
        camara2.SetActive(true);
        camara.SetActive(false);
        silla.SetActive(true);
    }

    public void camaras1()
    {
        camara.SetActive(true);
        camara2.SetActive(false);
        camara3.SetActive(false);
        
    } public void camaras2()
    {
        camara2.SetActive(true);
        camara.SetActive(false);
        
    }
    
    public void camaras3()
    {
        camara3.SetActive(true);
        camara.SetActive(false);
        camara2.SetActive(false);
        
    }


    public Animator animcama;

    public GameObject camara3;
    public void ccc()
    {
        animcama.SetBool("a1", true);
    }





}
