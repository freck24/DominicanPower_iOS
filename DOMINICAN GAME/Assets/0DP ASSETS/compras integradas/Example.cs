using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Example : MonoBehaviour {
	//public Text txt;
	//public Text txtError;
	
	public Text txtScore;
	public float score;
	
	public GameObject panelError;
	void OnEnable()
	{
		EventPurchaser.onStateConsumible += EventTienda;
	}
	void OnDisable()
	{
		EventPurchaser.onStateConsumible -= EventTienda;
	}
	void EventTienda(bool s)
	{
		if (s) {

			score = PlayerPrefs.GetFloat("dinero", 0)+ 50000;
			PlayerPrefs.SetInt("VIP", 1);
			PlayerPrefs.SetFloat("dinero",  score);
			
			txtScore.text = score.ToString ();
		}
		else
			panelError.SetActive (true);
	}
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetFloat("dinero", 0);
		txtScore.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	//	txt.text = IAP_Purchase.instance.isInit.ToString ();
	//	txtError.text = IAP_Purchase.instance.m_error.ToString ();
	}
	public void ButtonClose()
	{	
		panelError.SetActive (false);
	}
}
