using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class politiroteo : MonoBehaviour
{ public float velocity = 5;
    private AudioSource a;
    Animator anim;
    public AudioClip suspenso;

    public GameObject ene;
    public GameObject ene1;
    public Transform p1;
    public Transform p2;
    public Transform p3;
    public GameObject part;
    bool comenzado = false;
    // Start is called before the first frame update
    void Start()
    { 
        a = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(0,0,velocity * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("caminao"))
        {
           
            part.SetActive(true);
            velocity = 0;
            a.clip = suspenso;
            a.Play();
            anim.SetBool("deli", true);
            if (!comenzado)
            {
                comenzar();
                comenzado = true;
            }
        }
        if(collision.CompareTag("walk"))
        {
            part.SetActive(false);
            a.Stop();
            velocity = 5;
            anim.SetBool("deli", false);
            cancelargen();
            comenzado = false;
        }

    }


    public void OnTriggerExit2D(Collider2D collision)
    {
       if(collision.tag == "Player")
        {
            part.SetActive(false);
            a.Stop();
            velocity = 5;
            anim.SetBool("deli", false);
            cancelargen();
            comenzado = false;
        }
    }


    Vector3 h;
    Vector3 aa;
    Vector3 b;
   public int i = 1;

    public bool derecha = true;
    public void crear()
    {
      

        if (i == 1)
        {
            h = new Vector3(p1.transform.position.x, p1.transform.position.y, p1.transform.position.z);
            i = 2;
            aa = new Vector3(0, 0, 1);
           b = new Vector3(1, 0.5f, 0);

        }
        else if (i == 2)
        {
            i = 3;
            h = new Vector3(p2.transform.position.x, p2.transform.position.y, p2.transform.position.z);
            aa = new Vector3(0, 0, 1);
            b = new Vector3(1, 0, 0);
        }
        else
     if (i == 3)
        {
            h = new Vector3(p2.transform.position.x, p2.transform.position.y, p2.transform.position.z);
            i = 1;
            aa = new Vector3(0, 0, 1);
            b = new Vector3(1, -0.5f, 0);

        }




        {
            if (derecha)
            {
                Instantiate(ene, h, Quaternion.LookRotation(aa, b));
            }
            else
            {
                Instantiate(ene1, h, Quaternion.LookRotation(aa, b));
            }

        }


    }













        public void comenzar()
    {
      
            InvokeRepeating("crear", 0.05f, 0.25f);

    }

    public void cancelargen()
    {
        CancelInvoke("crear");
    }

}
