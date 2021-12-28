using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CREDI : MonoBehaviour
{
    public Text NAME;
    public GameObject c;
    // Start is called before the first frame update
    void Start()
    {
        NAME.text = PlayerPrefs.GetString("nombre", "Tu");
        StartCoroutine(cr());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MENU()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");
    }

    public void juga9()
    {
        PreLoaderLevel.preload.CargaLvl("nivel86");
    }
     
    IEnumerator cr()
    {
        yield return new WaitForSecondsRealtime(3f);
        c.SetActive(true);
    }
}
