using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buscar : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject respawn;
    void Start()
    {
        if (respawn == null)
            respawn = GameObject.FindWithTag("Player");

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(respawn.transform.position.x, respawn.transform.position.y+2, transform.position.z) ;
    }
}
