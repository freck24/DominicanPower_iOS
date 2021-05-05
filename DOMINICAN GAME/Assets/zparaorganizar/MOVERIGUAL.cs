using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVERIGUAL : MonoBehaviour
{
    public float velocidadpoli = 20f;
    Vector3 x = Vector3.left;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += x * velocidadpoli * Time.deltaTime;
    }


    void OnTriggerEnter2D(Collider2D otr)
    {
        if (otr.gameObject.tag == "destroy" || otr.gameObject.tag == "poli")
        {

            Destroy(gameObject);

        }
    }
    }
