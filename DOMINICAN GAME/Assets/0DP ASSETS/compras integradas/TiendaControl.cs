using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaControl : MonoBehaviour {
	public GameObject bt_NoAds;
	public GameObject buttonRestore;
	//public GameObject bannerAnuncio;
	void OnEnable()
	{
		EventPurchaser.onStateCompraNoAds += EventTienda;
	}
	void OnDisable()
	{
		EventPurchaser.onStateCompraNoAds -= EventTienda;
	}
	void EventTienda(bool s)
	{
		if (s) {
			//HAY ANUNCIOS
			bt_NoAds.SetActive(true);
		//	bannerAnuncio.SetActive (true); //aqui activa los anuncios
			
		} else {
			//NO HAY ANUNCIOS
			bt_NoAds.SetActive(false);
			//bannerAnuncio.SetActive (false);
		}
	}
	//
	public void ButtonComprarNoAds()
	{
		Debug.Log("Tratando de comprar No Ads");
		IAP_Purchase.instance.BuyProductNoAds ();
        
	}
	public void ButtonConsumible()
	{
		Debug.Log("Tratando de comprar Monedas");
		IAP_Purchase.instance.BuyConsumible ();
	}

    public void RestorePurachases()
    {
		IAP_Purchase.instance.RestorePurchases();
    }
	void Start()
	{
#if UNITY_IOS
		buttonRestore.SetActive(true);
#else
		buttonRestore.SetActive(false);
	//	iOsButtonsContainer.SetActive(false);
	//	androidButtonsContainer.SetActive(true);
#endif
		//es init!
		if (IAP_Purchase.instance.isInit == 1) {
			if (IAP_Purchase.instance.hayAds == false) {
				bt_NoAds.SetActive (false);
				//	bannerAnuncio.SetActive (false);
				PlayerPrefs.SetInt("anuncios", 0);

			} else {
				bt_NoAds.SetActive (true);
				//	bannerAnuncio.SetActive (true);
				PlayerPrefs.SetInt("anuncios", 1);
			}
		} else {
			//bt_NoAds.SetActive (false);//ya que la tienda no esta disponible
		//	bannerAnuncio.SetActive (true);
		}
	}
}
