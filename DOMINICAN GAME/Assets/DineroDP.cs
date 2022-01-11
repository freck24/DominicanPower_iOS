using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DineroDP : MonoBehaviour
{
    public Text TextoDinero;

    void Update()
    {
    TextoDinero.text = PlayerPrefs.GetFloat("dinero", 0).ToString();
    }
}
