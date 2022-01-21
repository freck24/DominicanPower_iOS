using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;





public class GESTORPRINCIPAL : MonoBehaviour
{

    [Header("Tiempo DPower")]
    public Animator TiempoPower;
    public AudioClip say;
    public AudioClip brilla;
    public bool s = false;
    public bool bril = false;
    public bool tiemposaya = false;
    public bool una = false;
    public float tiem = 0;

    public static bool AnunciosInicializados = false;
    public PreLoaderLevel ScreenLoader;

  //  public GameObject Nivel_data;

    private InterstitialAd inter;
    private RewardBasedVideoAd recompensa;
    [SerializeField] private string appID = "";
    [SerializeField] private string interID = "";
    [SerializeField] private string recoID = "";
    public Text pregresosj;
    public float niv;
    public float nivel;
    public Text progresoSD;
    public Text progresoba;
    public Text progresosa;
    public Text progresobani;
    public GameObject nivel1;
    public GameObject TRANSI;
    public GameObject pausa;
    public AudioSource a;
    public controler cont;
    public int g;

    public GameObject PLATAFORMADINE;
    public int contadordegallinas=0;




    //Load interstitial
    private void pedirinter()
    {
        if(inter!=null)
            inter.Destroy();

        inter = new InterstitialAd(interID);
        inter.OnAdClosed += HandleInterstitialClosed;

        if (PlayerPrefs.GetInt("anu", 0) == 1)
        {
            AdRequest pedir = new AdRequest.Builder().AddExtra("rdp", "1").Build();
            inter.LoadAd(pedir);
        }
        else
        {
            AdRequest pedir = new AdRequest.Builder().AddExtra("rdp", "0").Build();
            inter.LoadAd(pedir);

        }

    }
    void HandleInterstitialClosed(object sender, System.EventArgs args)
    {
        pedirinter();
    }
    private RewardedAd rewardedAd;
    //Load rewarded ad
    /*
    public void reco()
    {

        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

    }*/

    public void mostrarinter()
    {
    Debug.Log("Se Llamo Para Mostrar Anuncio Intersticial");
        scriptEjemploVR.instance.Mostrar_Intersticial();
    }
   public void mostrarreco()
    {
    Debug.Log("Se Llamo Para Mostrar Anuncio Video");
        scriptEjemploVR.instance.Mostrar_Video();
    }

    void Start()
    {

        tiempopoder = 10+ PlayerPrefs.GetFloat("tiempopoder", 0)*2;
        PlayerPrefs.SetInt("cg", 0);
        
        a = GetComponent<AudioSource>();

        niv = PlayerPrefs.GetFloat("sj", 1);
        nivel = PlayerPrefs.GetFloat("sd", 1);
        if(PlayerPrefs.GetFloat("nivel",1)==5 || PlayerPrefs.GetFloat("nivel", 1) == 8)
        {
            //PLATAFORMADINE.SetActive(true);
        }

        ScreenLoader = FindObjectOfType<PreLoaderLevel>();
    }


    
    public AudioClip baja;
    public Text TIEMPOTEXT;

    public float tiempopoder = 10;

    // Update is called once per frame
    void Update()
    {
        g = PlayerPrefs.GetInt("cg", 0);
        if (bril)
        {
            a.clip = brilla;
            a.Play();
            bril = false;
        }



        if (s)
        {
            a.clip = say;
            a.Play();
            tiem = 0;
            tiemposaya = true;
            cont.PowerOn.SetActive(true);
            s = false;
        }


        TiempoPower.SetBool("InPower",tiemposaya);


        if (tiemposaya)
        {
            tiem += Time.deltaTime;
            una = true;
            TIEMPOTEXT.text = (-tiem + tiempopoder).ToString("f2");
        }

        if (tiem > tiempopoder && una)
        {
            TIEMPOTEXT.text = "";
            cont.reflejo.SetActive(false);
            cont.reflejo2.SetActive(false);
            cont.reflejo3.SetActive(false);
            tiemposaya = false;
            cont.PowerLoop.SetActive(false);
            cont.PowerDisponible = true;
            cont.pawerArea.SetActive(false);
            //    cont.pawerArea.SetActive(false);

            cont.fuerza = 85;
            cont.rompe = false;
            a.clip = baja;
            a.Play();
            una = false;
            cont.tiempoespera = 2;
            cont.PowerOff.SetActive(true);
            cont.cabeza.SetActive(false);
        }

    }

