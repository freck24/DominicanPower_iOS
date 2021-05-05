using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bomba : MonoBehaviour
{
    public float tiempo = 30;
    public GameObject explota;
    //public Text t;
   // public TextMesh t;
    public TextMeshPro t;// Start is called before the first frame update
    void Start()
    {
        tiempo = 30;
        llave = false;
    }
    public bool llave = false;
    // Update is called once per frame
    void Update()
    { tiempo -= Time.deltaTime;

        if (tiempo > 0)
        {
            t.text = tiempo.ToString("f0");
        }
        if (tiempo < 0 && !llave)
        {
            explota.SetActive(true);
          
        }

        if (tiempo < -0.5f)
        {
            gameObject.SetActive(false);
        }
        if (tiempo > 0)
        {
            explota.SetActive(false);
        } 
    }



    public void llav()
    {
        tiempo = 30;
        llave = true;
        gameObject.SetActive(false);
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ministerio")
        {
            tiempo = 0;
            explota.SetActive(true);

        }

      
        }
    }




