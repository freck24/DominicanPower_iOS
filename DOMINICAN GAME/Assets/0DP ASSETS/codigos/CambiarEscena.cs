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
        transform.SetParent(null);
        ScreenLoader.scena = NombreEscenas[id];
        ScreenLoader.gameObject.SetActive(true);

        if (id == 2) ScreenLoader.isnivelactualsiguiente = true;

        if (id == 3) SceneManager.LoadSceneAsync("LEVEL 1 CLONE");


        if(DestruirGrupo != null)DestroyImmediate(DestruirGrupo);
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
