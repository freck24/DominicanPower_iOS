using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winandlose : MonoBehaviour
{
    public GameObject opciones;
    public GameObject dinero;
    public Text te;
    public Text nombre;
    public bool lose = false;
    public int aa;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(c());
        PlayerPrefs.SetFloat("gana", 0);
        if (lose == false)
        {
            PlayerPrefs.SetFloat("gana1", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(n1 == true && n2 == true || n1== true && n3 == true || n2== true && n3 == true)
        {
            cargar();
        }
        
    }


    public void moto()
    {
        PlayerPrefs.SetFloat("moto", 1);
       
        PlayerPrefs.SetFloat("dia", 31);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 100000);

        PreLoaderLevel.preload.CargaLvl("");
    }  public void carro()
    {
        PlayerPrefs.SetFloat("carro", 1);

        PreLoaderLevel.preload.CargaLvl("inicio");

        PlayerPrefs.SetFloat("dia", 31);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 100000);
    }
    public void saltar()
    {
        PlayerPrefs.SetFloat("moto", 1);
     //   SceneManager.LoadScene("inicio");
        PlayerPrefs.SetFloat("dia", 31);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 100000);
        PreLoaderLevel.preload.CargaLvl("");

    }
    public void reiniciar()
    {
        aa = PlayerPrefs.GetInt("preguntas", 0);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("primera", 1);
        PlayerPrefs.SetInt("preguntas", aa);
        //  SceneManager.LoadScene("inicio");
        PreLoaderLevel.preload.CargaLvl("inicio");
    }


    public IEnumerator c()
    {
        if (lose == false)
        {
            yield return new WaitForSecondsRealtime(.1f);
            te.text = "¿y mi cualto?";
            nombre.text = "El topo";
            yield return new WaitForSecondsRealtime(2f);
            te.text = "Si, lo tengo. Fue dificil pero pude recolectarlo";
            nombre.text = "Tony";
                yield return new WaitForSecondsRealtime(5f);
            te.text = "Nitido entonces";
            nombre.text = "El topo";
            yield return new WaitForSecondsRealtime(1.5f);
            te.text = "Tu sabes que: por haberme cumplido a tiempo te puede quedar con 10,000 pesos";
            yield return new WaitForSecondsRealtime(7);
            te.text = "Yo he sabido moverme en esta crisis y por eso no me ha afectado tanto. Toma";
            yield return new WaitForSecondsRealtime(6f);

            dinero.SetActive(true);
            yield return new WaitForSecondsRealtime(0.5f);
            te.text = "Gracias, con esto podré comprar mi primer vehiculo";
            nombre.text = "Tony";
            yield return new WaitForSecondsRealtime(3.5f);
            te.text = "";
            nombre.text = "";
            opciones.SetActive(true);
        } 
        if (lose == true)
        {
            yield return new WaitForSecondsRealtime(.1f);
            te.text = "¿y mi cualto?";
            nombre.text = "El topo";
            yield return new WaitForSecondsRealtime(1f);
            te.text = "Lo siento pero es muy dificil en tan poco tiempo";
            nombre.text = "Tony";
            yield return new WaitForSecondsRealtime(3.5f);
            te.text = "Que? Yo no acepto no por respuesta";
            nombre.text = "El topo";
            yield return new WaitForSecondsRealtime(3f);
            te.text = "Chicos monten todo al camión";
            yield return new WaitForSecondsRealtime(3);
            te.text = "Por favor no me haga eso";
            nombre.text = "Tony";
            yield return new WaitForSecondsRealtime(2);
            te.text = "Debiste pensalo antes";
            nombre.text = "El topo";

            yield return new WaitForSecondsRealtime(2);
            te.text = "Y que hago ahora? No tengo ni donde dormir";
            nombre.text = "Tony";

            yield return new WaitForSecondsRealtime(5);
            te.text = "";
            nombre.text = "";
            opciones.SetActive(true);
        }

    }

    public bool n1 = false;
    public bool n2 = false;
    public bool n3 = false;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject pl;
  public void uno()
    {
        n1 = true;
        t1.SetActive(true);
    }public void dos()
    {
        n2 = true;
        t2.SetActive(true);
    }
    public void tres()
    {
        n3 = true;
        t3.SetActive(true);
    }
    public void cargar()
    {
        if (n2 == false)
        {
            PlayerPrefs.SetFloat("gana", 1);
        } 
            SceneManager.LoadScene("pale");
    }

    public void jp()
    {
        pl.SetActive(true);
    }


    public void menu()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }


}
