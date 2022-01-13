using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelSlott : MonoBehaviour
{

    public int Level;
    public Text texto;

    private void Start()
    {
        texto.text = Level + "";

    if (PlayerPrefs.GetFloat("nivel") > Level)
        GetComponent<Image>().sprite = FindObjectOfType<nivel>().completo;

}

public void Check_Nivel()
    {
        FindObjectOfType<nivel>().CheckPlay(Level);
    }

}
