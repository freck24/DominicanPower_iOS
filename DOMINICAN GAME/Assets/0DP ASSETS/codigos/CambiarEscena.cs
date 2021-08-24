using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CambiarEscena : MonoBehaviour{

    public Escenas cargarEscena;

public void cargares()
    {
     
        {
            PantallaDeCarga.Instancia.CargarEscena(cargarEscena.ToString());
        }
    }

}

public enum Escenas
{
    nivel1,
    inicio,
    colmado,
    intro,
    telefono
}
