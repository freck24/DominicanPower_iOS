using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarautomatico : MonoBehaviour
{
    public GameObject yo;
    // Start is called before the first frame update
    void Start()
    {
    if (PlayerPrefs.GetString("nombre", "") != "freck24" && PlayerPrefs.GetString("nombre", "") != "EliezerYTT")
    yo.SetActive(false);
    }

   
}
