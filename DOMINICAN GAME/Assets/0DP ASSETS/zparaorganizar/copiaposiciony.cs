using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copiaposiciony : MonoBehaviour
{
    public mision1 m1;
    public Transform b;    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) < 65000 && m1.n<65000)
        {
            transform.position = new Vector3(transform.position.x, b.transform.position.y, transform.position.z);
        }
    }
}
