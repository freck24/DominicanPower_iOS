using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminadorgallinas : MonoBehaviour
{
    
    public GameObject gallina;
  
    public bool sal = false;
    public float time = 0;
    

    void Update()
    {
        if (time > 3)
        {
            Destroy(gallina.gameObject);
            PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) - 1);
        }

        if (time < 4 && sal)
        {
            time += Time.deltaTime;
        }
        //    transform.position = ga.transform.position;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sal = false;
            time = 0;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sal = true;
        }
    }
}

