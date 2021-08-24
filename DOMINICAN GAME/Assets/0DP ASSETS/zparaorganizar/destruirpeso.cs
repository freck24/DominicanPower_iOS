using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirpeso : MonoBehaviour
{
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
            Destroy(gameObject);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 5);
        }
    }
}
