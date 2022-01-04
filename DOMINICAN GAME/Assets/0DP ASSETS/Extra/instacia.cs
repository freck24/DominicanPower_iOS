using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instacia : MonoBehaviour
{
    public GameObject ene;
    public string nombretag;
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
        {
            if (collision.tag == nombretag)
            {
                CameraPlay.Shockwave(CameraPlay.PosScreenX(transform.position), CameraPlay.PosScreenY(transform.position), 0.52f, 0.2f);
                Instantiate(ene, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}

