using UnityEngine.Events;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class IniciadorAds : MonoBehaviour
{
    public AudioSource sou;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;


    public static bool Iniciado;
    public static IniciadorAds statico;
    private static RewardedAd Revivir_Reward;
    

    public string ID_anuncioBonificado;


    

    public void Start()
    {

        if (statico != null)
        {
            //    DestroyImmediate(this.gameObject);
            print("fafafa");
            return;
        }
  
    print("Anuncios Iniciados: " + Iniciado);
    if(!Iniciado)
    { 
    MobileAds.Initialize(initStatus => { });
    Iniciado = true;
    }
        DontDestroyOnLoad(this.gameObject);
        statico = this;

#if UNITY_ANDROID
        ID_anuncioBonificado = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
        ID_anuncioBonificado = "ca-app-pub-3940256099942544/1712485313";
#else
        ID_anuncioBonificado = "ca-app-pub-3940256099942544/5224354917";
#endif


        Revivir_Reward = new RewardedAd(ID_anuncioBonificado);


        // Called when an ad request has successfully loaded.
        Revivir_Reward.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad is shown.
        Revivir_Reward.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        Revivir_Reward.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        Revivir_Reward.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        Revivir_Reward.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        Revivir_Reward.LoadAd(request);

         
 
    }

    public void OnLevelWasLoaded(int level)
    {
    
    }

    void CargarAnuncio()
    {
        sou.PlayOneShot(clip1);
        AdRequest request = new AdRequest.Builder().Build();
        if (!Revivir_Reward.IsLoaded()) Revivir_Reward.LoadAd(request);
    }


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        sou.PlayOneShot(clip2);

        print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        sou.PlayOneShot(clip3);
        print("HandleRewardedAdFailedToLoad event received with message: ");
    }


    public void OnAdClosed(object sender, AdFailedToLoadEventArgs args)
    {
        sou.PlayOneShot(clip3);
        if (FindObjectOfType<controler>() != null) FindObjectOfType<controler>().volverajugaranuncio();

        print("HandleRewardedAdFailedToLoad event received with message: " );
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
    print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        sou.PlayOneShot(clip4);
        print("HandleRewardedAdFailedToShow event received with message: " + args.Message);


    }

    public void CreateAndLoadRewardedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif

        Revivir_Reward = new RewardedAd(adUnitId);

        Revivir_Reward.OnAdLoaded += HandleRewardedAdLoaded;
        Revivir_Reward.OnUserEarnedReward += HandleUserEarnedReward;
        Revivir_Reward.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        Revivir_Reward.LoadAd(request);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        sou.PlayOneShot(clip5);
        print("HandleRewardedAdClosed event received");
        this.CreateAndLoadRewardedAd();

    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        sou.PlayOneShot(clip6);
        print("HandleRewardedAdClosed event meeeeww");
        Start();

        // Load the rewarded ad with the request.
        if (FindObjectOfType<controler>() != null) FindObjectOfType<controler>().volverajugaranuncio();
    }

    private void HandleInitCompleteAction(InitializationStatus initstatus)
    {
        // Callbacks from GoogleMobileAds are not guaranteed to be called on
        // main thread.
        // In this example we use MobileAdsEventExecutor to schedule these calls on
        // the next Update() loop.
        MobileAdsEventExecutor.ExecuteInUpdate(() =>
        {
        sou.PlayOneShot(clip7);
            Start();

        });
    }



    public void HandleUserEarnedReward(object sender, Reward args)
    {
        sou.PlayOneShot(clip8);
        string type = args.Type;
    double amount = args.Amount;
    print("HandleRewardedAdRewarded event received for " + amount.ToString() + " " + type);
        if (FindObjectOfType<controler>() != null) FindObjectOfType<controler>().volverajugaranuncio();



    }



    public void Cargar_RevivirAnuncio()
    {
 
        print("anuncio revivir: LLAMADO");

        if (Revivir_Reward.IsLoaded())
        {
#if UNITY_EDITOR
            HandleRewardedAdClosed(null, null);
#endif
            print("anuncio revivir: ESTA CARGADO");
            Revivir_Reward.Show();
            print("anuncio revivir: SE MOSTRARA");

        }
    }

}