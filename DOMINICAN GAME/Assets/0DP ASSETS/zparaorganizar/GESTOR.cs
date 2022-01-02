using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GESTOR : MonoBehaviour
{ public float apostado = 0;
  public Text DINERO;
  public Text DINEROAPOSTADO;
    private AudioSource a;
    public AudioClip pop;
    public AudioClip faile;
    // Start is called before the first frame update
    void Start()
    {
        aceptar.SetActive(true);
        a = GetComponent<AudioSource>();
        DINERO.text = "DINERO DISPONIBLE: "+  PlayerPrefs.GetFloat("dinero", 0).ToString();
        if (PlayerPrefs.GetFloat("dinero", 0) < 100)
        {
            apostado = 0;
            
        }
        DINEROAPOSTADO.text = apostado.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void subir()
    { 
        if (PlayerPrefs.GetFloat("dinero", 0) > apostado+99)
        {
            apostado += 100;
            a.clip = pop;
            a.Play();
        } else
        {
            a.clip = faile;
            a.Play();
        }
        DINEROAPOSTADO.text = apostado.ToString();
    }

    public GameObject aceptar;
    public  void bajar()
    {
        if (apostado>99)
        {
            apostado -= 100;
            a.clip = pop;
            a.Play();
        } else
        {
            a.clip = faile;
            a.Play();
        }
        DINEROAPOSTADO.text = apostado.ToString();
    }

    public void acep()
    {
        aceptar.SetActive(false);
        DETE.SetActive(true);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - apostado );
    }

    public void MENU()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }

    public Text t1;
    public Text t2;
    public Text t3;
    public Text t4;
    public Text total;
    public GameObject DETE;
    public void DETEN()
    {
        DETE.SetActive(false);
    }
    public void ganar()
    {
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + apostado * 4);
        t1.text = "$RD"+apostado.ToString();
        t2.text = "$RD"+apostado.ToString();
        t3.text = "$RD"+apostado.ToString();
        t4.text = "$RD" + apostado.ToString();
        total.text = "TOTAL: $RD" + (4*apostado).ToString();


    }
}
