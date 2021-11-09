using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dialogod : MonoBehaviour
{ public float t1=1;
 public float t2=2;
 public float t3=3;
 public float t4=2;
public float t5=2;
    private AudioSource a;
   /* public AudioClip d1;
    public AudioClip d2;
    public AudioClip d3;
    public AudioClip d4;
    public AudioClip d5;
    public AudioClip d6;*/
    public AudioClip d7;
    public AudioClip d0;
    public AudioClip cat;

    public Text nombre;
    public Text dialog;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
        StartCoroutine(dialogo());
        PlayerPrefs.SetFloat("p1", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator dialogo()
    {
        a.clip = d0;
        a.Play();
        nombre.text = "EL TOPO:";
        dialog.text = "Con que bailando Salsa";

        yield return new WaitForSecondsRealtime(3f);
        dialog.text = "En este pais se baila Merengue";
        yield return new WaitForSecondsRealtime(4.7f);
        nombre.text = "Tony:";
        dialog.text = "¿Que quieres?";
        yield return new WaitForSecondsRealtime(2);
     //   a.clip = d1;
     //   a.Play();
        nombre.text = "EL TOPO:";
        dialog.text = "Necesito mi dinero para este mes ";
      
        yield return new WaitForSecondsRealtime(t2);
       // a.clip = d2;
     //   a.Play();
        nombre.text = "Tony:";
        dialog.text = "Sabes que vine a este pais a trabajar pero los trabajos estan complejos";
       
        yield return new WaitForSecondsRealtime(t3);
      //  a.clip = d3;
      //  a.Play();
        nombre.text = "EL TOPO:";
        dialog.text = "Lo entiendo pero tienes una linda casa";
     
        yield return new WaitForSecondsRealtime(t4);
     //   a.clip = d4;
      //  a.Play();
        dialog.text = "Encuentra mi dinero o nos llevaremos todos los muebles";

        yield return new WaitForSecondsRealtime(t5);
    //    a.clip = d5;
     //   a.Play();
        nombre.text = "Tony:";
        dialog.text = "No puedes hacer eso";


        yield return new WaitForSecondsRealtime(2f);
      //  a.clip = d6;
       // a.Play();
        nombre.text = "EL TOPO:";
        dialog.text = "Tienes 30 dias y 100,000 pesos que conseguir ";


        yield return new WaitForSecondsRealtime(3f);
        a.PlayOneShot(cat);
        yield return new WaitForSecondsRealtime(1f);
        a.PlayOneShot(d7);
       
        yield return new WaitForSecondsRealtime(2);
    //  SceneManager.LoadScene("inicio");

    }


    public GameObject pantalladecarga;
    public void SALTAR()
    {
        pantalladecarga.SetActive(true);
    }
}
