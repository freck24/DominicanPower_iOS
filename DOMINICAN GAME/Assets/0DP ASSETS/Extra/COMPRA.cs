using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COMPRA : MonoBehaviour
{
    public int I;
   public AudioSource a;
    public AudioClip faile;
    public AudioClip compr;
   
  

    public float PRECIO;
   // public GameObject sonidofaile;
    public void COM()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > PRECIO-1)
        {
            a.PlayOneShot(compr);
            PlayerPrefs.SetInt("conjuro" + I, 1);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - PRECIO);
        }
        else
        {
            a.PlayOneShot(faile);
          
        }

    }


}
