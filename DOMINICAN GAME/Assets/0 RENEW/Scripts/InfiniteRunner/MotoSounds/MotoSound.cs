using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoSound : MonoBehaviour
{
    public static MotoSound ms;

    public AudioSource sou;
    public AudioClip EncenderMoto;
    public AudioClip MotoNoIniciada_Loop;
    public AudioClip ArrancarMoto;

    public AudioClip Cambio1;
    public AudioClip Cambio2;
    public AudioClip Cambio3;
    public AudioClip Cambio4;
    public AudioClip TiroDeCambio;



    public int State;
    // 0 moto apagada
    // 1 moto encendida pero no esta jugando
    // 2 arrancando moto (jugador dio jugar);

    private void Start()
    {
        ms = this;  
        sou.clip = EncenderMoto;
        sou.Play();
    }

    void Update()
    {
    if(State == 0 && !sou.isPlaying)
    Change(MotoNoIniciada_Loop, true, 1);

    }

    public void Change(AudioClip clip, bool LoopingMode, int NewID_State)
    {
        sou.clip = clip;
        sou.loop = LoopingMode;
        State = NewID_State;
        sou.Stop();
        sou.Play();
    }

   
}
