using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectaplayer : MonoBehaviour
{
    public Transform ga;
    public GameObject gallina;
    public codigogallina m;
    public bool sal = false;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //    transform.position = ga.transform.position;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ga.transform.localScale = new Vector3(-ga.transform.localScale.x, ga.transform.localScale.y, ga.transform.localScale.z);
            m.velocidad *= -1;
            
        }
        

     
    }

 
}
