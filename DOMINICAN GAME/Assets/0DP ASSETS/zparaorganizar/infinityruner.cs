using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinityruner : MonoBehaviour
{
    public Transform homologo;
    public float velocidad=-10;
    public float distanciamaxima= 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(velocidad*Time.deltaTime, 0, 0);
        if (transform.position.x <  - distanciamaxima)
        {
            transform.position = homologo.transform.position;
        }
    }
}
