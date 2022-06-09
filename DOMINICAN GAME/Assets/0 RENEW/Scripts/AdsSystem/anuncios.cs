using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class anuncios : MonoBehaviour
{

    public static anuncios ads; 
   // private InterstitialAd inter;
   
    [SerializeField] private string appID = "";
    [SerializeField] private string interID = "";
    [SerializeField] private string recoID = "";

    
    public void muestravideo()
    {
        print("mostrando video anuncio");
      //  mostrarreco();
    }

    public void muestrainterticial()
    {
     //   mostrarinter();
    }



    private void pedirinter()
    {
        //inter = new InterstitialAd(interID);
        //AdRequest pedir = new AdRequest.Builder().Build();
        //inter.LoadAd(pedir);

    }
   // private RewardedAd rewardedAd;
    public void reco()
    {

    //    AdRequest request = new AdRequest.Builder().Build();
    //    // Load the rewarded ad with the request.
    //    this.rewardedAd.LoadAd(request);

    }

    public void mostrarinter()
    {
     //   inter.Show();
     //   inter.Destroy();
        pedirinter();
    }
    public void mostrarreco()
    {

      //  if (this.rewardedAd.IsLoaded())
   //     {
  //        this.rewardedAd.Show();
   //         Time.timeScale = 1;
   //         llamar();
   //     }

  //     Time.timeScale = 1;

    }


    private void Awake()
    {

 //       ads = this;


     //   MobileAds.Initialize(initStatus => { });
        llamar();

    }

    public void llamar()
    {
    //    this.rewardedAd = new RewardedAd(recoID);

        // Called when an ad request has successfully loaded.

        // Called when an ad request failed to load.
     //   this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.

        // Called when an ad request failed to show.
     //   this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
    //    this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
    //    AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
     //   this.rewardedAd.LoadAd(request);
        //   MobileAds.Initialize(appID);

    }



    //public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    //{
    //    MonoBehaviour.print(
    //        "HandleRewardedAdFailedToLoad event received with message: "
    //                         + args.Message);
    //}



    //public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    //{
    //    MonoBehaviour.print(
    //        "HandleRewardedAdFailedToShow event received with message: "
    //                         + args.Message);
    //}



    //public void HandleUserEarnedReward(object sender, Reward args)
    //{
    //    string type = args.Type;
    //    double amount = args.Amount;
    //    MonoBehaviour.print(
    //        "HandleRewardedAdRewarded event received for "
    //                    + amount.ToString() + " " + type);
    //    //quiero darle una moneda 
    //}

     
}
