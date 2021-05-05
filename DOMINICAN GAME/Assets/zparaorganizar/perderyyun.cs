using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class perderyyun : MonoBehaviour
{
    public Text text;
    public float ft;

    // Start is called before the first frame update
    void Start()
    {

        ft = PlayerPrefs.GetFloat("precioyun", 2.5f) * 2;
        PlayerPrefs.SetFloat("precioyun", ft);
        text.text = " jugar por $" + ft.ToString("f0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
