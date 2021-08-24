using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COMPRA : MonoBehaviour
{
    public int I;
    public GameObject BUTON;
   public AudioSource a;
    public AudioClip faile;
    public AudioClip compr;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("conjuro" + I, 0) == 0)
        {
            BUTON.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
    public GameObject tatola;

    public float PRECIO;
    public LIBRO li;
   // public GameObject sonidofaile;
    public void COM()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > PRECIO-1)
        {
            a.PlayOneShot(compr);
            PlayerPrefs.SetInt("conjuro" + I, 1);
            BUTON.SetActive(false);
            li.llama();
            tatola.SetActive(true);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - PRECIO);
        }
        else
        {
            a.PlayOneShot(faile);
          
        }

    }


}
