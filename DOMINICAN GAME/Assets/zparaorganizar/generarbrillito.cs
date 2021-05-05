using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generarbrillito : MonoBehaviour
{
    Vector3 h;
    public GameObject ene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Instantiate(ene, transform.position, Quaternion.identity);
        }
    }
    

}
