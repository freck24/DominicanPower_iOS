using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mision1 : MonoBehaviour
{ public float n = 100000;
    public float mision=250000;
    public Image barram;
    public Text D;
    public bool d = false;
    public AudioClip bajar;
    private AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
        barram.transform.localScale = new Vector2(1, n / mision);
        StartCoroutine(animacion());
            }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) / mision <= 1 && d)
        {
            barram.transform.localScale = new Vector2(1, PlayerPrefs.GetFloat("dinero", 0) / mision);
            D.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
        }
      
    }
    public IEnumerator animacion()
    {
        yield return new WaitForSecondsRealtime(1);
       // a.clip = bajar;
       // a.Play();
        while (n>PlayerPrefs.GetFloat("dinero", 0))
        {
            yield return new WaitForSecondsRealtime(0.000001f);
            barram.transform.localScale = new Vector2(1, n / mision);
            n -= 1000;
            D.text = "$" + n.ToString("f0");
        }

        d = true;
    }





}
