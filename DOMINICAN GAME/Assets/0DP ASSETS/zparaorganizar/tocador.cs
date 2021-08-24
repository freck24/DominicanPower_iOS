using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocador : MonoBehaviour
{
    public GameObject yo;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject ene;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "magnate")
        {
            Instantiate(ene,transform.position, Quaternion.identity);
            Destroy(yo.gameObject);
        }
    }
}
