using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class scriptEjemploVR : MonoBehaviour

{


    public string rewaredunidID = "ca-app-pub-3940256099942544/5224354917";
    private RewardedAd rewaredAD;
    int moneda;
    public static scriptEjemploVR instance;



    private void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

    }





    public void OnEnable()
    {
        rewaredAD = new RewardedAd(rewaredunidID);
        AdRequest adRECu = new AdRequest.Builder().Build();
        rewaredAD.LoadAd(adRECu);

        rewaredAD.OnUserEarnedReward += HandleUserEarnedReward;
        rewaredAD.OnAdClosed += HandleRewardedAdClosed;

    }



    private void HandleRewardedAdClosed(object sender, EventArgs e)
    {
        Debug.Log("ejecutar algo cuando se cierra el anuncio");
        cerraAd();
    }



    private void HandleUserEarnedReward(object sender, Reward e)
    {
        Debug.Log("se a reclamado la recompensa" + moneda);
        if (FindObjectOfType<controler>() != null) FindObjectOfType<controler>().volverajugaranuncio();
    }





    public void ShowREWAD()
    {
        if (rewaredAD.IsLoaded())
            rewaredAD.Show();
    }



    public void cerraAd()

    {
        Debug.Log("se cerro felicitaciones");
        OnEnable();
    }

}


//termino el codigo
