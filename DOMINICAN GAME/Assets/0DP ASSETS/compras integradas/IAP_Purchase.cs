using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Purchasing;
using System;

public class IAP_Purchase : MonoBehaviour, IStoreListener {

	#region DEBUG
	public InitializationFailureReason m_error;
	#endregion


	public static IAP_Purchase instance;
	private static IStoreController m_StoreController;//Es el sistema.
	private static IExtensionProvider m_StoreExtensionProvider;//Donde se guardan los elementos del sistema.

	public static string productoNoAnuncio = "p_noads";//Es el ID nuestro del NO CONSUMIBLE.
	public static string productoConsumible = "p_consumible";//Es el ID nuestro.

	public int isInit;//inicializacion del sistema.
	public bool hayAds;//para check si ya esta hecha o no la compra.
	float espera = 2.0f;//por si falla internet, cuando recargar todo.
	bool inError = false;//para llamar a Inicializar 1 sola vez y evitar posibles congelamientos.
	public bool isChecked = false;//para hacer las cosas solo 1 vez
	///
	void OnDisable()
	{
		StopCoroutine (InternetFail ());
	}
	private void Awake()
	{
		if (instance)
			Destroy (gameObject);
		else {
			instance = this;
			DontDestroyOnLoad (gameObject);
			//-1 = no iniciado.
			//0 =  fallo
			//1 = todo correcto
			isInit = -1;

			if (CheckInternet ()) {
				if (m_StoreController == null) {//si no hemos inicializado
					//Configuramos
					InitPurchasing();
				}
			} else {
				//Error Conexion
				ErrorConexion();
			}
		}
	}
	#region InternetError
	public void ErrorConexion()
	{
		if (inError == false) {
			inError = true;
			StartCoroutine (InternetFail ());
		}
	}
	IEnumerator InternetFail()
	{
		bool load = false;//Evitamos la doble carga
		while (!load) {
			yield return new WaitForSecondsRealtime (espera);
			if (CheckInternet ()) {
				load = true;//hay internet..FIN..
				if(m_StoreController == null)
					InitPurchasing();
			}
		}
	}
	#endregion
	#region IAP
	public void InitPurchasing()
	{
		//si esta ya inicializado NADA
		if (IsInit ()) {
			return;
		}
		//INICIALIZAMOS
		//1r creamos el builder.
		// var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
		//AHora tenemos que anadir los productor que tengamos
	//builder.AddProduct(productoNoAnuncio, ProductType.NonConsumable);
		// builder.AddProduct(productoConsumible, ProductType.Consumable);
		//ahora sincronizamos
	//	UnityPurchasing.Initialize(this, builder);

	}

	public bool IsInit()
	{
		return m_StoreController != null && m_StoreExtensionProvider != null;//si son diferentes a null, devuelve true, TODO BIEN
	}
	#endregion