    public AudioClip pa;
    public AudioClip qpa;
    public GameObject pane;
    public bool tu = true;
    public void pausad()
    {
        pausa.SetActive(tu);
        pane.SetActive(tu);

        if (tu)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        tu = !tu;
        a.clip = pa;
        a.Play();

    } public void qpausad()
    {
        a.clip = qpa;
        a.Play();
        tu = true;
        pausa.SetActive(false);
        pane.SetActive(false);
        Time.timeScale = 1;
    }

    public IEnumerator t()
    {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("nivel1");

    }
    public void viaje()
    {
        TRANSI.SetActive(true);
        nivel1.SetActive(false);
        StartCoroutine(t());

    }






    public GameObject camaraplaneta;
    public GameObject camaraplaneta2;
    public GameObject camaraplaneta3;



    public GameObject[] nivelll;
    public GameObject cargarsiguiente;
    public void siguientenivel()
    {
    /*    if(PlayerPrefs.GetString("nombre", "") == "freck24") //PARA QUE LE APAREZCAN ANUNCIOS AL DESARROLLADOR
        {
            PlayerPrefs.SetInt("anuncios", 1);
            print("LE ESTA APRECIENDO ANUNCIOS DEV");
        }*/
   //     ScreenLoader.isnivelactualsiguiente = true;
      //  ScreenLoader.scena = "LEVEL 1 CLONE";



        if(PlayerPrefs.GetInt("anuncios", 1) == 1)
        {
            if (PlayerPrefs.GetFloat("nivel", 1) > 15)
            {
                mostrarreco();
            }
            else
            {
               if( PlayerPrefs.GetFloat("nivel", 1)%2 == 0)
                {
                    mostrarinter();
                }
               
            }
        }
        


   //   ScreenLoader.gameObject.SetActive(true);


     


        
    }














    public void sanjuan()
    {
        if(PlayerPrefs.GetFloat("nivel",1) == 6)
        {
            viaje();
           // SceneManager.LoadScene("nivel1");

        }
    }
       public void SANTODMINGO()
    { //publicidad
        if(PlayerPrefs.GetFloat("nivel",1) <6 || PlayerPrefs.GetFloat("nivel", 1)==8 || PlayerPrefs.GetFloat("nivel", 1)==10 || PlayerPrefs.GetFloat("nivel", 1)==11 || PlayerPrefs.GetFloat("nivel", 1)>13 ) 
        {

            if (PlayerPrefs.GetFloat("nivel", 1) == 5 || PlayerPrefs.GetFloat("nivel", 1) == 10|| PlayerPrefs.GetFloat("nivel", 1) == 14|| PlayerPrefs.GetFloat("nivel", 1) == 18 || PlayerPrefs.GetFloat("nivel", 1) == 22 || PlayerPrefs.GetFloat("nivel", 1) == 33 || PlayerPrefs.GetFloat("nivel", 1) == 47 || PlayerPrefs.GetFloat("nivel", 1) == 57 )
                {
                mostrarinter();
            }

            SceneManager.LoadScene("nivel1");
        }
    } 
    
    public void barahona()
    {
        if(PlayerPrefs.GetFloat("nivel",1) == 7)
        {
            viaje();
           // SceneManager.LoadScene("nivel1");
        }
    }

    public void samana()
    {
        if (PlayerPrefs.GetFloat("nivel", 1) == 9)
        {
            viaje();
          //  SceneManager.LoadScene("nivel");
        }
    }

    public void bani()
    {
        if (PlayerPrefs.GetFloat("nivel", 1) == 12)
        {
            viaje();
        }
           if(PlayerPrefs.GetFloat("nivel", 1) == 13)
        {
            
            SceneManager.LoadScene("nivel1");
        }
    }


}
