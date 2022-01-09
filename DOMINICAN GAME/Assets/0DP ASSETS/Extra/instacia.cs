using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instacia : MonoBehaviour
{
    public GameObject ene;
    public string nombretag;
    public AudioClip Fx;
    public bool PlayFx;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.tag == nombretag)
            {

                if (PlayFx) controler.statico.audio2.PlayOneShot(Fx);
          //      CameraPlay.Shockwave(CameraPlay.PosScreenX(transform.position), CameraPlay.PosScreenY(transform.position), 0.52f, 0.2f);
                Instantiate(ene, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}

