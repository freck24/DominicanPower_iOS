using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigre : MonoBehaviour
{
    Animator anim;
    public AudioClip bajandoinf;
    public AudioClip dameto;
    private AudioSource a;
    public float velocity = 5;
    public Transform puntoa;
    public Transform puntob;
    public Transform avatar;
    public bool vuelve = true;
    Vector3 ae;
  
    // Start is called before the first frame update
    void Start()
    {
      //  PlayerPrefs.SetFloat("dinero", 50000);
        anim = GetComponent<Animator>();
        a = GetComponent<AudioSource>();
        ae = avatar.transform.localScale;
     
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < puntoa.position.x && vuelve)
        {
            vuelve = false;
        }
      


        if(transform.position.x > puntob.position.x && vuelve == false)
        {
            vuelve = true;
        }


        if (vuelve)
        {

            transform.Translate(0,0, velocity * Time.deltaTime);
            transform.localScale = new Vector3(8, 8, 8);
            avatar.transform.localScale = new Vector3(ae.x, ae.y, ae.z);
        

        }
        else
        {
            transform.Translate(0,0,-velocity * Time.deltaTime);
            transform.localScale = new Vector3(-8, 8, 8);
            avatar.transform.localScale = new Vector3(ae.x, ae.y, -ae.z);
            
       
        }



    }
    public bool atracando = false;
    public GameObject encerrador;
    
 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="walk" && PlayerPrefs.GetFloat("dinero",0)>100 && atracando == false)
        {
            estadentro = true;

            atracando = true;
            velocity = 0;
            encerrador.SetActive(true);
            anim.SetBool("dispara", true);
            StartCoroutine(baja());
            
        
        }
    }


   

    public GameObject PISTOLA;
    public bool quita = false;
    public GameObject fondorojo;
    public bool estadentro = false;
    public IEnumerator baja()
    {
        fondorojo.SetActive(true);
        a.clip = dameto;
        a.Play();
        PISTOLA.SetActive(true);
        yield return new WaitForSecondsRealtime(2.5f);
        
        a.clip = bajandoinf;
        a.Play();
        while (PlayerPrefs.GetFloat("dinero", 0) > 100 && estadentro)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 100);
            yield return new WaitForSecondsRealtime(0.0001f);
            
            
        }
        a.Stop();
        anim.SetBool("dispara", false);
        velocity = 5;
        encerrador.SetActive(false);
        atracando = false;
        fondorojo.SetActive(false);
        PISTOLA.SetActive(false);
    }

}
