using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elimi : MonoBehaviour
{
    public GameObject ene;
    public GameObject galli;
   
    
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



        if (collision.tag == "ganar2")
        {
            Destroy(galli.gameObject);
            Instantiate(ene, transform.position, Quaternion.identity);
            Instantiate(ene, transform.position, Quaternion.identity);
            Instantiate(ene, transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) - 1);
           

        }
    }
}
