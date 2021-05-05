using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tragaperra : MonoBehaviour
{

    private void Start()
    {
        a = GetComponent<AudioSource>();
    }


    // Start is called before the first frame update

    public GameObject c11;
    public GameObject c12;
    public GameObject c13;
    public GameObject c21;
    public GameObject c22;
    public GameObject c23;
    public GameObject c31;
    public GameObject c32;
    public GameObject c33;
    public float n1;
    public float n2;
    public float n3;
    public GameObject anima1;
    public GameObject anima2;
    public GameObject anima3;
  private AudioSource a;
    public AudioClip moneda;
    public AudioClip para;
    public AudioClip gana;
    public AudioClip ganafull;
    public AudioClip pierde;
    public GameObject moned;
    public GameObject moned50;
    public GameObject moned5000;
    public bool ingame = true;
   // int n = 15;
    public void traga()
    {


        if (PlayerPrefs.GetFloat("dinero", 0) > 4)
        {
            if (ingame)
            {
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 5);
                StartCoroutine(incia());
            }
        }
        else
        {

            a.clip = pierde;
            a.Play();
        }


       
    }


    public IEnumerator incia()

    {
        ingame = false;
        moned.SetActive(true);
        a.clip = moneda;
        a.Play();
        yield return new WaitForSecondsRealtime(1f);
        anima1.SetActive(true);
        anima2.SetActive(true);
        anima3.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        anima1.SetActive(false);


        if (PlayerPrefs.GetFloat("siempregana", 0) == 0)
        {
            n1 = 3;
        }
        else
        {

            n1 = Random.Range(1, 4);
            n1 = n1 - n1 % 1;
        }
        a.clip = para;
        a.Play();
        switch (n1)
        {   


            case 1:
                c11.SetActive(false);
                c11.SetActive(true);
                c12.SetActive(false);
                c13.SetActive(false);
                break;

            case 2:
                c12.SetActive(false);
                c12.SetActive(true);
                c11.SetActive(false);
                c13.SetActive(false);
                break;

            case 3:
                c13.SetActive(false);
                c13.SetActive(true);
                c11.SetActive(false);
                c12.SetActive(false);
                break;
        }

        yield return new WaitForSecondsRealtime(1f);
        anima2.SetActive(false);


        a.clip = para;
        a.Play();
        if (PlayerPrefs.GetFloat("siempregana", 0) == 0)
        {
            n2 = 3;
        }
        else
        {
            n2 = Random.Range(1, 4);
            n2 = n2 - n2 % 1;
        }


        switch (n2)
        {
            case 1:
                c21.SetActive(false);
                c21.SetActive(true);
                c22.SetActive(false);
                c23.SetActive(false);
                break;

            case 2:
                c22.SetActive(false);
                c22.SetActive(true);
                c21.SetActive(false);
                c23.SetActive(false);
                break;

            case 3:
                c23.SetActive(false);
                c23.SetActive(true);
                c21.SetActive(false);
                c22.SetActive(false);
                break;
        }


        yield return new WaitForSecondsRealtime(1f);
        anima3.SetActive(false);
        if (PlayerPrefs.GetFloat("siempregana", 0) == 0)
        {
            n3 = 3;
            PlayerPrefs.SetFloat("siempregana", 1);
        }
        else
        {
            n3 = Random.Range(1, 4);
            n3 = n3 - n3 % 1;
            
        }
        a.clip = para;
        a.Play();
        switch (n3)
        {
            case 1:
                c31.SetActive(false);
                c31.SetActive(true);
                c32.SetActive(false);
                c33.SetActive(false);
                break;

            case 2:
                c32.SetActive(false);
                c32.SetActive(true);
                c31.SetActive(false);
                c33.SetActive(false);
                break;

            case 3:
                c33.SetActive(false);
                c33.SetActive(true);
                c31.SetActive(false);
                c32.SetActive(false);
                break;
        }
        moned.SetActive(false);

        if(n1==n2 && n2 == n3)
        {
            a.clip = ganafull;
            a.Play();
            moned50.SetActive(true);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 5000);


        } else   if(n1==n2 || n2 == n3)
        {
            moned5000.SetActive(true);
            a.clip = gana;
            a.Play();
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 50);
        }
        else  
        {
            a.clip = pierde;
            a.Play();
        }
        ingame = true;

        yield return new WaitForSecondsRealtime(2f);
        moned50.SetActive(false);
        moned5000.SetActive(false);

    }



}
