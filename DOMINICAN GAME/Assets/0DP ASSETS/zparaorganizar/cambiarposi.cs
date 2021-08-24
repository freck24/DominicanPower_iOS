using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cambiarposi : MonoBehaviour
{
    public Transform objetivo;
    public bool adelante = false;
    public float velocidad;
    Vector3 po;
    // Start is called before the first frame update
    void Start()
    {
        po = transform.position;

        transform.LookAt(new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z));
    }

    // Update is called once per frame
    void Update()
    {

        if (adelante)
        {
            transform.Translate(new Vector3(0, 0, velocidad));
        }
        else
        {
            StartCoroutine(restablecer());
        }

      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "arriba")
        {
            objetivo = other.gameObject.GetComponent<siguientepunto>().siguiente;
            transform.LookAt(new Vector3(objetivo.position.x, transform.position.y,objetivo.position.z));
            adelante = false;
           
        }
    }

    public void di()
    {
        adelante = true;

    }


  public IEnumerator restablecer()
    {
        transform.position = po;
        yield return new WaitForSeconds(2f);
    }
}