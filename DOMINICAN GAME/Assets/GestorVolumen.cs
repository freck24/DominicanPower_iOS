using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorVolumen : MonoBehaviour
{
  
    public GameObject AudioOn;
    public GameObject AudioOff;
    

    [Header("Modifier")]
    public int Volumen;
    public bool VolumenBool;

    void ManageSprite()
    {
        AudioOn.SetActive(VolumenBool);
    AudioOff.SetActive(!VolumenBool);
    }
    public void GetActual()
    {
        Volumen = PlayerPrefs.GetInt("GameVolume", 1);
        VolumenBool = (Volumen == 1);
        ManageSprite();

    }

    public void Switch()
    {
        VolumenBool = !VolumenBool;
        Volumen = (VolumenBool ? 1 : 0);
        AudioListener.volume = Volumen;
        PlayerPrefs.SetInt("GameVolume", Volumen);
        ManageSprite();

    }
}
