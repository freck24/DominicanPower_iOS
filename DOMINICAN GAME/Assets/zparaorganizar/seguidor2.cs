using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor2 : MonoBehaviour
{

    public bool estoyena2 = false;
    public bool desviador = true;


    public Transform jugador;
    UnityEngine.AI.NavMeshAgent enemigo;
    public bool dentro;
    // Start is called before the first frame update
    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }




    void OnTriggerEnter(Collider otr)
    {
        if (otr.gameObject.tag == "pld")
        {
            dentro = true;

        }
    }

    void OnTriggerExit(Collider otr)
    {
        if (otr.gameObject.tag == "pld")
        {
            dentro = false;
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (!dentro && estoyena2)
        {
            enemigo.destination = jugador.position;


        }
        if (dentro && estoyena2 || !estoyena2)
        {
            enemigo.destination = this.transform.position;

        }
    }
}
