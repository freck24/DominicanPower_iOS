using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PUNTOSDOMINICANLEVEL : MonoBehaviour
{
    // Start is called before the first frame update

    public bool punto = false;
    //public TextMesh rt;
    public TextMeshPro rt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (punto)
        {
            rt.text = PlayerPrefs.GetFloat("niveld", 0).ToString();
        }
        
    }
}
