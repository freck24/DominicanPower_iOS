using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BRUJERIA : MonoBehaviour
{
    int i = 0;

    public Transform player;



    public AudioSource a;
    public controler cont;
    public GameObject plataforma;

    public float contador = 0;
    public float codigos = 0;

    public GameObject aparecedorplata;
    public GameObject efectotiempo;
    public GameObject efectosuicidio;
    public float tiempoespera = 0;
    public AudioClip clan;
    public AudioClip mag;

    public GameObject invocandopollos;
    public GameObject invocandoplatanos;
    public GameObject destructor;
    public GameObject constructor;
    public Animator anim;
    public Image[] conjuro;


    public void cerrarNoMagia()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        controler.statico.anim.SetBool("magic", false);

    }

    public void cerrar()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        controler.statico.anim.SetBool("magic", false);
        controler.statico.HizoMagia();
    }


    IEnumerator apagaaparecedor()
    {
        yield return new WaitForSecondsRealtime(1f);
        aparecedorplata.SetActive(false);
    }



    public void magia()
    {
        tiempoespera = 0;
    }


    public void Magia_Aparece_Plataformas()
    {
        a.PlayOneShot(mag);
        if (codigos == 951)
        {
            PlayerPrefs.SetFloat("local", 1.5f);
        }

        cont.corrutinatonta();
        aparecedorplata.SetActive(false);
        aparecedorplata.SetActive(true);
        StartCoroutine(apagaaparecedor());
        anim.SetInteger("conjuro", 5);
        tiempoespera = 1;
    }

    public void Magia_Suicidio()
    {
        a.PlayOneShot(mag);
        if (codigos == 963)
        {
            PlayerPrefs.SetFloat("local", 1.5f);
        }
        efectosuicidio.SetActive(false);
        efectosuicidio.SetActive(true);
        PlayerPrefs.SetFloat("vidas", 0);
        cont.suicidio();
        tiempoespera = 1;
    }

    public void Magia_InvocarPollos()
    {
        a.PlayOneShot(mag);
        if (codigos == 36951)
        {
            PlayerPrefs.SetFloat("local", 1.5f);
        }
        Instantiate(invocandopollos, new Vector3(player.transform.position.x, player.transform.position.y + 13, player.transform.position.z), Quaternion.identity);
        anim.SetInteger("conjuro", 2);
        tiempoespera = 1;
    }

    public void Magia_InvocarPlatanos()
    {
        a.PlayOneShot(mag);
        if (codigos == 1478951)
        {
            PlayerPrefs.SetFloat("local", 1.5f);
        }
        Instantiate(invocandoplatanos, new Vector3(player.transform.position.x, player.transform.position.y + 13, player.transform.position.z), Quaternion.identity);
        anim.SetInteger("conjuro", 2);
        tiempoespera = 1;

    }

    public void Magia_InvocarDestructor()
    {
        a.PlayOneShot(mag);
        if (codigos == 3698741)
        {
            PlayerPrefs.SetFloat("local", 1.5f);
        }
        Instantiate(destructor, new Vector3(player.transform.position.x, player.transform.position.y + 5, player.transform.position.z), Quaternion.identity);
        anim.SetInteger("conjuro", 1);
        tiempoespera = 1.5f;

    }

    public void Magia_Constructor()
    {
        a.PlayOneShot(mag);
        if (codigos == 753)
        {
            PlayerPrefs.SetFloat("local", 1.5f);
        }
        Instantiate(constructor, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
        anim.SetInteger("conjuro", 1);
        tiempoespera = 1.5f;

    }

    public void Magia_sinnombre()
    {
        Time.timeScale = 1f;
        a.PlayOneShot(mag);

        if (codigos == 789)
        {
            PlayerPrefs.SetFloat("local", 1.5f);
        }
        Time.timeScale = 0.4f;
        efectotiempo.SetActive(false);
        efectotiempo.SetActive(true);
        StartCoroutine(tiempoend());
        tiempoespera = 2.5f;

        StartCoroutine(r());


    }

    IEnumerator tiempoend()
    {
        yield return new WaitForSecondsRealtime(4);
        Time.timeScale = 1;
        efectotiempo.SetActive(false);
    }


    IEnumerator r()
    {
        anim.SetBool("magic", false);
        i = 0;
        contador = 0;
        codigos = 0;
        cerrar();
        cont.corutinabrujeria();
        yield return new WaitForSecondsRealtime(2);
        yield return new WaitForSecondsRealtime(tiempoespera);

    }



    public void enciende()
    {
        cont.vivi();
        codigos += (i + 1) * Mathf.Pow(10, contador);
        contador += 1;
        a.PlayOneShot(clan);
    }


}
