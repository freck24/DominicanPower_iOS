using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dectecta1 : MonoBehaviour
{
    public GameObject ene;
    public GameObject block;
    public Transform blocktransfor;
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
        if(collision.tag == "cabezap")
        {
            Instantiate(ene, blocktransfor.transform.position, Quaternion.identity);
            Destroy(block);

        }
    }
}
