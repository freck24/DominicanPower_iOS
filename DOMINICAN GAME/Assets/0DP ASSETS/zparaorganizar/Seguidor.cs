using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour
{

    public bool estoyena1= false;
    public bool en1estoyp2= false;
    public bool sigue1= false;
    public bool sigue2= false;
    public GameObject perder;
  

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

    public bool UNA = true;

    public GameObject humito;
    public player1 P1;
    public player2 P2;

    IEnumerator perdercoru()
    {
        humito.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 0f;
        perder.SetActive(true);

    }
    void OnTriggerEnter(Collider otr)
    {
         if(otr.gameObject.tag == "pld" && UNA)
        {
            P1.velocidad = 0;
            P2.velocidad = 0;
            //botones.SetActive(false);
            dentro = true;
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
            dentro = false;        }
    }

    public enemigomujer en;

    // Update is called once per frame
    void Update()
    {
        if (!dentro)
        {
          //  transform.LookAt(enemigo.destination);
            if (sigue1 && estoyena1)
            {

                enemigo.destination = jugador.position;
                en.objet = jugador;

            } else if (sigue2 && en1estoyp2)
           
            
            {
                enemigo.destination = jugador2.position;
                en.objet = jugador2;
            }

        }
        
        
        
        if (dentro)
        {
            enemigo.destination = this.transform.position;

        }
    }
}
