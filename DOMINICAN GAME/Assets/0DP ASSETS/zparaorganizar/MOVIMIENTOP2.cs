using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MOVIMIENTOP2 : MonoBehaviour
{
    Rigidbody rb;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movh =CrossPlatformInputManager.GetAxis("Horizontal2") * velocidad;
        float movv = CrossPlatformInputManager.GetAxis("Vertical2") * velocidad;
      
        rb.AddForce(movh, 0, movv);
    }
}
