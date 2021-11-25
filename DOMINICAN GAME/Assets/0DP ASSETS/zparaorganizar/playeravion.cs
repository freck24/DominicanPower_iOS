using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playeravion : MonoBehaviour


{

    public float PosicionY_Min;
    public float PosicionY_Max;
    public float v = 10;
    Animator anim;
    public Transform yo;
    public gestorcama gestor;
    private AudioSource a;
    public Sprite a1; 
    public Sprite a2; 
    public Sprite a3; 
    public Sprite a4; 
    // Start is called before the first frame update
    void Start()
    {
        av.SetActive(true);

        a = GetComponent<AudioSource>();
        Time.timeScale = 1;
        anim = GetComponent<Animator>();
    }

    public GameObject av;
    public void cerrar()
    {
    av.SetActive(false);
    }

    public void aa1()
    {
    GetComponent<SpriteRenderer>().sprite = a1;
    } 
    public void aa2()
    {
    GetComponent<SpriteRenderer>().sprite = a2;
    } 
    public void aa3()
    {
    GetComponent<SpriteRenderer>().sprite = a3;
    } 
    public void aa4()
    {
    GetComponent<SpriteRenderer>().sprite = a4;
    } 


    void Update()
    {
        if (subet && yo.transform.position.y < PosicionY_Max)
        {
            yo.transform.Translate(0, v * Time.deltaTime, 0);
        }
        if (bajat && yo.transform.position.y > PosicionY_Min)
        {
           yo.transform.Translate(0, -v * Time.deltaTime, 0);
        }
    }
    public bool subet = false;
    public bool bajat=false;
    public void sube()
    {
        subet = true;
        bajat = false;

        anim.SetBool("sube", true);
        anim.SetBool("baja", false);
    }

    public void baja()
    {
    bajat = true;
    subet = false;
    anim.SetBool("sube", false);
    anim.SetBool("baja", true);
    }

    public void sueltaS()
    {
    subet = false;
    anim.SetBool("sube", false);
    } 
    
    public void sueltaB()
    {
    bajat = false;
    anim.SetBool("baja", false);
    }

   public IEnumerator perdi()
    {
    yield return new WaitForSecondsRealtime(1);
    perder.SetActive(true); 
    Time.timeScale = 0;
    }

    public AudioClip pierde;
    public AudioClip gana;
    public GameObject perder;
    private void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.tag == "enemy")
    {
    gestor.parar();
    a.clip = pierde;
    a.Play();
    anim.SetBool("perder", true);
    StartCoroutine(perdi());
        }


    if (collision.tag == "yun")
    {
    a.clip = gana;
    a.Play();
    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 5);
    }
    }
   public void volverajugar()
    {
    SceneManager.LoadScene("avion");
    }

    public void menu()
    {
    SceneManager.LoadScene("inicio");
    }
}
