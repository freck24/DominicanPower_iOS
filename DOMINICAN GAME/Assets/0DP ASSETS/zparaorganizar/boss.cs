using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public AudioClip poder1;
    public AudioClip poder2;
    private AudioSource a;
    public Animator anim2;
    public Animator anim3;
    Animator anim;
    public GameObject VIDA;
    public float v = 100;
    public gestorauidos g;

    public camarasigue c;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        a = GetComponent<AudioSource>();
    }



    public void dale()
    {
        StartCoroutine(bosss());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public Image VIDD;
    public Color COLOR1;
    public Color COLOR2;

    public void BAJAVIDA()
    {
        if (v == 50)
        {
            VIDD.color = COLOR1;
            tiem = 8;
        }

        if (v == 20)
        {
            tiem = 5;
            VIDD.color = COLOR2;
        }

        if (v > 0)
        {
            v -= 1;
            VIDA.transform.localScale = new Vector3(v / 100, VIDA.transform.localScale.y, VIDA.transform.localScale.z);
        }

        if(v==0)
        {
            anim.SetBool("muere", true);
            StartCoroutine(mue());
            g.sonidomagnatefin();
        }
    }


    public IEnumerator mue()
    {
        yield return new WaitForSecondsRealtime(3);
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "balacasco" )
        { 
            BAJAVIDA();
        }
    }


    public float tiem = 10;
    public void p1()
    {
        anim.SetBool("p1", true);
    }
    public bool active = false;
    public IEnumerator bosss()
    {
        while (active)
        {
            yield return new WaitForSecondsRealtime(1);
            anim.SetBool("p1", true);
            a.clip = poder1;
            a.Play();
            anim2.SetBool("sube", true);
          
            yield return new WaitForSecondsRealtime(0.2f);
            anim.SetBool("p1", false);
            anim2.SetBool("sube", false);
            yield return new WaitForSecondsRealtime(tiem);
            anim3.SetBool("REDES", true);
            anim.SetBool("p2", true);
            a.clip = poder2;
            a.Play();
            yield return new WaitForSecondsRealtime(0.2f);
            anim.SetBool("p2", false);
            anim3.SetBool("REDES", false);
            yield return new WaitForSecondsRealtime(tiem);
        }

    }


}
