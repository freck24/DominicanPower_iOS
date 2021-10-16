using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneEli : MonoBehaviour
{

    public GameObject Obj;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Crear", 0.4f);
    }

  

    void Crear()
    {
        Instantiate(Obj);
    }
}
