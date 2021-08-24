using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siguientenivel : MonoBehaviour
{
    public bool adelante = false;
    public bool siguientepiedra = false;
    public float velocidad = 10f;
    public Transform objetivo;
    public controlartrucano cont;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (adelante && siguientepiedra)
        {
            transform.Translate(new Vector3(0, 0, velocidad));
        }
    }


    private void OnTriggerEnter(Collider other)
    { 


        if (other.tag == "walk")
        {
            objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
            transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
            adelante = false;
        }
    }
}
