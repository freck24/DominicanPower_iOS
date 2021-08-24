using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CONTUNUAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DALE());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void saltar()
    {
        pantalladecarga.SetActive(true);
    }


    public GameObject pantalladecarga;
    public IEnumerator DALE()
    {
        yield return new WaitForSecondsRealtime(15);
        pantalladecarga.SetActive(true);
    }
}
