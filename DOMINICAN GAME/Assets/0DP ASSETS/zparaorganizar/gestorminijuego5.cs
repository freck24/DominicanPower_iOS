using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gestorminijuego5 : MonoBehaviour
{
    // Start is called before the first frame update

    public bool gane = false;
    public float tiempo = 0; 
    public float tiempolimite = 15;
    public GameObject perdi;
    public AudioClip sonidoperder;
    public AudioClip win;
    private AudioSource a;
    public float objeto=1;
    public float objetog=1;
    public OBJETO o1;
    public OBJETO o2;
    public OBJETO o3;
    public OBJETO o4;
    public OBJETO o5;
    public OBJETO o6;
    public OBJETO o7;
    public OBJETO o8;
    public OBJETO o9;
    public OBJETO o10;
    public Sprite a1;
    public Sprite a2;
    public Sprite a3;
    public Sprite a4;
    public Sprite a5;
    public Sprite a6;
    public Sprite a7;
    public Sprite a8;
    public Sprite a9;
    public Sprite a10;
    
    void Start()
    {
        a = GetComponent<AudioSource>();
        elige();
    }
    public void MENU()
    {
        SceneManager.LoadScene("inicio");
    }
    // Update is called once per frame
    void Update()
    {if (tiempolimite > tiempo)
        {
            T.text = "" + (tiempolimite - tiempo).ToString("f0");
            dinero.text = "" + PlayerPrefs.GetFloat("dinero",0);
        }
        tiempo += Time.deltaTime;
        if (tiempo > tiempolimite)
        {
            if (gane)
            {
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 15);
                tiempo = 0;
                gane = false;
                if (tiempolimite > 1)
                {
                    tiempolimite -= 1;
                   
                }
                elige();
                a.clip = win;
                a.Play();
            }
            else
            {
                perdi.SetActive(true);
               
            }
        }
    }
    public Text T;
    public Text dinero;
    public Image cual;
    public void REPETIR()
    {
        tiempo = 0;
        perdi.SetActive(false);
        a.clip = win;
        a.Play();
        elige();
        tiempolimite = 15;
    }
    public void elige()
    {  

            objeto = Random.Range(1, 11);
            objeto = objeto - objeto % 1;
        while(objetog==objeto)
        {
            objeto = Random.Range(1, 11);
            objeto = objeto - objeto % 1;
        }
            objetog = objeto;
      

        switch (objeto)
        {
            case 1:
                o1.SOYYO = true;
                cual.sprite = a1;
                break;  case 2:
                o2.SOYYO = true;
                cual.sprite = a2;
                break;  case 3:
                o3.SOYYO = true;
                cual.sprite = a3;
                break;  case 4:
                o4.SOYYO = true;
                cual.sprite = a4;
                break;  case 5:
                o5.SOYYO = true;
                cual.sprite = a5;
                break;  case 6:
                o6.SOYYO = true;
                cual.sprite = a6;
                break;  case 7:
                o7.SOYYO = true;
                cual.sprite = a7;
                break;  case 8:
                cual.sprite = a8;
                o8.SOYYO = true;
                break;  case 9:
                cual.sprite = a9;
                o9.SOYYO = true;
                break;  case 10:
                cual.sprite = a10;
                o10.SOYYO = true;
                break;
                
        }


    }
}
