using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventAnimation : MonoBehaviour
{
    public Button.ButtonClickedEvent evento;

    public void ejecurar() {
        evento.Invoke();
    }
}
