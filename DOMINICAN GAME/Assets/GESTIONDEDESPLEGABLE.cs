using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GESTIONDEDESPLEGABLE : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public GameObject botonsubuir;
    public AudioSource a;
    public AudioClip sas;
    public AudioClip sasd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sube()
    {
        anim.SetBool("SUBE", true);
        botonsubuir.SetActive(false);
        a.PlayOneShot(sas);
    }
    public void subefALSE()
    {
        anim.SetBool("SUBE", false);
        a.PlayOneShot(sasd);

    }
       public void activar()
    {
        
        botonsubuir.SetActive(true);
    }

}
