using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiDestroy : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
