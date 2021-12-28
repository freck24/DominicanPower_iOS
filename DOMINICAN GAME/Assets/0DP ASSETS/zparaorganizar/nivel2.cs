using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nivel2 : MonoBehaviour
{
    public GameObject telefono;
    public GameObject llamada;
    public GameObject B1;
    public GameObject B2;
    public GameObject tl;
    public GameObject cu2;
    public Text texto;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void coger()
    {
        B1.SetActive(false);
        StartCoroutine(llamadad());

    }
    public void ACE()
    {
       
        PlayerPrefs.SetInt("m2", 1);
        SONIDITO.SetActive(true);
        StartCoroutine(CO());
    }
    public GameObject SONIDITO;
    public IEnumerator CO()
    {
      
        B2.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        PreLoaderLevel.preload.CargaLvl("");

    }

    public IEnumerator llamadad()
    {
        yield return new WaitForSecondsRealtime(1);
        tl.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
      

        telefono.SetActive(false);
        llamada.SetActive(true);
        
        texto.text = "aloo montro, oye unos Sanjuaneros estan ofreciendo 250 mil pesos por unos cubos que disque que son magicos";
        yield return new WaitForSecondsRealtime(7);
        cu2.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        texto.text = "Obviamente yo no creo en esa vaina pero vamos a conseguir esos cubos y vamos a ganarnos esa moña para comprarno algo ";
        yield return new WaitForSecondsRealtime(8f);
        texto.text = "Que tu dices?";
     
        yield return new WaitForSecondsRealtime(1);
        B2.SetActive(true);
    }

    public void saltar()
    {
        PreLoaderLevel.preload.CargaLvl("");
    }

}
