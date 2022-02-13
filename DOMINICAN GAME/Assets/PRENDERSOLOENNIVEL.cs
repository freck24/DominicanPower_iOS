using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRENDERSOLOENNIVEL : MonoBehaviour
{
    // Start is called before the first frame update
    public int nivel;
    void Start()
    {
      //  PlayerPrefs.SetFloat("nivel", 85);
        if ((int)(PlayerPrefs.GetFloat("nivel", 1)) < nivel)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
