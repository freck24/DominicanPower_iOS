using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ROPA : MonoBehaviour
{
    Renderer rend;
    public Material m1;
    public Material m2;
    public Material m3;
    public Material m4; 
    public Text inmo;
    public Text MENSAinmo;
    public GameObject torbellino;
    public GameObject MENSAJEIN;
    public GameObject imagenimortalidad;
    public AudioClip fail;
    public AudioClip com;
    private AudioSource a;

    public void tor()
    {
    torbellino.SetActive(false);
    torbellino.SetActive(true);
    }

  
    public void comprainmortalidad()
    {
    MENSAJEIN.SetActive(true);
    MENSAinmo.text = "HAS COMPRADO LA INMORTALIDAD.  NOTA: PUEDES SER INMORTAL PERO ESO NO EVITA QUE TE ATRAQUEN EN RD. ASI QUE MANGA TU CAMINAO DIOS " + PlayerPrefs.GetString("nombre", "carlos") +".";
    }

    public void ccomprainmo()
    {
        MENSAJEIN.SetActive(false);
    }



    void Start()
    {
        a = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>(); 
        inmo.text = "TE QUEDAN " + PlayerPrefs.GetFloat("inmortal", 0);


        if(PlayerPrefs.GetFloat("inmortal", 0) > 0) imagenimortalidad.SetActive(true);

        if (PlayerPrefs.GetInt("r1", 0) == 1) rend.material = m1;
        if (PlayerPrefs.GetInt("r2", 0) == 1) rend.material = m2;
        if (PlayerPrefs.GetInt("r3", 0) == 1) rend.material = m3;
        if (PlayerPrefs.GetInt("r4", 0) == 1) rend.material = m4;
    }

    

    public void PlayFail() => a.PlayOneShot(fail);

    public void inmotal()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > 999999)
        {
            tor();
            comprainmortalidad();
            imagenimortalidad.SetActive(true);
            a.clip = com;
            a.Play();
            PlayerPrefs.SetFloat("inmortal", 10);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 1000000);
            
        }
        else PlayFail();
    }


    public void R1()
    {
            tor();
            a.clip = com;
            a.Play();
            PlayerPrefs.SetInt("r1", 1);
            PlayerPrefs.SetInt("r2", 0);
            PlayerPrefs.SetInt("r3", 0);
            PlayerPrefs.SetInt("r4", 0);
            
            rend.material = m1;
    }
    public void R2()
    {
            tor();
            a.clip = com;
            a.Play();
            PlayerPrefs.SetInt("r1", 0);
            PlayerPrefs.SetInt("r2", 1);
            PlayerPrefs.SetInt("r3", 0);
            PlayerPrefs.SetInt("r4", 0); 
            rend.material = m2;
    }
    public void R3()
    {
            tor();
            a.clip = com;
            a.Play();
            PlayerPrefs.SetInt("r1", 0);
            PlayerPrefs.SetInt("r2", 0);
            PlayerPrefs.SetInt("r3", 1);
            PlayerPrefs.SetInt("r4", 0); 
            rend.material = m3;
    }
    public void r4()
    {
            tor();
            a.clip = com;
            a.Play();
            PlayerPrefs.SetInt("r1", 0);
            PlayerPrefs.SetInt("r2", 0);
            PlayerPrefs.SetInt("r3", 0);
            PlayerPrefs.SetInt("r4", 1); 
            rend.material = m4;
    }

    public void MENU()

    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }

}
