using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colmado : MonoBehaviour
{
    // Start is called before the first frame update

    public float platanov;


    public AudioClip regist;
    public AudioClip tunotienes;
    public AudioClip pop;
    private AudioSource j;
  //  public Text text = null;
    public Text textmango = null;
    public Text textpollo = null;
    public GameObject[] dis;

    public GameObject[] comprardisp;

    public GameObject b;
    public GameObject b2;

    public Animator ANIM;
    public void banca()
    {
        ANIM.SetBool("banca", true);
        b.SetActive(true);
        b2.SetActive(false);
    }

    public GameObject m1;
    public GameObject m2;
    public void bancac()
    {
        ANIM.SetBool("banca", false);
        b.SetActive(false);
        b2.SetActive(true);
        m1.SetActive(false);
        m2.SetActive(false);
    }
    void Start()
    {
     //   PlayerPrefs.SetFloat("tiempopoder", 0);
        tp = PlayerPrefs.GetFloat("tiempopoder", 0);
        tpp = Mathf.Pow(10, tp+2)/2;
        preciotiempo.text = "$" + tpp.ToString();

        float r = 10 + tp*2;
        ptiempo.text = "TIEMPO POWER: " + r + " s";

        if (PlayerPrefs.GetFloat("gafas", 0) == 1)
        {
            comprardisp[0].SetActive(false);
        }

       if( PlayerPrefs.GetFloat("gorras", 0) == 1)
        {
            comprardisp[1].SetActive(false);
        }
        vende.SetActive(false);
        mens4.SetActive(false);
        comprae.SetActive(false);
        j = GetComponent<AudioSource>();
        dinero = PlayerPrefs.GetFloat("dinero", 0f);
        platanov = PlayerPrefs.GetFloat("platanos", 0f);
        textmango.text = "" + PlayerPrefs.GetFloat("mango", 0f).ToString("f0");
        textpollo.text = "" + PlayerPrefs.GetFloat("pollo", 0f).ToString("f0");
        cate.text = PlayerPrefs.GetFloat("cate", 0).ToString("f0");
        salami.text = PlayerPrefs.GetFloat("salami", 0).ToString("f0");
        fruticas.text = PlayerPrefs.GetFloat("fruticas", 0).ToString("f0");
        coca.text = PlayerPrefs.GetFloat("coca", 0).ToString("f0");
        pl.text = "" + platanov;
        dr.text = "RD$" + dinero;
        if(PlayerPrefs.GetFloat("mango", 0f) > 0)
        {
            dis[0].SetActive(true);
        }if(PlayerPrefs.GetFloat("fruticas", 0) > 0)
        {
            dis[1].SetActive(true);
        }if(platanov > 0)
        {
            dis[2].SetActive(true);
        }if(PlayerPrefs.GetFloat("cate", 0) > 0)
        {
            dis[3].SetActive(true);
        }
        if(PlayerPrefs.GetFloat("coca", 0) > 0)
        {
            dis[4].SetActive(true);
        }if(PlayerPrefs.GetFloat("pollo", 0f) > 0)
        {
            dis[5].SetActive(true);
        }if(PlayerPrefs.GetFloat("salami", 0) > 0)
        {
            dis[6].SetActive(true);
        }


        if (PlayerPrefs.GetFloat("nivel", 0) < 3)
        {
          //  text.text = "NECESITAS NIVEL 3 PARA COMPRAR";
        }
        else
        {
          //  text.text = "COMPRAR";
        }

            


     }

    public GameObject[] comprado;
    public void compraplatano()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > 499){
            PlayerPrefs.SetFloat("poder", PlayerPrefs.GetFloat("poder", 0) + 1);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 500);
            j.clip = regist;
            j.Play();
            comprado[0].SetActive(false);
            comprado[0].SetActive(true);
        }
        else
        {
            j.clip = tunotienes;
            j.Play();
        }
    } 
    
    public void venderpollo()
    { if (PlayerPrefs.GetFloat("pollo", 0) > 0)
        {
            dis[5].SetActive(false);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + PlayerPrefs.GetFloat("pollo", 0) * 150);
            PlayerPrefs.SetFloat("pollo", 0);

            j.clip = regist;
            j.Play();
            textpollo.text = PlayerPrefs.GetFloat("pollo", 0).ToString("f0");
        }
        else
        {
            tunotiene();
        }
    }

    public Text cate;
    public Text salami;
    public Text coca;
    public void vendercate()
    { if (PlayerPrefs.GetFloat("cate", 0) > 0)
        {
            dis[3].SetActive(false);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + PlayerPrefs.GetFloat("cate", 0) * 50);
            PlayerPrefs.SetFloat("cate", 0);

            j.clip = regist;
            j.Play();
            cate.text = PlayerPrefs.GetFloat("cate", 0).ToString("f0");
        }
        else
        {
            tunotiene();
        }
    }
    float tp=10000000;
    float tpp=10000000;
    public Text preciotiempo;
    public Text ptiempo;
    public void comprartiempo()
    {
        
    
        if (PlayerPrefs.GetFloat("dinero", 0f) > tpp - 1)
        {
            j.clip = regist;
            j.Play();
            PlayerPrefs.SetFloat("tiempopoder", tp + 1);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - tpp);

            tp = PlayerPrefs.GetFloat("tiempopoder", 0);
            tpp = Mathf.Pow(10, tp + 2)/2;
            preciotiempo.text = "$"+tpp.ToString();
            float r = 10 + tp*2;
            ptiempo.text = "TIEMPO POWER: " + r+" s";
        }
        else
        {
            j.clip = tunotienes;
            j.Play();
        }
    }


    public void vendersalami()
    { if (PlayerPrefs.GetFloat("salami", 0) > 0)
        {
            dis[6].SetActive(false);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + PlayerPrefs.GetFloat("salami", 0) * 350);
            PlayerPrefs.SetFloat("salami", 0);

            j.clip = regist;
            j.Play();
            salami.text = PlayerPrefs.GetFloat("salami", 0).ToString("f0");
        }
        else
        {
            tunotiene();
        }
    }

    public Text fruticas;
    public void venderfruticas()
    { if (PlayerPrefs.GetFloat("fruticas", 0) > 0)
        {
            dis[1].SetActive(false);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + PlayerPrefs.GetFloat("fruticas", 0) *10);
            PlayerPrefs.SetFloat("fruticas", 0);

            j.clip = regist;
            j.Play();
            fruticas.text = PlayerPrefs.GetFloat("fruticas", 0).ToString("f0");
        }
        else
        {
            tunotiene();
        }
    } 
    public void vendercoca()
    { if (PlayerPrefs.GetFloat("coca", 0) > 0)
        {
            dis[4].SetActive(false);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + PlayerPrefs.GetFloat("coca", 0) *75 );
            PlayerPrefs.SetFloat("coca", 0);

            j.clip = regist;
            j.Play();
            coca.text = PlayerPrefs.GetFloat("coca", 0).ToString("f0");
        }
        else
        {
            tunotiene();
        }
    } 
    

    // Update is called once per frame
    void Update()
    {
        dinero = PlayerPrefs.GetFloat("dinero", 0f);

        dr.text = "RD$" + dinero;
    }
    public float dinero;
    public GameObject vende;
    public GameObject comprae;
    public GameObject mens4;
    public GameObject x;
    public Text pl = null;
    public Text dr = null;


    public void comp()





    {
        if (PlayerPrefs.GetFloat("nivel", 1) > 0)
            { 


            j.clip = pop;
            j.Play();
            comprae.SetActive(true);
        }
        else
        {
            j.clip = tunotienes;
            j.Play();
        }
    } public void fcomp()
    {
        j.clip = pop;
        j.Play();
        comprae.SetActive(false);
    }


    public GameObject cambiarscena;
    public void menu()
    {
        cambiarscena.SetActive(true);
    }

    public void comprarg()
    {
        if(PlayerPrefs.GetFloat("dinero", 0f) > 4999f && PlayerPrefs.GetFloat("gorras",0)==0)
        {
            comprardisp[1].SetActive(false);
            PlayerPrefs.SetFloat("gorras", 1f);
            dinero -= 5000;
            PlayerPrefs.SetFloat("dinero", dinero);
            j.clip = regist;
            j.Play();
            dr.text = "RD$" + dinero;
            comprado[1].SetActive(false);
            comprado[1].SetActive(true);

        } else
        {
            j.clip = tunotienes;
            j.Play();
        }
    }public void comprargat()
    {
        if (PlayerPrefs.GetFloat("dinero", 0f) > 19999f && PlayerPrefs.GetFloat("gatos", 0) == 0)


        {

            PlayerPrefs.SetFloat("gatos", 1f);
            j.clip = regist;
            j.Play();
            dinero -= 20000;
            PlayerPrefs.SetFloat("dinero", dinero);
            dr.text = "RD$" + dinero;
        }
        else
        {
            j.clip = tunotienes;
            j.Play();
        }

    }
    public void comprargaf()
    {
        
        if (PlayerPrefs.GetFloat("dinero", 0f) > 7999f && PlayerPrefs.GetFloat("gafas", 0) == 0)
        {
            comprardisp[0].SetActive(false);
            PlayerPrefs.SetFloat("gafas", 1);
            j.clip = regist;
            j.Play();
            dinero -= 8000;
            PlayerPrefs.SetFloat("dinero", dinero);
            dr.text = "RD$" + dinero;
            comprado[2].SetActive(false);
            comprado[2].SetActive(true);

        }
        else
        {
            j.clip = tunotienes;
            j.Play();
        }
    }



        public void vender()
    {
        j.clip = pop;
        j.Play();
        vende.SetActive(true);
    } public void finalizaventa()
    {
        j.clip = pop;
        j.Play();
        vende.SetActive(false);
        mens4.SetActive(false);
    } public void venderplatano()
    {
        if (PlayerPrefs.GetFloat("platanos", 0f) > 0)
        {
            dis[2].SetActive(false);
            j.clip = regist;
            j.Play();
            dinero += 15 * PlayerPrefs.GetFloat("platanos", 0f);
            PlayerPrefs.SetFloat("dinero", dinero);
            platanov = PlayerPrefs.GetFloat("platanos", 0f);
            PlayerPrefs.SetFloat("platanos", 0f);

            dinero = PlayerPrefs.GetFloat("dinero", 0f);
           
            PlayerPrefs.SetFloat("platanov", PlayerPrefs.GetFloat("platanov", 0) + platanov);
            platanov = PlayerPrefs.GetFloat("platanos", 0f);
            pl.text = "" + platanov;
            dr.text = "RD$" + dinero;
        }
        else tunotiene();

    }
    
    public void vendermango()
    {
        if (PlayerPrefs.GetFloat("mango", 0f) > 0)
        {
            dis[0].SetActive(false);
            j.clip = regist;
            j.Play();
            dinero += 5 * PlayerPrefs.GetFloat("mango", 0f);
            PlayerPrefs.SetFloat("dinero", dinero);
            PlayerPrefs.SetFloat("mango", 0f);

            dinero = PlayerPrefs.GetFloat("dinero", 0f);

            textmango.text = "" + PlayerPrefs.GetFloat("mango", 0f).ToString("f0");


            dr.text = "RD$" + dinero;
        }
        else tunotiene();
    }
    
    
    public void tunotiene()
    {
        mens4.SetActive(true);
        j.clip = tunotienes;
        j.Play();
    }
    
    
    public void cvendermango()
    {
        j.clip = pop;
        j.Play();
        mens4.SetActive(false);
    }
}
