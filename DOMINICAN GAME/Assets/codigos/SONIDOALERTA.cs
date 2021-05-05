using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SONIDOALERTA : MonoBehaviour {

    public AudioClip poli;
    public AudioClip mot;
    private AudioSource audi;
    public bool llego = false;
  
    public bool pol = false;

    // Start is called before the first frame update
    void Start()
    {
      
        audi = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }




    void OnTriggerEnter2D(Collider2D otroi)

    {
        if (otroi.gameObject.tag == "Player")
        {
       
            {
                if (pol == true)
                {
                    audi.clip = poli;
                    audi.Play();

                }

                if (pol == false)
                {
                    audi.clip = mot;
                    audi.Play();

                }
            }



        }



        if (otroi.gameObject.tag == "apaga")
        {

        }
    }
}
