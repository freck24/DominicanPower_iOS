using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin3D : MonoBehaviour
{
    public int Valor;
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + Valor);

    }
}
