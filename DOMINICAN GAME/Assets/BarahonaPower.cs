using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarahonaPower : MonoBehaviour
{
    public float TimingToShow;
    public GameObject ActiveMe;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    void Update()
    {
        if (TimingToShow < -1) return;

        TimingToShow -= Time.deltaTime;

        if (TimingToShow <= 0) ActiveMe.SetActive(true);
    }


}
