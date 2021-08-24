using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOUSERANDON : MonoBehaviour
{
    public GameObject[] casas;
    public int numero = 0;
    public int numeromax = 15;
    // Start is called before the first frame update
    void Start()
    {
        numeromax = casas.Length;

        numero = Random.Range(0, casas.Length+1);
        if(numero>= casas.Length)
        {
            numero = 0;
        }
        casas[numero].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
