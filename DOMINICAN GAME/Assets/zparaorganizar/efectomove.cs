using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectomove : MonoBehaviour
{
    public Transform p1;
    public float v = -3;
    public float pos = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(v* Time.deltaTime, 0, 0);
        if(transform.position.x < pos)
        {
            transform.position = p1.transform.position;
        }

    }
}
