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
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ga.transform.localScale = new Vector3(-ga.transform.localScale.x, ga.transform.localScale.y, ga.transform.localScale.z);
            m.velocidad *= -1;
            
        }
        

     
    }

 
}
