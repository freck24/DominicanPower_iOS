using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generarbilletes : MonoBehaviour
{
    Vector3 h;
    public GameObject cuarto;
    public generarbilletes g;
    void Start()
    {
        crearbille();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool ini=true;
    public void crearbille()
    {
        if (ini)
        {
            g.crearbille();

            h = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(cuarto, h, Quaternion.identity);
        }
    }
        

}
