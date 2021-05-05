using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEMUEVEDEDOSPUNTOS : MonoBehaviour
{
    public float v =5;
    public Transform a;
    public Transform b;
    public bool ab = true;
    public bool ba = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(v * Time.deltaTime, 0, 0);
        //if (unavez)
        {
            if (transform.position.x < a.transform.position.x && ba )
            {
                v *= -1;
                ab = true;
                ba = false;
            }


            if(transform.position.x > b.transform.position.x && ab)
            {
                v *= -1;
                ba = true;
                ab = false;
            }

        }
}
        
}
