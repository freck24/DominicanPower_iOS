using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestorddd : MonoBehaviour
{
    // Start is called before the first frame update

    public int pj1 = 1;
    public int pj2 = 1;

    void Start()
    {
        
    }
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if (pj1 == pj2)
        {
            anim.SetInteger("p", pj1);
        }else       if (pj1 == 1 && pj2==2)
        {
            anim.SetInteger("p", 2);
        } else
        if (pj1 == 2 && pj2 == 1)
        {
            anim.SetInteger("p", 2);
        } else
        if (pj1 == 3 && pj2 == 2)
        {
            anim.SetInteger("p", 2);
        } else
        if (pj1 == 2 && pj2 == 3)
        {
            anim.SetInteger("p", 2);
        }
        else
        {
            anim.SetInteger("p", 0);
        }
    }






}
