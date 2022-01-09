using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nombre : MonoBehaviour
{

    public Font fuente;
    public string nombr = "";
    public GameObject stupido;
    public Text n;
    public Button BotonAceptar;
    public GameObject AnimEnter;
    public GameObject Grounder;

    public float p1;

    void Start()
    {
        p1 = PlayerPrefs.GetFloat("p1", 0);
        if (p1 == 1)
        {
            Grounder.SetActive(true);
            Invoke("LoadMenu", 0.4f);
        }
    }

    void LoadMenu()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }

    void Update()
    {
        nombr = n.text;

        AnimEnter.SetActive(nombr != "" && nombr.Length > 3);
        BotonAceptar.interactable = (nombr != "" && nombr.Length > 3);
    }



    public void seguir()
    {
            if (nombr == "" || nombr.Length < 3)
            {
                stupido.SetActive(true);
            }
            else
            {
                print("Nombre Bien, Cargando Intro...");
                PlayerPrefs.SetString("nombre", nombr);
                PreLoaderLevel.preload.CargaLvl("introa");
            }
    }

}


