using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETACTIVE : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject OBJETO;
    public GameObject OBJETO2;
    void Start()
    {
        
    }
    public void Activar()
    {
        OBJETO.SetActive(true);

    }
       public void Activar2()
    {
        OBJETO2.SetActive(true);

    }

    public void CargaNivel()
    {
        PreLoaderLevel.preload.CargaLvl("");

    }


    public void DEActivar()
    {
        OBJETO.SetActive(false);

    }  public void DEActivar2()
    {
        OBJETO2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
