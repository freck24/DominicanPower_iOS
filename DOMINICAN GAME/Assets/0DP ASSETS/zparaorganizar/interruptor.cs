using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interruptor : MonoBehaviour
{
    private AudioSource a;
    public AudioClip cli;
    Animator anim; 
    public bool prendido = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        a = GetComponent<AudioSource>();
        plataforma.SetActive(prendido);
        anim.SetBool("prendido", prendido);
        una = true;
    }

    // Update is called once per frame
    public bool una;
    IEnumerator u()
    {
        yield return new WaitForSecondsRealtime(0.3f);
        una = true;
    }
    void Update()
    {
        
    }
    public GameObject plataforma;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Player" && una)
        { 
            prendido = !prendido;
            anim.SetBool("prendido", prendido);
            a.clip = cli;
            a.Play();
            plataforma.SetActive(prendido);
            una = false;
            StartCoroutine(u());
        }



    }

}
