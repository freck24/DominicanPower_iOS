using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mensajedes : MonoBehaviour
{
    public Text texto;
    public float nivel;
    public GameObject minimensaje;
    public GameObject fondo1;
    public GameObject fondo2;
    public GameObject fondobase;
    // Start is called before the first frame update
    void Start()
    {
        nivel = PlayerPrefs.GetFloat("nivel", 1);
        if (nivel == 5)
        {
            fondobase.SetActive(false);
            fondo1.SetActive(true);

            minimensaje.SetActive(false);
            minimensaje.SetActive(true);
        }

        if (nivel == 7)
        {


            fondo2.SetActive(true);
            fondo1.SetActive(false);
            texto.text = "CAPITULO II DESBLOQUEADO";

            minimensaje.SetActive(false);
            minimensaje.SetActive(true);
        }

       
     //   minimensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
