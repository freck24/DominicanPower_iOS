using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elimi : MonoBehaviour
{
    public GameObject ene;
    public GameObject galli;
   
  

    public void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.tag == "ganar2")
        {
            print("GallinaKill: " + collision.name);
            collision.name = "@@@@@@@@@@@@@ganar2";
            Destroy(galli.gameObject);
            Instantiate(ene, transform.position, Quaternion.identity);
            Instantiate(ene, transform.position, Quaternion.identity);
            Instantiate(ene, transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) - 1);
           

        }
    }
}
