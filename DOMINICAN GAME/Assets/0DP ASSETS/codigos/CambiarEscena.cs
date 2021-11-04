using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using EMGame;

public class CambiarEscena : MonoBehaviour{

    public GameObject DestruirGrupo;
    public PreLoaderLevel ScreenLoader;
    public List<string> NombreEscenas;

    public Escenas cargarEscena;

public void cargares()
    {
      
            PantallaDeCarga.Instancia.CargarEscena(cargarEscena.ToString());
     
    }

    public void NewCargaID(int id)
    {

        if (id == 2 || id == 3)
        {
            FindObjectOfType<GESTORPRINCIPAL>().siguientenivel();
        }

        if (id == 0 && PlayerPrefs.GetInt("anuncios", 1) == 1)
        {
            int ran = Random.Range(0, 2);
           if(ran == 0) scriptEjemploVR.instance.Mostrar_Intersticial();
           if(ran == 1) scriptEjemploVR.instance.Mostrar_Video();
        }

        transform.SetParent(null);

        if(id < 3)
        ScreenLoader.scena = NombreEscenas[id];

        ScreenLoader.gameObject.SetActive(true);

        if (id == 2) ScreenLoader.isnivelactualsiguiente = true;

        if (id == 3) ScreenLoader.CargaAutomatica = true;
        if (id == 3) ScreenLoader.isnivelactualsiguiente = true;
        if (id == 3) SceneManager.LoadSceneAsync("LEVEL 1 CLONE");


        if(DestruirGrupo != null)DestroyImmediate(DestruirGrupo);

        if (FindObjectOfType<controler>() != null && PlayerPrefs.GetInt("anuncios", 1) == 1)
        {
            Destroy(FindObjectOfType<controler>());
            scriptEjemploVR.instance.Mostrar_Intersticial();
        }
    }

}

public enum Escenas
{
    LevelPlayer,
    inicio,
    colmado,
    intro,
    telefono
}
