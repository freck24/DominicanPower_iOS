using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestmoto : MonoBehaviour
{
   public Animator anim;
    public manita m;
    // Start is called before the first frame update
    void Start()
    {
     //   anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m.vp)
        {
            anim.SetBool("atraco", true);
        }
        else
        {
            anim.SetBool("atraco", false);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
          //  anim.SetBool("mira", true);
        }
    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //anim.SetBool("mira", false);
         
        }
    }
}
