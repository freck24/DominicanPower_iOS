using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminatodo : MonoBehaviour
{
    public GameObject eli;
    public PUNTOSDOMINICANLEVEL o;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<camarasigue>().PosicionXmaxima = transform.position.x;

        Vector3 localpos = transform.localPosition;

        localpos.y = -7.959991f;
     //   localpos.x = -3.68f;
        localpos.z = -17.51398f;

        transform.localPosition = localpos;
    }

     
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Player")
        {
            eli.SetActive(true);
            o.punto = true;
        }
    }
}
