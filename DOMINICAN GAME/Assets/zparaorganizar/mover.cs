using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float velocidad = -10;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        velocidad = PlayerPrefs.GetFloat("velocidad1", -3);
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "destroy")
        {
            Destroy(gameObject);
        }
    }
}
