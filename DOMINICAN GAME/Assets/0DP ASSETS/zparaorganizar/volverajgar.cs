using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volverajgar : MonoBehaviour
{
    
    public GameObject cargando;

    IEnumerator cargar()
    {
      
        yield return new WaitForSecondsRealtime(1f);
        PreLoaderLevel.preload.CargaLvl("inicio");

    }
    public void seguir()

    {
        Time.timeScale = 1;
        PreLoaderLevel.preload.CargaLvl("LEVEL 1 CLONE");

        StartCoroutine(cargar());
}
}