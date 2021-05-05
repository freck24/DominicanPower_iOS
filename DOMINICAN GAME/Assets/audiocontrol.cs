using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiocontrol : MonoBehaviour
{
    public AudioListener ESCUCHADOR;
    // Start is called before the first frame update
    void Start()
    {

        ESCUCHADOR = GetComponent<AudioListener>();
        if (PlayerPrefs.GetInt("sonido", 1) == 0)
        {

            ESCUCHADOR.enabled = false;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
