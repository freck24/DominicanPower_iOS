using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableContinue : MonoBehaviour
{
    public GameObject ToDisable;
   

    void Start()
    {
        if (PlayerPrefs.GetInt("PlayingGame", 0) == 1)
        {
        if (PlayerPrefs.GetInt("anuncios", 1) == 1)
            {
                int ran = Random.Range(0, 2);
                if (ran == 0) scriptEjemploVR.instance.Mostrar_Intersticial();
                if (ran == 1) scriptEjemploVR.instance.Mostrar_Video();
            }

        ToDisable.SetActive(false);
        }
    }


}
