using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBOMAGICO : MonoBehaviour
{
    public bool amarillo;
    public bool rojo;
    public bool verde;
    public bool rosa;
    public bool azul;
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
        if (collision.tag == "Player")
        {
            Destroy(gameObject);



            if (amarillo)
            {


                PlayerPrefs.SetFloat("cuboa", PlayerPrefs.GetFloat("cuboa", 0) + 1);
            } else if (rojo)
            {


                PlayerPrefs.SetFloat("cubor", PlayerPrefs.GetFloat("cubor", 0) + 1);
            } else if (verde)
            {


                PlayerPrefs.SetFloat("cubov", PlayerPrefs.GetFloat("cubov", 0) + 1);
            } else if (rosa)
            {


                PlayerPrefs.SetFloat("cuboro", PlayerPrefs.GetFloat("cuboro", 0) + 1);
            } else if (azul)
            {


                PlayerPrefs.SetFloat("cuboaz", PlayerPrefs.GetFloat("cuboaz", 0) + 1);
            } 


            if(PlayerPrefs.GetFloat("cuboa", 0)>0 && PlayerPrefs.GetFloat("cubor", 0)>0 && PlayerPrefs.GetFloat("cubov", 0)>0 && PlayerPrefs.GetFloat("cuboro", 0)>0&& PlayerPrefs.GetFloat("cuboaz", 0) > 0)
            {
                PlayerPrefs.SetFloat("cubosm", 1);
            }

        }
    }
}
