using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetroManager : MonoBehaviour
{
    public Animator anm;
    public bool PuedeIrse;
    public bool PlayerDentroMetro;
    public Transform PlayerCheck;
    public float RadioCheck;
    public LayerMask PlayerLayer;

    public AudioSource Sou;
    public AudioClip MetroAlarm;

    [Header("Objetos")]
    public GameObject Camino;
    public GameObject Paredes;

    private void Start()
    {
        InvokeRepeating("SendSignal", 1f, 17f);
    }
    public void Sonar_Alarma() => Sou.PlayOneShot(MetroAlarm);


    public void SendSignal() => anm.SetTrigger("Send");


    public void Activar_Paredes(int Value) => Paredes.SetActive(Value == 1);
    public void Activar_Camino(int Value) => Camino.SetActive(Value == 1);


    public void ChangePuedeIrse(int Value)
    {
        PuedeIrse = Value == 1;
    }

    public void FixedUpdate()
    {
        PlayerDentroMetro = Physics2D.OverlapCircle(PlayerCheck.position, RadioCheck, PlayerLayer);
        anm.SetBool("PlayerDentroMetro", PlayerDentroMetro);
    }
}
