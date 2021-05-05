using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Cinemachine;

public class VIBRA : MonoBehaviour
{ public bool v = false;
   // CinemachineImpulseSource i;
    // Start is called before the first frame update
    void Start()
    {
       // i = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (v)
        {
          
            v = false;
         //   i.GenerateImpulse();
        }
    }







}
