using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class jugarnumero : MonoBehaviour
{
   
    // Start is called before the first frame update
    public Text t;
    public int numero = 0;
    public AudioSource a;
    public AudioClip dinero;
    public AudioClip facil;
    public Image yo;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void jugar()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > 99)
        {
            PlayerPrefs.SetString("fecha", DateTime.Now.ToString());
            yo.color = Color.green;
            PlayerPrefs.SetInt("n" + numero, PlayerPrefs.GetInt("n" + numero, 0) + 100);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 100);
            a.PlayOneShot(dinero);

            PlayerPrefs.SetInt("hoycobre", 0);
        }
        else
        {
            a.PlayOneShot(facil); //quise decir faile
        }
       
    }

    public void ponmenumero()
    {
        if (numero <= 9)
        {
            t.text = "0" + numero;
        }
        else
        {
            t.text = "" + numero;
        }
       
    }
}
