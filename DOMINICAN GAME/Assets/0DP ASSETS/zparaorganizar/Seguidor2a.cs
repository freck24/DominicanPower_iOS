using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor2a : MonoBehaviour
{

    public bool estoyena2 = false;
    public bool estoyena22 = false;
    public bool desviador = true;
    public bool sigue1 = true;
    public bool sigue2 = false;
    
    public GameObject perder;
    public enemigomujer en;
    public GameObject humito;
    public TIMER timer;
    IEnumerator perdercoru()
    {
        humito.SetActive(true);
        timer.corriendo = false;
        yield return new WaitForSecondsRealtime(1f);
        
        perder.SetActive(true);

    }
    public bool UNA = true;



    public Transform jugador;
    public Transform jugador2;
    UnityEngine.AI.NavMeshAgent enemigo;
    public bool dentro;
    // Start is called before the first frame update
    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    public GameObject botones;
    public player1 P1;
    public player2 P2;


    void OnTriggerEnter(Collider otr)
    {
        if (otr.gameObject.tag == "pld")
        {

            dentro = true;
            //  botones.SetActive(false);
            P1.velocidad = 0;
            P2.velocidad = 0;
            StartCoroutine(perdercoru());

            UNA = false;
        }

        if (otr.gameObject.tag == "cerca1")
        {
            sigue1 = true;
            sigue2 = false;
        }
         if (otr.gameObject.tag == "cerca2")
        {
            sigue2 = true;
            sigue1 = false;
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
        if (sigue1 && estoyena2)
        {

            enemigo.destination = jugador.position;
            en.objet = jugador;
        }


        else if (sigue2 && estoyena22)
        {
            enemigo.destination = jugador2.position;
            en.objet = jugador2;
        }
    



        if (dentro)
        {
            enemigo.destination = this.transform.position;

        }
    }
}