	#region IAP_EVENTS
	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
		//SE HA INICIALIZADO CORRECTAMENTE
		isInit = 1;
		m_StoreController = controller;
		m_StoreExtensionProvider = extensions;
		//
		checkAds();
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
		//ALGUN TIPO DE FALLO
		isInit = 0;
		hayAds = true;
		EventPurchaser.StateCompraNoAds(hayAds);
		m_error = error;
		StopCoroutine (InternetFail ());
		StartCoroutine (InternetFail ());
		Debug.Log (error);
	}
	#endregion
	#region ProductosChecks
	public void checkAds()
	{
		if (isChecked == false) {
			isChecked = true;
			checkProduct ();//vemos los estados de los productos que VENDEMOS
		}
	}

	public void checkProduct()
	{
		//mas validaciones..siempre son buenas
		if (IsInit ()) {
			Product cproduct = m_StoreController.products.WithID (productoNoAnuncio);//recogemos el id de ese producto que tenemos
			//si existe y se ha comprado
			if (cproduct != null && cproduct.hasReceipt) {
				hayAds = false;//Ya tenemos el producto comprado
			} else {
				hayAds = true;//AUN LO TENEMOS QUE COMRPAR
			}
		}
		//no se ha inicializado
		else {
			hayAds = true;//SI FALLA PUES METEMOS ADS
		}

		//
		EventPurchaser.StateCompraNoAds(hayAds);
	}
	#endregion
	#region COMPRAR
	public void BuyProductNoAds()
	{
		BuyProducID (productoNoAnuncio);
	}
	public void BuyConsumible()
	{
		BuyProducID (productoConsumible);
	}
	void BuyProducID(string productID)
	{
		if (IsInit ()) {

			Product product = m_StoreController.products.WithID (productID);//recogemos ese producto
			if (product != null && product.availableToPurchase) {//si existe y esta disponible para comprar
				//SE REALIZA LA COMPRA


				Debug.Log ("COMPRA DE " + product.definition.id);
				m_StoreController.InitiatePurchase (product);//se inica la compra

			} else {
				Debug.Log("Falló compra");
				//FALLO
			}

		} else {
			Debug.Log("No iniciado");
			//ERROR-> A fallado algo en la INICIALIZACION
		}
	}
	// Este código es para restaurar las compras en iOS. Funciona exclusivamente en esa plataforma.
	public void RestorePurchases()
	{
		if (IsInit())
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer ||
				Application.platform == RuntimePlatform.OSXPlayer)
			{
                //Obtener extensión específica para apple
			//	var appleExtension = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
                //Inicia la llamada a la restauración
			
			}
			// Otherwise ...
			else
			{
				//Corriendo en otra plataforma
				Debug.Log("Está corriendo en: " + Application.platform + " No existe Restore");
			}
		}
	}

	//EVENTOs
	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		if (String.Equals(args.purchasedProduct.definition.id, productoConsumible, StringComparison.Ordinal)){
			Debug.Log ("COMPRA Consumible = " + args.purchasedProduct.definition.id);
			//hayAds = false;//DESACTIVAMOS
			PlayerPrefs.SetInt("anuncios", 0);
			EventPurchaser.StateConsumible (true);//bueno!
		}
		else if (String.Equals(args.purchasedProduct.definition.id, productoNoAnuncio, StringComparison.Ordinal)){
			Debug.Log ("COMPRA REALIZADA = " + args.purchasedProduct.definition.id);
			hayAds = false;//DESACTIVAMOS
			PlayerPrefs.SetInt("anuncios", 0);
			EventPurchaser.StateCompraNoAds (hayAds);
		} else {
		
			Debug.Log ("FALLO EN COMPRA" + args.purchasedProduct.definition.id);
		}
		//devolvemos si hay exito o no.
		return PurchaseProcessingResult.Complete;
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason){
		//NO se a hecho la compra por alguna razon 
		Debug.Log("ERROR EN COMPRA para el productor = "+ product.definition.storeSpecificId +" RAZON : "+ failureReason);
		EventPurchaser.StateConsumible (false);//FALLO
	}


	#endregion


	#region Internet
	public bool CheckInternet()
	{
		bool isInternetOn = false;
		if (Application.internetReachability == NetworkReachability.NotReachable) {
			isInternetOn = false;//NO HAY INTERNTET

		} else if (Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork) {
			isInternetOn = true;//PER WIFI
		}
		else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork) {
			isInternetOn = true;//por data
		}

		return isInternetOn;
	}
	#endregion


	//final
}
//Evento para decirle a la script TIENDA que ya tenemos el estado de si se ha comprado o no el producto concreto.
public class EventPurchaser{
	public delegate void OnStateCompraNoAds(bool state);
	public static event OnStateCompraNoAds onStateCompraNoAds;
	public static void StateCompraNoAds(bool state)
	{
		if (onStateCompraNoAds != null) {
			onStateCompraNoAds (state);
		}
	}
	//Para el consumible!
	public delegate void OnStateConsumible(bool state);
	public static event OnStateConsumible onStateConsumible;
	public static void StateConsumible(bool state)
	{
		if (onStateConsumible != null) {
			onStateConsumible (state);
		}
	}
}
