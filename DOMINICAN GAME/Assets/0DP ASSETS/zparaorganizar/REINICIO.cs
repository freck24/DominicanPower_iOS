using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class REINICIO : MonoBehaviour
{
    public GameObject seguro;
   public Text texmo = null;
    public AudioClip pop;
    private AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       // aa = PlayerPrefs.GetInt("preguntas", 0);
        texmo.text = "$" + PlayerPrefs.GetFloat("dinero", 0f).ToString("f0");
    }
    public GameObject mensa;
    public GameObject mensa2;
   // public GameObject emp;
   // public GameObject cont;
   // public GameObject yun;
    public bool p = false;
    public int aa;


    public void segu()
    {
        seguro.SetActive(true);
    }
    public void nosegu()
    {
        seguro.SetActive(false);
    }







    public void reinicio()

    {
        a.clip = pop;
        a.Play();
        if (PlayerPrefs.GetFloat("prime", 0f) == 0 && p == false) { 
            mensa2.SetActive(false);
            mensa2.SetActive(true);
            p = !p;
        }
        else if (PlayerPrefs.GetFloat("prime", 0f) == 0 && p == true)
        {
            mensa2.SetActive(false);
            mensa2.SetActive(true);
            p = !p;
        }

      //  emp.SetActive(true);
      //  cont.SetActive(false);


        /* PlayerPrefs.SetFloat("prime", 0f);
         PlayerPrefs.SetFloat("platanos", 0f);
         PlayerPrefs.SetFloat("dinero", 0f);
         PlayerPrefs.SetFloat("tiempogene", 10f);
         PlayerPrefs.SetFloat("yun", 0f);
         PlayerPrefs.SetFloat("trucano", 0f);
         PlayerPrefs.SetFloat("tiempoyun", 100f);
         PlayerPrefs.SetFloat("nivel", 1f);*/
        aa = PlayerPrefs.GetInt("preguntas", 0);
       PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("primera", 1);
        PlayerPrefs.SetInt("preguntas", aa);

        SceneManager.LoadScene("gracias");

        mensa.SetActive(true);
      //  yun.SetActive(true);

    }
}
