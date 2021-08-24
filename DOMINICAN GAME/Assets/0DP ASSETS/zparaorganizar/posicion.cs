using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicion : MonoBehaviour
{
    Vector3 a;


    public bool suelito = true;
    // Start is called before the first frame update
    void Start()
    {
        a = transform.position;
      

    }

    // Update is called once per frame
    void Update()
    {
    
        
            transform.position = new Vector3(transform.position.x, a.y, transform.position.z);
          
        }
    
}
