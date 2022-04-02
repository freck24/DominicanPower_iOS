using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class IniciadorAnuncios : MonoBehaviour
{
    public static IniciadorAnuncios stat;
    public bool Iniciado;

    // Start is called before the first frame update
    void Start()
    {
        if (stat != null) DestroyImmediate(gameObject);

        stat = this;
        DontDestroyOnLoad(gameObject);

        Iniciar();
    }

    // Update is called once per frame
    void Iniciar()
    {
    //    MobileAds.Initialize(initStatus =>
       // {
           // Debug.Log("Ads iniciados " + initStatus);
          //  llamar();
      //  });

        Iniciado = true;

    }
}
