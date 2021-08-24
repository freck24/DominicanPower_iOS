using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movimiento1 : MonoBehaviour
{
    public GameObject manita;
    Rigidbody rb;
    public float velocidad;
    public Vector3 v;
    public float relativo;

    public Animator player1anim;
    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetFloat("pyun", 0) == 0)
        {
            manita.SetActive(true);
        }
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        relativo = v.x * v.x + v.z * v.z;
        if (relativo > 30)
        {
            player1anim.SetBool("corre", true);

        }
        else if (relativo > 5)
        {
            player1anim.SetBool("camina", true);
            player1anim.SetBool("corre", false);
        }
        else
        {
            player1anim.SetBool("corre", false);
            player1anim.SetBool("camina", false);
        }
        float movh = CrossPlatformInputManager.GetAxis("Horizontal") * velocidad;
        float movv = CrossPlatformInputManager.GetAxis("Vertical") * velocidad;
        rb.AddForce(movh, 0, movv);
        if (movh != 0)
        {
            PlayerPrefs.GetFloat("pyun", 1);
        }
    }
}
