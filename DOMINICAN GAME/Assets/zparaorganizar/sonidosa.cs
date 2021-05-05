using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidosa : MonoBehaviour
{
    private AudioSource a;
    public AudioClip sa;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
      //  StartCoroutine(sasasa());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator sasasa()
    {

        {
            yield return new WaitForSecondsRealtime(t);
            a.clip = sa;
            a.Play();
         



        }
    }
}
