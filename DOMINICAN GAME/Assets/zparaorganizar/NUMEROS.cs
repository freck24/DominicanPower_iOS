using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NUMEROS : MonoBehaviour
{
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject n5;
    public GameObject n6;
    public GameObject n7;
    public GameObject n8;
    public Transform t1;
    public Transform t2;
    public Transform t3;
    public Transform t4;
    public Transform t5;
    public Transform t6;
    public Transform t7;
    public Transform t8;
    Animator anim;
    private AudioSource a;
    public AudioClip pop;
    public AudioClip coger;

    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(numeritos());
        }
    }
    public float tiempo = 0.2f;
    IEnumerator numeritos()
    {
        anim.SetBool("quitar", true);
        a.PlayOneShot(coger);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n1, t1.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n2, t2.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n3, t3.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n4, t4.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n5, t5.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n6, t6.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n7, t7.transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempo);
        a.PlayOneShot(pop);
        Instantiate(n8, t8.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
