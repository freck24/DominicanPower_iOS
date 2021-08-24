using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vayven : MonoBehaviour
{public bool sube = true;
    public bool baja = false;
    public float a;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { 

        if(sube){
            transform.Rotate(0, 1, 0);
        } else
        {
            transform.Rotate(0, -1, 0);
        }


        a = transform.rotation.x;

     if (transform.rotation.x < -0.2)
        {
            sube = false;
        }if (transform.rotation.x > 0.2f)
        {
            sube = true;
        }
    }
}
