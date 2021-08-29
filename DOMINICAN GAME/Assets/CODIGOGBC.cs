using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CODIGOGBC : MonoBehaviour
{
    public GameObject canvas;
    public GameObject camara;
    public AudioSource a;
    public AudioClip fail;
    public AudioClip cajaregistradora;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject barreras;
    public GameObject irfarm;
    IEnumerator devolucion()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        mensaje3.SetActive(false);
        mensaje3.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero") + 100);
    }
    public GameObject mensaje1;
    public GameObject mensaje2;
    public GameObject mensaje3;
    public void comprarvidas()
    {
        if (PlayerPrefs.GetFloat("dinero") > 999)
        {

            if (PlayerPrefs.GetFloat("vidas", 3) < 3)
            {
                PlayerPrefs.SetFloat("vidas", PlayerPrefs.GetFloat("vidas", 3) + 1);
                a.PlayOneShot(cajaregistradora);
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero") - 500);

                
                StartCoroutine(devolucion());
            }
            else
            {
                mensaje1.SetActive(false);
                mensaje1.SetActive(true);
                a.PlayOneShot(fail);
            }
        }
        else
        {
            mensaje2.SetActive(false);
            mensaje2.SetActive(true);
            a.PlayOneShot(fail);
        }
       


    }

    public GameObject CAMARANOCHE;

    public GameObject menue;
    IEnumerator menu()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        menue.SetActive(true);
    }


   public void entrarfar()
    {


        


        if (PlayerPrefs.GetFloat("nivel", 1) % 3 == 0 || PlayerPrefs.GetFloat("nivel", 1)==20)
        {
            CAMARANOCHE.SetActive(false);
            CAMARANOCHE.SetActive(true);

        }
        else
        {
            camara.SetActive(false);
            camara.SetActive(true);
        }


        barreras.SetActive(true);
        irfarm.SetActive(false);

       
        
        StartCoroutine(menu());
    }   public void salirfar()
    {
        barreras.SetActive(false);
        mensaje1.SetActive(false);
        mensaje2.SetActive(false);
        mensaje3.SetActive(false);
        camara.SetActive(false);
        CAMARANOCHE.SetActive(false);
        menue.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canvas.SetActive(false);
        }
    }


}
