using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableContinue : MonoBehaviour
{
    public GameObject ToDisable;
   

    void Start()
    {
        if (PlayerPrefs.GetInt("PlayingGame", 0) == 1) ToDisable.SetActive(false);
    }

    
}
