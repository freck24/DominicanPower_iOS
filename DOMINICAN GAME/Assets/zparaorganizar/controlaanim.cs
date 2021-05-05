using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlaanim : MonoBehaviour
{
    public pamedestruyo pame;
    public bool starpanu = false;
    Animator anim;
    public GameObject panureal;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(pame.avisatipa == true)
        {
            anim.SetBool("sinpanu", true);
            panureal.SetActive(false);
        }


        if (starpanu)
        {
           
            anim.SetBool("panu", true);

        }
        else
        {
            anim.SetBool("panu", false);

            pame.avisatipa = false;
            anim.SetBool("sinpanu", false);

        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (starpanu)
        {
            if (other.tag == "player" || other.tag == "enemy")
            {
               
               

               
            }
        }
    }
   
}
