using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorplayer2 : MonoBehaviour
{
    public GameObject z1;
    public GameObject z2;


  //  Vector3 target;
    public float velocidad = 10f;
    public float gz;
    public Seguidor seguidor;
    public Seguidor2a seguidor2;
    public bool j2 = false;
    public GameObject mitad2;
    public GameObject ganar;
    public Text pmax;
    public float PM;
    public AudioClip gano;
    private AudioSource a;
    public Text premio;

    public TIMER timer;
    // Start is called before the first frame update
    void Start()
    {
        //  target = transform.position;
        //  gz = transform.position.y;
        pmax.text = "RECORD:" + PlayerPrefs.GetFloat("tiempoyun", 100f).ToString("f2") + " segundos";
        a = GetComponent<AudioSource>();
    }
    public perderyyun perder;

    void OnTriggerEnter(Collider otr)
    {
        if (otr.gameObject.tag == "area1")
        {
            seguidor.en1estoyp2 = true;
            seguidor.sigue2 = true;
            seguidor.sigue1 = false;



        }
        if (otr.gameObject.tag == "area2")
        {
            seguidor2.estoyena22 = true;
            seguidor2.sigue2 = true;
            seguidor2.sigue1 = false;

        }

        if (otr.gameObject.tag == "mitad2")
        {
            mitad2.SetActive(true);
            z1.SetActive(false);
            z2.SetActive(true);
        }
        if (otr.gameObject.tag == "ganar2")
        {
            z2.SetActive(false);
            perder.ft = 5;
            PM = timer.tiem;
            ganar.SetActive(true);
            if (PlayerPrefs.GetFloat("tiempoyun", 100f) > PM)
            {
                PlayerPrefs.SetFloat("tiempoyun", PM);
                pmax.text = "NUEVO RECORD:" + PlayerPrefs.GetFloat("tiempoyun", 100f).ToString("f2") + " segundos";
            }
            else
            {
                pmax.text = "RECORD:" + PlayerPrefs.GetFloat("tiempoyun", 100f).ToString("f2") + " segundos";
               
        }



            if (timer.tiem < 20f && timer.tiem > 15)
            {
                premio.text = "Ha ganado $500";
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) + 500f);
                a.clip = gano;
                a.Play();

            }
            if (timer.tiem < 15f && timer.tiem > 10)
            {
                premio.text = "Ha ganado $750";
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) + 750f);
                a.clip = gano;
                a.Play();

            }
            if (timer.tiem < 10f)
            {
                premio.text = "Ha ganado $1000";
                PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) + 1000f);
                a.clip = gano;
                a.Play();

            }
            timer.corriendo = false;
        }

    }

    void OnTriggerExit(Collider otr)
    {
        if (otr.gameObject.tag == "area1")
        {
            seguidor.en1estoyp2 = false;
        }
        if (otr.gameObject.tag == "area2")
        {
            seguidor2.estoyena22= false;
        }
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0) && j2)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.y = gz;
        }


        if (j2 && target.x > -11) { 
                transform.position = Vector3.MoveTowards(transform.position, target, velocidad * Time.deltaTime);    }

        Debug.DrawLine(transform.position, target, Color.blue);*/
    }



}
