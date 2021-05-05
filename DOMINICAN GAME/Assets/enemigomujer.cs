using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigomujer : MonoBehaviour
{
    // Start is called before the first frame update
    //public Rigidbody r;
    public Vector3 v1;
    public Vector3 v2;
    public Animator anim;
    public float tiempo = 0.2f;

    public Transform objet;
  //  public AnimationClip a;
    //public Animation a1;
    void Start()
    {
        StartCoroutine(c());
    }
    public Vector3 guardarrotacion;
    // Update is called once per frame
    void Update()
    {
       transform.LookAt(objet);
        transform.eulerAngles = new Vector3(0, (int)transform.eulerAngles.y, transform.eulerAngles.z);
        
        
    }
    bool siempre = true;

    public bool atras = false;

   

  

    IEnumerator c()
    {
        while (siempre)
        {
            v1.x = (int)transform.position.x;
            v1.y = (int)transform.position.y;
            v1.z = (int)transform.position.z;
            yield return new WaitForSecondsRealtime(tiempo);
            if (v1.x != (int)transform.position.x || v1.z != (int)transform.position.z)
            {
                anim.SetBool("idle", false);



                if(atras)
         
                {
                    if (v1.x < (int)transform.position.x || v1.z < (int)transform.position.z)
                    {
                       transform.localScale = new Vector3(2.11f, transform.localScale.y, transform.localScale.z);
                    }
                    else
                    {
                        transform.localScale = new Vector3(-2.11f, transform.localScale.y, transform.localScale.z);
                    }

                }
                else
                {
                    if (v1.x < (int)transform.position.x || v1.z < (int)transform.position.z)
                    {
                        transform.localScale = new Vector3(-2.11f, transform.localScale.y, transform.localScale.z);
                    }
                    else
                    {
                        transform.localScale = new Vector3(2.11f, transform.localScale.y, transform.localScale.z);
                    }
                }
                
            }
            else
            {
                anim.SetBool("idle", true);
            }
        }
    }
}
