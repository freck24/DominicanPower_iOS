﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nivel : MonoBehaviour
{
  
    public GameObject cargando;
    public GameObject NOHA;
    public Sprite completo;
    public AudioClip enter;
    public AudioClip fail;
    public AudioSource AudioFx;

    public Transform NivelesContent;

    public List<Transform> NivelesSlot;

    public void TestAd()
    {
    scriptEjemploVR.instance.Mostrar_Video();
    }
    public void TestAd2()
    {
    scriptEjemploVR.instance.Mostrar_Intersticial();
    }

    // Start is called before the first frame update
   
    public void CheckPlay(int LevelNewer)
    {

        if ( PlayerPrefs.GetFloat("nivel")> LevelNewer)
        {
            // ESTE NIVEL SE VA ABRIR
            PlayerPrefs.SetFloat("jn", LevelNewer);

            if (cargando != null) cargando.SetActive(true);
            if (NOHA != null) NOHA.SetActive(false);
            AudioFx.PlayOneShot(enter);

            GetComponent<inicietion>().Boton_IniciarSaltado(LevelNewer + 1);
        }
        else
        {
            // ESTE NIVEL ESTA BLOQUEADO BEBE
            PlayerPrefs.SetFloat("jn", LevelNewer);
            AudioFx.PlayOneShot(fail);
            if(NOHA != null) NOHA.SetActive(false);
            if (NOHA != null) NOHA.SetActive(true);
            if (cargando != null) cargando.SetActive(false);
        }
    }
   
}
