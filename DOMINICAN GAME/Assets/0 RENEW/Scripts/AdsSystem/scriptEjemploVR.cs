using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class scriptEjemploVR : MonoBehaviour
{

    [Header("Anuncio Por Llamadas 1")]
    public int Llamada_Actual;
    public int Llamada_Maxima;

    [Space(5)]
    public ID_anuncios_reales Ids;
    public static scriptEjemploVR instance;


    private RewardedAd rewaredAD;
    private InterstitialAd interstitial;


    public void AdsByCall_Intersticial()
    {
    Llamada_Actual++;

    if (Llamada_Actual >= Llamada_Maxima)
    {
            Mostrar_Intersticial();
            Llamada_Actual = 0;
    }
    }

    public void AdsByCall_Video()
    {
        Llamada_Actual++;

        if (Llamada_Actual >= Llamada_Maxima)
        {
            Mostrar_Video();
            Llamada_Actual = 0;
        }
    }



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            MobileAds.Initialize(initStatus => { });

        }
        else
        {
            Destroy(gameObject);
            return;
        }

    }


    public void Start()
    {


        // 1 menor que 13
        if (PlayerPrefs.GetInt("edad", 0) == 1)
        {
            RequestConfiguration requestConfiguration = new RequestConfiguration.Builder()
          .SetTagForChildDirectedTreatment(TagForChildDirectedTreatment.True)
          .build();
            MobileAds.SetRequestConfiguration(requestConfiguration);
        }

        RequestInterstitial();
        RequestVideoReward();
    }



    


    public void Mostrar_Video()
    {
    if (rewaredAD.IsLoaded()) rewaredAD.Show();
    else RequestVideoReward();
    }

    public void Mostrar_Intersticial()
    {
    if (interstitial.IsLoaded()) interstitial.Show();
    else RequestInterstitial();
    }

    private void RequestVideoReward()
    {
        rewaredAD = new RewardedAd(Ids.ID_VideoReward);
        rewaredAD.OnAdLoaded += HandleRewardedAdLoaded;
        rewaredAD.OnUserEarnedReward += HandleUserEarnedReward; 
        rewaredAD.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        rewaredAD.OnAdClosed += HandleRewardedAdClosed;

        AdRequest adRECu = new AdRequest.Builder().AddExtra("npa", PlayerPrefs.GetInt("anu", 0).ToString()).Build();
        rewaredAD.LoadAd(adRECu);
    }

    private void RequestInterstitial()
{
    interstitial = new InterstitialAd(Ids.ID_Intersticial);
    interstitial.OnAdLoaded += HandleOnAdLoaded;
    interstitial.OnAdClosed += HandleOnAdClosed;
    interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;

    AdRequest request = new AdRequest.Builder().AddExtra("npa", PlayerPrefs.GetInt("anu", 0).ToString()).Build();
    interstitial.LoadAd(request);
}


    public void HandleRewardedAdLoaded(object sender, EventArgs args) => print("SE CARGO ANUNCIO VIDEO BONIFICADO");
    public void HandleOnAdLoaded(object sender, EventArgs args) => print("SE CARGO ANUNCIO INTERSTICIAL");


    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        print("ANUNCIO INTERSTICIAL FALLO LA CARGA");
        RequestInterstitial();
    }
    public void HandleRewardedAdFailedToLoad(object sender, EventArgs args)
    {
        print("ANUNCIO video FALLO LA CARGA");
        RequestVideoReward();
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        print("SE CERRO EL ANUNCIO INTERSTICIAL");
        interstitial.Destroy();
        RequestInterstitial();

    }
    private void HandleRewardedAdClosed(object sender, EventArgs e)
    {
        print("SE CERRO EL VIDEO BONIFICADO");
        RequestVideoReward();
    }



    private void HandleUserEarnedReward(object sender, Reward e)
    {
        Debug.Log("SE TERMINO DE VER EL VIDEO BONIFICADO");

        if (FindObjectOfType<controler>() != null) FindObjectOfType<controler>().volverajugaranuncio();
    }


}




