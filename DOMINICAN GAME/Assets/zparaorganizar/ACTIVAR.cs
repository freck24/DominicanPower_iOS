using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTIVAR : MonoBehaviour
    
{
    public inicio In;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject MOT;
    public GameObject POLI;
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "Player")
        {
            MOT.SetActive(true);
            POLI.SetActive(true);
            PlayerPrefs.SetFloat("prime", 1f);
            In.primeravez = PlayerPrefs.GetFloat("prime", 1f);
            Time.timeScale = 0f;
        }
        }
}
