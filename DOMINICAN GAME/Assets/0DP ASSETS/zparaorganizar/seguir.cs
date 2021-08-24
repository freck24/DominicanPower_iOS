using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour
{
    public Transform playe;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(playe.transform.position.x+2, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = playe.transform.position;
       // s();
    }

    public void s()
    {
        transform.position = new Vector3(playe.transform.position.x+2, transform.position.y, transform.position.z);
    }
}
