using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MiniMsjManager : MonoBehaviour
{
    [Header("Informacion")]
    public string Info;
    [Multiline(4)] public string Descripcion;
    public UnityEvent evento;

    [Header("Asignacion")]
    public Text InfoTx;
    public Text DescTx;


    public void CallBack() => evento.Invoke();

    private void Start()
    {
        InfoTx.text = Info;
        DescTx.text = Descripcion;
    }

}
