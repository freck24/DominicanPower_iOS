using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverbolita : MonoBehaviour
{
    private AudioSource a;
    public AudioClip rock;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
        StartCoroutine(sonido());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator sonido()
    {
        yield return new WaitForSecondsRealtime(5f);


        while (PlayerPrefs.GetFloat("nivel", 1) == 9)
        {
            yield return new WaitForSecondsRealtime(7f);
            a.clip = rock;
            a.Play();
        }

    }
}
