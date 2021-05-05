using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientocamara : MonoBehaviour
{
    public bool sigue = false;
    public float velocidad = 10;
    Vector3 a1;
    Vector3 b;
    Vector3 bc;
    public Transform p1;
    public Transform p2;
    public Transform p3;
    public Transform p4;
    public Transform p5;
    public GETOR gestor;
        // Start is called before the first frame update
    void Start()
    {
        a1 = transform.position;
        bc = new Vector3(transform.position.x, 2.4f, -17);
    }

    // Update is called once per frame
    void Update()
    {
        if (gestor.numero == 1)
        {
            b = new Vector3(p1.transform.position.x, bc.y, bc.z);
        }  if (gestor.numero == 2)
        {
            b = new Vector3(p2.transform.position.x, bc.y, bc.z);
        } if (gestor.numero == 3)
        {
            b = new Vector3(p3.transform.position.x, bc.y, bc.z);
        } if (gestor.numero == 4)
        {
            b = new Vector3(p4.transform.position.x, bc.y, bc.z);
        } if (gestor.numero == 5)
        {
            b = new Vector3(p5.transform.position.x, bc.y, bc.z);
        }



        if (sigue)
        {
            transform.position = Vector3.Lerp(transform.position, b, velocidad * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position,a1, velocidad * Time.deltaTime);
        }

    }
}
