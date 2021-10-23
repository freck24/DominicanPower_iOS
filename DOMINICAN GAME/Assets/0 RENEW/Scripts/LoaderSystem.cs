using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class LoaderSystem : MonoBehaviour
{

    public static LoaderSystem system;

    public int NivelActual;
    public bool Test;

    public List<GameObject> Niveles;
    public List<string> NivelesEnString;
    public Transform ContentLevel;

    public ResourceRequest req;

    public Animator EspereObj;
    public GameObject Player;


    public void CargarNivel()
    {
        Invoke("CargarNivel2", 1f);

    }

    public void CargarNivel2()
    {
        //       Instantiate(Niveles[NivelActual], ContentLevel);
        req = Resources.LoadAsync<GameObject>("NivelesPrefab/" + NivelesEnString[NivelActual]);
        //  GameObject Objeto = Resources.LoadAsync<GameObject>("NivelesPrefab/" + NivelesEnString[NivelActual]);

        StartCoroutine(CheckLoadLevel());


    }


    public IEnumerator CheckLoadLevel()
    {
        while(!req.isDone)
        {
            print("CARGANDO LEVEL: " + req.progress);

            yield return new WaitForSeconds(0.3f);
        }

        print("NIVEL CARGADO, SE INSTANCIARA");
        EspereObj.SetBool("termino", true);
        Instantiate(req.asset, ContentLevel);

        Player.GetComponent<controler>().CallThemBug();
        Player.GetComponent<Rigidbody2D>().simulated = true;

        yield return null;
    }

    void Awake()
    {

        for (int i = 0; i < Niveles.Count; i++)
        {
            NivelesEnString.Add(Niveles[i].name);
        }


        system = this;

        if (!Test)
        {

            if(PlayerPrefs.GetInt("NivelSaltado", 0) == 1)
            {
                NivelActual = Convert.ToInt32(PlayerPrefs.GetFloat("NivelSaltado_ID", 0f));
                print("Nivel Saltado");
                return;
            }

            NivelActual = Convert.ToInt32(PlayerPrefs.GetFloat("nivel", 1f));

        }
    }


}
