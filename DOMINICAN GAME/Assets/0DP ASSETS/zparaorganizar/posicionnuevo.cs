using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicionnuevo : MonoBehaviour
{
    Vector3 a;
    public Transform player;

    public bool suelito = true;
    // Start is called before the first frame update
    void Start()
    {
        a = transform.position;
        transform.position = new Vector3(transform.position.x, a.y, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (suelito && player.transform.position.y >= a.y)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        }
        else if(suelito)
        {
            transform.position = new Vector3(player.transform.position.x, a.y, transform.position.z);
        }
    }
}
