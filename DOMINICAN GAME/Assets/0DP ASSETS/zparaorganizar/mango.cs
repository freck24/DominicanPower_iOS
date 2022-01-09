using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mango : MonoBehaviour
{
    public controler con;
    public GameObject Fx;
    public AudioClip MangoFx;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "Player")
        {
            controler.statico.audio2.PlayOneShot(MangoFx);

            Destroy(gameObject);
            Instantiate(Fx, transform.position, Quaternion.identity);
            PlayerPrefs.SetFloat("mango", PlayerPrefs.GetFloat("mango", 0) + 1);
            // con.g = con.platano;
        }
    }
}
