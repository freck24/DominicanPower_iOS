using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPatronMaker : MonoBehaviour
{

    public List<Transform> GenerarDineros;
    public GameObject Gen;

    void Start()
    {
        for (int i = 0; i < GenerarDineros.Count; i++)
        {
            Instantiate(Gen, GenerarDineros[i].position, Quaternion.identity).transform.SetParent(transform);
        }    
    }

}
