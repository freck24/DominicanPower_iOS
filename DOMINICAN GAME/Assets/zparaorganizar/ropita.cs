using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropita : MonoBehaviour
{
    Renderer rend;
    public Material m1;
    public Material m2;
    public Material m3;
    public Material m4;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        if (PlayerPrefs.GetInt("r1", 0) == 1)
        {
            rend.material = m1;

        }   if (PlayerPrefs.GetInt("r2", 0) == 1)
        {
            rend.material = m2;

        }   if (PlayerPrefs.GetInt("r3", 0) == 1)
        {
            rend.material = m3;

        }   if (PlayerPrefs.GetInt("r4", 0) == 1)
        {
            rend.material = m4;

        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
