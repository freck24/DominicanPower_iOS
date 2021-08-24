using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polloasado : MonoBehaviour
{
    private AudioSource a;
    public GameObject sonidocomer;
    public AudioClip comer;
    public GameObject yo;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
          //  Destroy(yo);
            Destroy(gameObject);
            PlayerPrefs.SetFloat("pollo", PlayerPrefs.GetFloat("pollo", 0) + 1);

            sonidocomer.SetActive(true);
        }
    }
}
