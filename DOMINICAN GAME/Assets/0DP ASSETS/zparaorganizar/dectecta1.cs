using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dectecta1 : MonoBehaviour
{
    public GameObject ene;
    public GameObject block;
    public Transform blocktransfor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "cabezap")
        {
            Instantiate(ene, blocktransfor.transform.position, Quaternion.identity);
            CameraPlay.DropWater(CameraPlay.PosScreenX(transform.position), CameraPlay.PosScreenY(transform.position), 0.52f, 0.2f);
            CameraPlay.EarthQuakeShake(0.5f, 2.1f, 1.4f);

            Destroy(block);

        }
    }
}
