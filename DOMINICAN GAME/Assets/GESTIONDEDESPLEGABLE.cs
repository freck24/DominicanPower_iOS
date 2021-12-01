using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GESTIONDEDESPLEGABLE : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public GameObject botonsubuir;
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
    }
    public void subefALSE()
    {
        anim.SetBool("SUBE", false);
      
    }
       public void activar()
    {
        
        botonsubuir.SetActive(true);
    }

}
