using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class perderyyun : MonoBehaviour
{
    public Text text;
    public float ft;

    public GameObject AdsYunOnline;


    public void OpenUrl(string link)
    {
        Application.OpenURL(link);
    }

    // Start is called before the first frame update
    void Start()
    {

        ft = PlayerPrefs.GetFloat("precioyun", 2.5f) * 2;
        PlayerPrefs.SetFloat("precioyun", ft);
        text.text = " jugar por $" + ft.ToString("f0");

        if(PlayerPrefs.GetInt("YunAds", 0) == 1)
        {
            if (Random.Range(0, 3) == 1) AdsYunOnline.SetActive(true);
        }
    }

    
}
