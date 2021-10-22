using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Q", 5)==0 || PlayerPrefs.GetInt("Q", 5)==1 || PlayerPrefs.GetInt("Q", 5) == 2)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
