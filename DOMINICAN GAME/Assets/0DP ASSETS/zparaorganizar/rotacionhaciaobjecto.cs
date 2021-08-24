using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionhaciaobjecto : MonoBehaviour
{
    public Transform objeto;
    Vector3 h;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = new Vector3(objeto.transform.position.z,objeto.transform.position.x,objeto.transform.position.y);
        transform.LookAt(objeto);
    }
}
