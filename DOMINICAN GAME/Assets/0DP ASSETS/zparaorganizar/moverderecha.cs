using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverderecha : MonoBehaviour
{
    Vector3 x = Vector3.left;
    public float velocidadmoto = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += x * velocidadmoto * Time.deltaTime;
    }
}
