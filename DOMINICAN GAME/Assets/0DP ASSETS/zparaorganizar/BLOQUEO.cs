using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLOQUEO : MonoBehaviour
{
    public int NIVEL;
    public GameObject bloqueador;
    public GameObject disponible;
    public float NIVELREAL;
    // Start is called before the first frame update
    void Start()
    { NIVELREAL = (int)PlayerPrefs.GetFloat("nivel", 0);
        if (NIVELREAL >= NIVEL)
        {
            bloqueador.SetActive(false);
            disponible.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
