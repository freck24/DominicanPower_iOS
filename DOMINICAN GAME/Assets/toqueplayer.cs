using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toqueplayer : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D r;
    Vector2 a;
    public float rand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "botella")
        {
           // rand = -1;
          ///  a = new Vector2(rand, 0);
          //  r.AddForce(a);
            anim.SetBool("rotai", true);
        }
    }
}
