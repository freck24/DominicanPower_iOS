using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GESTORDEPALE : MonoBehaviour
{
    public GameObject ruido;
    public GameObject bolas;
    public GameObject ganador;
    public GameObject msr;
    private AudioSource a;
    public Text t;
    public AudioClip ruidosonido;
    public AudioClip audiobolos;
    public AudioClip wee;

    // Start is called before the first frame update
    void Start()
    {
      
        a = GetComponent<AudioSource>();
        StartCoroutine(pale());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator pale()
    {
       a.clip = ruidosonido;
       a.Play();
        yield return new WaitForSecondsRealtime(1);
        ruido.SetActive(false);
        bolas.SetActive(true);
        a.clip = audiobolos;
        a.Play();
        yield return new WaitForSecondsRealtime(2);
        a.clip = audiobolos;
        a.Play();
        
        yield return new WaitForSecondsRealtime(2.5f);
        a.clip = audiobolos;
        a.Play();
        yield return new WaitForSecondsRealtime(2.5f);
        a.clip = wee;
        a.Play();
        ganador.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        msr.SetActive(true);
        if (PlayerPrefs.GetFloat("gana", 0) == 1)
        {
            t.text = "Gane 150,000 pesos, pagaré los 100 que debo y compraré una moto";
            PlayerPrefs.SetFloat("moto", 1);
         //   PlayerPrefs.SetFloat("dinero", 0 );
        }
        else
        {
            t.text = "Me pelé";
          //  PlayerPrefs.SetFloat("dinero", 0);

        }
        PlayerPrefs.SetFloat("dia", 31);
            yield return new WaitForSecondsRealtime(4);

        SceneManager.LoadScene("inicio");
        

    }
}
