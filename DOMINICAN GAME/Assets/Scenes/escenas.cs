using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escenas : MonoBehaviour
{
    // Start is called before the first frame update
    public bool usuario = false;
 

    

    IEnumerator carga()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync("segunda 1");
        Debug.Log("Loading complete");
        while (usuario == false)
        {
            yield return new WaitForSecondsRealtime(1);
            Debug.Log("esperando");
           
           // if(usuario)
          //  yield return async;
        }

       
    }

    public void cambiar()
    {
        usuario = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

     void Start()
    {
        StartCoroutine(carga());
        
    }

   





}
