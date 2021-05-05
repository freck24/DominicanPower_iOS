using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miracamara : MonoBehaviour
{
    public Transform camara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camara.transform.position);
    }
}
