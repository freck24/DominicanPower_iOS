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
        ScreenLoader.scena = NombreEscenas[id];
        ScreenLoader.gameObject.SetActive(true);


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
