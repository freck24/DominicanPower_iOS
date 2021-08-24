using System;
using UnityEngine.UI;
using UnityEngine;



[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]

public class Opcionesbotones : MonoBehaviour {

	private Text texto = null;
	private Button boton = null;
	private Image imagen = null;
	private Color color = Color.black;

	public Opciones Opciones { get; set; }

	private void Awake()
	{
		texto = transform.GetChild(0).GetComponent<Text>();
		boton = GetComponent<Button>();
		imagen = GetComponent<Image>();
		color = imagen.color;
	}

	public void Construir(Opciones opciones, Action<Opcionesbotones> llamar)
	{
		boton.onClick.RemoveAllListeners();
		texto.text = opciones.respuesta;
		boton.enabled = true;
		imagen.color = color;
		Opciones = opciones;
		boton.onClick.AddListener(delegate
		{
			llamar(this);
		});



	}

	public void SetColor(Color c)
	{
		boton.enabled = false;
		imagen.color = c;
	}


}

