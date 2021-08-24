using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class movebala : MonoBehaviour
{ public float velocidadbalas;
    public AudioClip rebote;
    private AudioSource a;
    // Start is called before the first frame update

    public float tiempo = 0; 
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        transform.Translate(0,velocidadbalas * Time.deltaTime, 0);
        if (tiempo > 5)
        {
            Destroy(gameObject);
        }
    }

    public GameObject PARTICULAS;
    public GameObject mata;
    public IEnumerator p()
    {
        a.clip = rebote;
        a.Play();
        mata.SetActive(false);
        PARTICULAS.SetActive(true);
        yield return new WaitForSecondsRealtime(0.15f);
        PARTICULAS.SetActive(false);

       // yield return new WaitForSecondsRealtime(0.1f);
        velocidadbalas = -velocidadbalas;
        transform.localScale = new Vector3(transform.localScale.x, -transform.localScale.y, transform.localScale.z);
        yield return new WaitForSecondsRealtime(1f);
       // Destroy(gameObject);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "repelente")
        {
            StartCoroutine(p());
           

        }
        if (collision.tag == "Player")
        {
            StartCoroutine(d());
        }
    }


    public IEnumerator d()
    {
        yield return new WaitForSecondsRealtime(1);
        Destroy(gameObject);
    }

}
