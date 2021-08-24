using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public Text tiempo;
    public float tiem = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiem +=Time.deltaTime;
        tiempo.text = "" + tiem.ToString("f2");
    }
}
