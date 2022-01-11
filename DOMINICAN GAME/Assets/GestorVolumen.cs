using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorVolumen : MonoBehaviour
{
    public string Prefs = "GameVolume";
    public GameObject AudioOn;
    public GameObject AudioOff;
    

    [Header("Modifier")]
    public int Volumen;
    public bool VolumenBool;


    private void Start()
    {
        GetActual();
    }
    void ManageSprite()
    {
    AudioOn.SetActive(VolumenBool);
    AudioOff.SetActive(!VolumenBool);
    }
    public void GetActual()
    {
        Volumen = PlayerPrefs.GetInt(Prefs, 1);
        VolumenBool = (Volumen == 1);
        ManageSprite();

    }

    public void Switch()
    {
        VolumenBool = !VolumenBool;
        Volumen = (VolumenBool ? 1 : 0);
        if(Prefs == "GameVolume") AudioListener.volume = Volumen;
        PlayerPrefs.SetInt(Prefs, Volumen);
        ManageSprite();

    }
}
