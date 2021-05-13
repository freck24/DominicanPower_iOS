using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;





public class GESTORPRINCIPAL : MonoBehaviour
{
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
   private void pedirinter()
    {
        inter = new InterstitialAd(interID);
        AdRequest pedir = new AdRequest.Builder().Build();
        inter.LoadAd(pedir);

    }
    private RewardedAd rewardedAd;
    public void reco()
    {

        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

    }

    public void mostrarinter()
    {
        inter.Show();
        inter.Destroy();
        pedirinter();
    }
   public void mostrarreco()
    {

        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
            llamar();
        }


    }


    private void Awake()
    {
        appID = "ca-app-pub-9304701110302498~4944191339";
      interID = "ca-app-pub-9304701110302498/3578320535";
       recoID = "ca-app-pub-9304701110302498/8639075529";



            MobileAds.Initialize(initStatus => {});
        llamar();
       
    }

    public void llamar()
    {
        this.rewardedAd = new RewardedAd(recoID);

        // Called when an ad request has successfully loaded.

        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.

        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
        //   MobileAds.Initialize(appID);

    }



    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + args.Message);
    }



    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }



    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
        cont.volverajugaranuncio();
        /*  mostrarr.SetActive(true);
          rbonificado.text = "" + respuestauser;*/
    }
    
    // Start is called before the first frame update
    void Start()
    {
        tiempopoder = 10+ PlayerPrefs.GetFloat("tiempopoder", 0)*2;
        PlayerPrefs.SetInt("cg", 0);
        pedirinter();
        reco();
        
        a = GetComponent<AudioSource>();

        niv = PlayerPrefs.GetFloat("sj", 1);

        nivel = PlayerPrefs.GetFloat("sd", 1);

        if(PlayerPrefs.GetFloat("nivel",1)==5 || PlayerPrefs.GetFloat("nivel", 1) == 8)
        {
            //PLATAFORMADINE.SetActive(true);
        }

    }


    public AudioClip say;
    public AudioClip brilla;
    public bool s = false;
    public bool bril = false;
    public bool tiemposaya = false;
    public bool una = false;
    public float tiem = 0;
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
            s = false;
            
        }
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
            cont.fuerza = 85;
            cont.rompe = false;
            a.clip = baja;
            a.Play();
            una = false;
            cont.tiempoespera = 2;
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

            if (PlayerPrefs.GetFloat("nivel", 1) % 3==0 && PlayerPrefs.GetInt("anuncios",1)==1)
            { 

            if(PlayerPrefs.GetFloat("nivel", 1) < 63)
            {
                mostrarinter(); //publicidad
            }
            else
            {
                mostrarreco();
            }

                
            }


        cargarsiguiente.SetActive(true);


     //   cont.tras();

      //   cont.nivelet();
       
       // cont.InstanciasN();

     //   cont.boto.SetActive(true);
        
      //  camaraplaneta.SetActive(false);
      //  camaraplaneta2.SetActive(false);
      //  camaraplaneta3.SetActive(false);


        
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
