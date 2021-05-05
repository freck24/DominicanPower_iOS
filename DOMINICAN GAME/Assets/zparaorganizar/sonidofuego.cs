using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidofuego : MonoBehaviour
{
    public AudioClip fuego;
    private AudioSource a;
    public GameObject fue;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            a.clip = fuego;
            a.Play();
            fue.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            a.Stop();
            fue.SetActive(false);
        }
    }

}
