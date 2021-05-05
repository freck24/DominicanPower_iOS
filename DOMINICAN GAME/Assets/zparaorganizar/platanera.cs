using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platanera : MonoBehaviour
{
    public bool plataneraohierro = true;
    public AudioSource a;
    public AudioClip platanoaudio;
    public AudioClip cosasviejas;
    public float v;
    public GameObject viejas;
    public GameObject platanos;

    // Start is called before the first frame update
    void Start()
    {
        
        a.volume = 0;
        if (plataneraohierro)
        {
            platanos.SetActive(true);
        }
        else
        {
            viejas.SetActive(true);
        }


        if (plataneraohierro)
        {
            a.clip = platanoaudio;
           
        }
        else
        {
            a.clip = cosasviejas;
        }

        a.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(v * Time.deltaTime,0,0);
    }


    IEnumerator subirvolumen()
    {
        a.volume = 0;
        while (a.volume < 1)
        {
            yield return new WaitForSecondsRealtime(0.1f);
            a.volume += 0.1f;

        }
       
    }   IEnumerator bajarvolumen()
    {
        a.volume = 1;
        while (a.volume > 0)
        {
            yield return new WaitForSecondsRealtime(0.1f);
            a.volume -= 0.1f;

        }
        a.volume = 0;

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(subirvolumen());
           
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            StartCoroutine(bajarvolumen());
        }
        }

}
