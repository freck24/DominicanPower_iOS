using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volverajgar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject cargando;

    IEnumerator cargar()
    {
      
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("nivel1");
    }    
    public void seguir()

    {
        Time.timeScale = 1;
        cargando.SetActive(true);
        StartCoroutine(cargar());
}
}