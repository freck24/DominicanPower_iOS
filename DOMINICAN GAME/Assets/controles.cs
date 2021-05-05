using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    public void b0()
    {
        PlayerPrefs.SetInt("controles", 0);
        
    }public void b1()
    {
        PlayerPrefs.SetInt("controles", 1);
        
    }public void b2()
    {
        PlayerPrefs.SetInt("controles", 2);
        
    }public void b3()
    {
        PlayerPrefs.SetInt("controles", 3);
        
    }public void b4()
    {
        PlayerPrefs.SetInt("controles", 4);
        
    }public void b5()
    {
        PlayerPrefs.SetInt("controles", 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
