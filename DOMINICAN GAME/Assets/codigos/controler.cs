using System.Collections;

using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controler : MonoBehaviour
{
	public Transform[] bbb;
	

	public Vector3[] t1 =new Vector3[7];
	public float diferencia;
	
	public void asignacion()
    { 
	   for(int i=0; i < t1.Length; i++)
        {
			t1[i] = bbb[i].position;
        }

		diferencia = -t1[5].y + t1[6].y;
    }
	
	public void controles2()
    {
		bbb[0].position = t1[1];
		bbb[1].position = t1[0];
		bbb[3].position = t1[4];
		bbb[4].position = t1[3];
		bbb[2].position = t1[6];
		bbb[6].position = t1[2];
		bbb[5].position = new Vector3(t1[2].x, t1[2].y - diferencia,t1[2].z);
		
    }	
	
	public void controles3()
    {
		bbb[1].position = t1[2];
		bbb[2].position = t1[1];
	}
	
	
	public void controles4()
    {
		bbb[2].position = t1[1];
		bbb[4].position = t1[2];
		bbb[1].position = t1[4];
	}

	public void controles5()
	{
		bbb[0].position = t1[1];
		bbb[1].position = t1[6];
		bbb[3].position = t1[4];
		bbb[4].position = t1[3];
		bbb[2].position = t1[0];
		bbb[6].position = t1[2];
		bbb[5].position = new Vector3(t1[2].x, t1[2].y - diferencia, t1[2].z);
	}
	public void controles6()
	{
		bbb[0].position = t1[1];
		bbb[1].position = t1[3];
		bbb[3].position = t1[4];
		bbb[4].position = t1[6];
		bbb[2].position = t1[0];
		bbb[6].position = t1[2];
		bbb[5].position = new Vector3(t1[2].x, t1[2].y - diferencia, t1[2].z);

	}

	public GameObject cargarmenu;
	public GameObject cargarcolmado;

	public void carm()
    {
		cargarmenu.SetActive(true);
    }
	public void carcol()
    {
		cargarcolmado.SetActive(true);
    }

	public GameObject CONJURO;
	public Transform botonbruja;
	public bool puedeembrujar = false;
	public Color COLORVEREE;
	public Color COLORROSA;
	public Image BRUJAIMAGE;
	public float tiempoespera = 2;
	public void corutinabrujeria()
    {
		StartCoroutine(brujeri());
    }
	IEnumerator brujeri()
    {
		botonbruja.localScale = new Vector3(botonbruja.localScale.x, PlayerPrefs.GetFloat("local",0), botonbruja.localScale.z);
		BRUJAIMAGE.color = COLORROSA;
		while (botonbruja.localScale.y<3.10)
        {
			yield return new WaitForSecondsRealtime(tiempoespera);
			botonbruja.localScale = new Vector3(botonbruja.localScale.x, botonbruja.localScale.y + 0.05f, botonbruja.localScale.z);

        }
	
		puedeembrujar = true;
		BRUJAIMAGE.color = COLORVEREE;
		

    }
	

	public BRUJERIA bruj;
	public GameObject menobruja;

	public bool brujeriaactiva = false;


	IEnumerator TIEPO()
    {
		yield return new WaitForSecondsRealtime(2);
		Time.timeScale = 1;
    }
	public GameObject panelconjuro;
	public void CONJUROS()
    {
		if (PlayerPrefs.GetInt("brujeria", 0) == 1 && vidas>0)
        {
			if (puedeembrujar && brujeriaactiva==false)
			{ 
				adelante();
				h = 0;
				anim.SetInteger("conjuro", 0);
				anim.SetBool("magic", true);
				
				panelconjuro.SetActive(true);
				Time.timeScale = 0.3f;
				CONJURO.SetActive(true);
				brujeriaactiva = true;
				bruj.abrir();
				puedeembrujar = false;
				
				PlayerPrefs.SetFloat("local", 0);
				botonbruja.localScale = new Vector3(botonbruja.localScale.x, 0, botonbruja.localScale.z);

			}
		}
        else
        {
			menobruja.SetActive(false);
			menobruja.SetActive(true);
        }

    }

	public void InstanciasN()
	{
		if(nivel<86)
		Instantiate(NIVELES[0], PNIVELES[0].position, Quaternion.identity);
	}public void InstanciasNjn()
	{
		if(PlayerPrefs.GetFloat("jn", 1)<86)
			Instantiate(NIVELES[0], PNIVELES[0].position, Quaternion.identity);
	}

	#region variables 

	public GameObject[] NIVELES = new GameObject[2];
	public Transform[] PNIVELES = new Transform[2];




    public Transform posicioninicial;
	public bool vibraniun = true;
	public bool bugs = false;
	public bool f = false;
	private Rigidbody2D r;
	// Use this for initialization

	public GameObject cam1;
	public GameObject cam2;
	//public GameObject transi;
	public float sj = 0;
	public float ba = 0;
	public float sa = 0;

	public float nbani = 0;
	public float ssd = 0;
	public float speed = 20f;
	public float fuerza = 5f;
	public float maxspeed = 13f;
	bool salto = false;
	public float h = 0f;
	public Text contador = null;
	public Text contador2 = null;
	public bool serio = true;
	public bool mangacami = false;
	public float paus = 1f;
	public float nivel = 1;
	public float vidas = 3f;
	public GameObject canvasmensajesdemeneso;
	public float cplatano = 0;

	public float provisiones;
	public AudioClip saltoauido;

	//public Generador generarp;
	public puntos puntos;
	public GameObject destruir;
	public GameObject destruir2;
	public GameObject cam;
	public GameObject walk;
	public GameObject preguntas;
	public GameObject boton;
	public GameObject ANIMA;
	public GameObject m1;
	public GameObject m2;
	public Image i = null;
	public alarma ali;
	public float velmin = 5f;
	public bool continuar = false;
	public Color CO = Color.blue;
	public Color CO2 = Color.blue;
	public GameObject boto;
	public GameObject sprite;
	public Transform spri;
	public float timepregunta1 = 3f;
	public float platano = 0f;
	public float g = 0f;
	bool tigre = false;
	Animator anim;
	public mov motorita;


	Vector3 gco;
	Vector3 gc;
	Vector3 pos;
	public Text niveles;
	public AudioClip ganar;
	public AudioClip ganarp;
	public AudioClip fail;
	public AudioClip alcantarilla;
	public AudioClip d1;
	public AudioClip d2;
	public AudioClip d3;
	public AudioClip d4;
	public AudioClip d5;

	public bool ga = false;
	public bool pe = false;
	public AudioClip perder;
	public gestiondemusica camara;
	Vector3 vt;
	public GameObject gorra;
	public GameObject gafas;
	public GameObject gato;
	public GESTORPRINCIPAL gest;
	public gestorauidos gestora;
	public GameObject n1;
	public GameObject n2;
	public GameObject n3;
	public GameObject n4;
	public GameObject n5;
	public GameObject n6;
	public GameObject n7;
	public GameObject n8;
	public GameObject n9;
	public GameObject n10;
	public GameObject n11;
	public GameObject n12;
	public GameObject n13;
	public GameObject n14;
	public GameObject n15;
	public GameObject n16;
	public GameObject n17;
	public GameObject n18;
	public GameObject n19;
	public GameObject n20;
	public GameObject n21;
	public GameObject n22;
	public GameObject n23;
	public GameObject n24;
	public GameObject n25;
	public GameObject n26;
	public GameObject n27;
	public GameObject n28;
	public GameObject n29;
	public GameObject n30;
	public GameObject n31;
	public GameObject n32;
	public GameObject n33;
	public GameObject n34;
	public GameObject n35;
	public GameObject n36;
	public GameObject n37;
	public GameObject n38;
	public GameObject n39;
	public GameObject n40;
	public GameObject n41;
	public GameObject n42;
	public GameObject n43;
	public GameObject n44;
	public GameObject n45;
	public GameObject n46;
	public GameObject n47;
	public GameObject n48;
	public GameObject n49;
	public GameObject n50;
	public GameObject n51;
	public GameObject n52;
	public GameObject n53;
	public GameObject n54;
	public GameObject n55;
	public GameObject n56;
	public GameObject n57;
	public GameObject n58;
	public GameObject n59;
	public GameObject n60;
	public GameObject n61;
	public GameObject n62;
	public GameObject n63;
	public GameObject n64;
	public GameObject n65;
	public GameObject n66;
	public GameObject n67;
	public GameObject n68;
	public GameObject n69;
	public GameObject n70;
	public GameObject n71;
	public GameObject n72;
	public GameObject n73;
	public GameObject n74;
	public GameObject n75;
	public GameObject n76;
	public GameObject n77;
	public GameObject n78;
	public GameObject n79;
	public GameObject n80;
	public GameObject n81;
	public GameObject n82;
	public GameObject n83;
	public GameObject n84;
	public GameObject n85;


	public Generador generarp;
	public GameObject cabeza;

	public Color color1;
	public Color color2;
	public Color color3;
	public Color color4;
	public Color color5;
	public Image d;
	public Image iz;
	public Image a;
	public Image p;
	public Image c;


	Vector3 rota;

	public float cuenta = 1;

	private AudioSource audio;
	private AudioSource audio2;



	public Text text = null;
	public GameObject perdermensaje;


	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	public GameObject b4;


	public GameObject fin1;
	public GameObject fin2;
	public GameObject fin3;
	public GameObject fin4;
	public GameObject fin5;
	public GameObject fin6;
	public GameObject fin7;
	public GameObject fin8;
	public GameObject fin9;
	public GameObject fin10;
	public GameObject fin11;
	public GameObject fin12;
	public GameObject fin13;
	public GameObject fin14;
	public GameObject fin15;
	public GameObject fin16;
	public GameObject fin17;
	public GameObject fin18;
	public GameObject fin19;
	public GameObject fin20;
	public GameObject fin21;
	public GameObject fin22;
	public GameObject fin23;
	public GameObject fin24;
	public GameObject fin25;
	public GameObject fin26;
	public GameObject fin27;
	public GameObject fin28;
	public GameObject fin29;
	public GameObject fin30;
	public GameObject fin31;
	public GameObject fin32;
	public GameObject fin33;
	public GameObject fin34;
	public GameObject fin35;
	public GameObject fin36;
	public GameObject fin37;
	public GameObject fin38;
	public GameObject fin39;
	public GameObject fin40;
	public GameObject fin41;
	public GameObject fin42;
	public GameObject fin43;
	public GameObject fin44;
	public GameObject fin45;
	public GameObject fin46;
	public GameObject fin47;
	public GameObject fin48;
	public GameObject fin49;
	public GameObject fin50;
	public GameObject fin51;
	public GameObject fin52;
	public GameObject fin53;
	public GameObject fin54;
	public GameObject fin55;
	public GameObject fin56;
	public GameObject fin57;
	public GameObject fin58;
	public GameObject fin59;
	public GameObject fin60;
	public GameObject fin61;
	public GameObject fin62;
	public GameObject fin63;
	public GameObject fin64;
	public GameObject fin65;
	public GameObject fin66;
	public GameObject fin67;
	public GameObject fin68;
	public GameObject fin69;
	public GameObject fin70;
	public GameObject fin71;
	public GameObject fin72;
	public GameObject fin73;
	public GameObject fin74;
	public GameObject fin75;
	public GameObject fin76;
	public GameObject fin77;
	public GameObject fin78;
	public GameObject fin79;
	public GameObject fin80;
	public GameObject fin81;
	public GameObject fin82;
	public GameObject fin83;
	public GameObject fin84;
	public GameObject fin85;
	
	public GameObject fondo;
	public AudioClip ay;

	public GameObject dia1;
	public GameObject dia2;
	public GameObject dia3;
	public GameObject dia4;
	public GameObject dia5;
	public GameObject dia6;
	public posicionnuevo retorno;

    #endregion
    public void menu()
	{
		SceneManager.LoadScene("inicio");
	}//	public AudioClip sondiogrito;
	public float vidasi = 3;
	public Text dias;
	//CharacterController player;

	public Text cc;
	public bool ac = false;
	  public void vivi()
    {
		if (vibraniun)
		{
			Vibration.Vibrate(15);
		}
    }
		public void actcc()
    {
		ac = !ac;
		if (!ac)
		{
			cc.text = "ACTIVAR CAMINAO";
        }
        else
        {
			cc.text = "DESACTIVAR CAMINAO";
		}
    }



	Vector3 electric;

	public GameObject inmod;
	public int calidad;
	public void calidadgrafica()
    { calidad = PlayerPrefs.GetInt("Q", 5);
		QualitySettings.SetQualityLevel(calidad, true);
        switch (calidad)
        {
			case 0:
				
				Screen.SetResolution(270, 480, true);
				break;
			case 1:
				Screen.SetResolution(360, 640, true);
				break;
			case 2:
				Screen.SetResolution(540, 960, true);
				break;
			case 3:
				Screen.SetResolution(540, 960, true);
				break;
			case 4:
				Screen.SetResolution(720, 1280, true);
				break;
			case 5:
				Screen.SetResolution(720, 1280, true);
				break;
        }
	}


	public bool noaplica = false;

	public void connnn()
    {

		switch(PlayerPrefs.GetInt("controles", 3))
        {
			case 0:
				break;

			case 1:
				controles2();
				break;

			case 2:
				controles3();
				break;

			case 3:
				controles4();
				break;

			case 4:
				controles5();
				break;

			case 5:
				controles6();
				break;
		}
		

	}


	void Start()
	{
		asignacion();
		//PlayerPrefs.SetInt("controles", 5);
		if(noaplica==false)
			connnn();


		
		calidadgrafica();

		//PlayerPrefs.SetInt("brujeria", 1); // quitar
	//	PlayerPrefs.SetFloat("nivel", 86);


        if (PlayerPrefs.GetInt("brujeria", 0) == 1)
        {
			StartCoroutine(brujeri());
		}
		
		PlayerPrefs.SetInt("ff", 0); // investuigar que es esi
		
		if (PlayerPrefs.GetInt("vibrar", 1) == 0)
        {
			vibraniun = false;
        }
	
		textodinero.text = "" + PlayerPrefs.GetFloat("dinero", 0).ToString();

		if (PlayerPrefs.GetFloat("inmortal", 0) > 0)
        {
			inmod.SetActive(true);
			inmortal = true;
			PlayerPrefs.SetFloat("inmortal", PlayerPrefs.GetFloat("inmortal", 0) - 1);
        }
        else
        {
			inmod.SetActive(false);
			inmortal = false;
        }
		 
		electric = new Vector3(elec.transform.localScale.x, elec.transform.localScale.y, elec.transform.localScale.z);
			
		color1 = d.color;
		color2 = iz.color;
		color3 = a.color;
		color4 = p.color;
		color5 = c.color;

		dias.text = "DÍA " + PlayerPrefs.GetFloat("dia", 1);

		couna = true;
		contadorpoder = PlayerPrefs.GetFloat("poder", 0);
		PLATANOPOWER.text = "" + contadorpoder.ToString("f0");
		vidasi = PlayerPrefs.GetFloat("vidas", 3);
		vidas = PlayerPrefs.GetFloat("vidas", 3);
		boton.SetActive(true);

		if (vidas < 1)
		{
			vidas = 1;
		}

		h = 0;
	
		confirma = true;
		
		nivel = PlayerPrefs.GetFloat("nivel", 1);


        if (nivel % 3 == 0)
        {
			cam2.SetActive(true);
			cam1.SetActive(false);
		}


		ssd = PlayerPrefs.GetFloat("sd", 1);
		sj = PlayerPrefs.GetFloat("sj", 1);
		sa = PlayerPrefs.GetFloat("sa", 1);
		nbani = PlayerPrefs.GetFloat("bani", 1);
		
		if (PlayerPrefs.GetFloat("gorras", 0) == 1)
		{
			gorra.SetActive(true);
		} if (PlayerPrefs.GetFloat("gafas", 0) == 1) {
			gafas.SetActive(true);
		} if (PlayerPrefs.GetFloat("gatos", 0) == 1) {
			gato.SetActive(true);
		}



		if (PlayerPrefs.GetFloat("jn", 0) == 0)
		{





			InstanciasN();

			nivelet();


		}
		else
		{

			jn();

			InstanciasNjn();
		}

			

		muerte = true;
	
		r = GetComponent<Rigidbody2D>();
		serio = true;
		anim = GetComponent<Animator>();
		audio = GetComponent<AudioSource>();
		audio2 = GetComponent<AudioSource>();
		gc = new Vector3(sprite.transform.localScale.x, sprite.transform.localScale.y, sprite.transform.localScale.z);
	
		vt = destruir.transform.position;
		platano = PlayerPrefs.GetFloat("platanos", 0f); // aqui estamos obtenindo la nueva puntuacion
		provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
		contador.text = provisiones.ToString();
		if (PlayerPrefs.GetFloat("prime", 0f) == 0)
		{
			PlayerPrefs.SetFloat("platano", 0f); // aqui nos preguntamos si es la primera vez que se juega y de ser asi reiniciamos el contador
		}
		if (ciclo)
		{
			meta.transform.position = new Vector3(meta.transform.position.x + (PlayerPrefs.GetFloat("nivel", 0) - 3) * 15, meta.transform.position.y, meta.transform.position.z);

		}



		unave = true;


		paus = 1;


		anim.SetBool("deten", true);
	}

	public GameObject n86;

	#region Switchniveles


	public void jn()
	{



		switch (PlayerPrefs.GetFloat("jn", 1))
		{
			case 1:
				generarp.cancelargen();
				StartCoroutine(colores());
				StartCoroutine(retraso());
				a4.SetActive(false);
				niveles.text = "CAPOTILLO";

				//	n1.SetActive(true);

				break;
			case 2:
				niveles.text = "LOS MINA";
				//	n5.SetActive(true);
				break;
			case 3:
				niveles.text = "LOS GUANDULES";
				//	n3.SetActive(true);
				break;
			case 4:
				niveles.text = "SABANA PERDIDA";
				//	n4.SetActive(true);
				break;
			case 14:


				niveles.text = "GUALEY";
				//	n2.SetActive(true);
				break;

			case 8:
				niveles.text = "LOS JARDINES";
				//	n9.SetActive(true);
				break;

			case 10:
				niveles.text = "ZONA COLONIAL";
				//	n11.SetActive(true);


				break;

			case 11:
				niveles.text = "RIO OZAMA";
				//	n12.SetActive(true);
				generarp.cancelargen();
				fondo.SetActive(false);


				break;

			case 5:
				niveles.text = "UASD";
				//	n15.SetActive(true);
				generarp.cancelargen();


				break;
			case 15:
				niveles.text = "UASD";
				//	n15.SetActive(true);
				generarp.cancelargen();


				break;






			case 9:
				niveles.text = "Parque Los Haitices";
				//	n10.SetActive(true);
				generarp.cancelargen();

				break;



			case 12:
				niveles.text = "Entrada a bani";
				//	n13.SetActive(true);
				fondo.SetActive(true);


				break;
			case 13:
				niveles.text = "Dunas de bani";
				//	n14.SetActive(true);


				break;






			case 7:
				niveles.text = "PLAYA SAN RAFAEL";
				//	n7.SetActive(true);

				cam1.SetActive(true);
				cam2.SetActive(false);

				break;

			case 6:
				niveles.text = "CENTRO DE SAN JUAN";
				//	n6.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);

				break;

			case 16:
				niveles.text = "Playa Salina";
				//	n16.SetActive(true);
				break;

			case 17:
				niveles.text = "BOSQUE";
				//	n17.SetActive(true);
				break;
			case 18:
				niveles.text = "LOS HAITICES"; //implementsa
											   //	n18.SetActive(true);
				break;
			case 19:
				niveles.text = "EL PICO DUAERTE";
				//	n19.SetActive(true);
				break;
			case 20:
				niveles.text = "SAN JUAN";
				//	n20.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);
				break;




			case 21:
				niveles.text = "Teleferico";
				//	n21.SetActive(true);
				break;
			case 22:
				niveles.text = "LA BARQUITA";
				//	n22.SetActive(true);
				break;
			case 23:
				niveles.text = "RIO OZAMA";
				//	n23.SetActive(true);
				fondo.SetActive(false);
				break;
			case 24:
				niveles.text = "GUACHUPITA";
				//	n24.SetActive(true);
				fondo.SetActive(true);
				break;
			case 25:
				niveles.text = "LA CIENAGA"; //implementsa
											 //	n25.SetActive(true);
				break;
			case 26:
				niveles.text = "VILLA MELLA";
				//	n26.SetActive(true);
				break;
			case 27:
				niveles.text = "EL CACHON";
				//	n27.SetActive(true);
				break;
			case 28:
				niveles.text = "LOS FRAILES";
				//	n28.SetActive(true);
				break;
			case 29:
				niveles.text = "LOS JIRASOLES";
				//	n29.SetActive(true);
				break;
			case 30:
				niveles.text = "GUARICANO";
				//	n30.SetActive(true);
				break;
			case 31:
				niveles.text = "PANTOJA";
				//	n31.SetActive(true);
				break;
			case 32:
				niveles.text = "LOS TRES BRAZOS";
				//	n32.SetActive(true);
				break;
			case 33:
				niveles.text = "ALMA ROSA";
				//	n33.SetActive(true);
				break;
			case 34:
				niveles.text = "NEYBA";
				//	n34.SetActive(true);
				break;
			case 35:
				niveles.text = "VILLA FARO";
				//	n35.SetActive(true);
				break;
			case 36:
				niveles.text = "CONSTANZA";
				//	n36.SetActive(true);
				break;
			case 37:
				niveles.text = "CONSTANZA 2";
				//	n37.SetActive(true);
				break;
			case 38:
				niveles.text = "VILLAS AGRICOLAS";
				//	n38.SetActive(true);
				break;
			case 39:
				niveles.text = "INVIVIENDA";
				//	n39.SetActive(true);
				break;
			case 40:
				niveles.text = "HAINAMOSA";
				//	n40.SetActive(true);
				break;
			case 41:
				niveles.text = "SAN ISIDRO";
				//	n41.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);
				break;
			case 42:
				niveles.text = "VILLA MELLA 2";
				//	n42.SetActive(true);
				break;
			case 43:
				niveles.text = "VILLA MELLA 3";
				//	n43.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);

				break;
			case 44:
				niveles.text = "CONSTANZA 3";
				//	n44.SetActive(true);
				break;
			case 45:
				niveles.text = "BAYAHIBE";
				//	n45.SetActive(true);
				break;
			case 46:
				niveles.text = "LOS ALCARRISOS";
				//	n46.SetActive(true);
				break;
			case 47:
				niveles.text = "SAN ISIDRO 2";
				//	n47.SetActive(true);
				break;
			case 48:
				niveles.text = "CONSTANZA 4";
				//	n48.SetActive(true);

				break;
			case 49:
				niveles.text = "BANI 2";
				//	n49.SetActive(true);
				break;
			case 50:
				niveles.text = "UASD 3";
				//	n50.SetActive(true);
				break;

			case 51:
				niveles.text = "BAYAHIBE 2";
				//	n51.SetActive(true);
				break;
			case 52:
				niveles.text = "CONSTANZA 5";
				//	n52.SetActive(true);

				break;
			case 53:
				niveles.text = "LOS MINA 2";
				//	n53.SetActive(true);
				break;
			case 54:
				niveles.text = "LOS PRADOS";
				//	n54.SetActive(true);
				break;
			case 55:
				niveles.text = "SALCEDO";
				//	n55.SetActive(true);
				break;
			case 56:
				niveles.text = "LOS MAMEYES";
				//	n56.SetActive(true);
				break;
			case 57:
				niveles.text = "APEC";
				//	n57.SetActive(true);
				break;
			case 58:
				niveles.text = "BARAHONA 2";
				//	n58.SetActive(true);
				break;
			case 59:
				niveles.text = "UTESA";
				//	n59.SetActive(true);
				break;
			case 60:
				niveles.text = "MOCA";
				//	n60.SetActive(true);
				break;
			case 61:
				niveles.text = "LA ESCUELITA";
				//	n61.SetActive(true);
				break;
			case 62:
				niveles.text = "INTEC";
				//	n62.SetActive(true);
				break;


			case 63:
				niveles.text = "LA ALTAGRACIA";
				//	n63.SetActive(true);
				break;
			case 64:
				niveles.text = "SAN CRISTOBAL";
				//	n64.SetActive(true);
				break;
			case 65:
				niveles.text = "MONSENORNOEL";
				//n65.SetActive(true);
				break;
			case 66:
				niveles.text = "AZUA";
				//	n66.SetActive(true);
				break;
			case 67:
				niveles.text = "SAN JOSE DE OCOA";
				//	n67.SetActive(true);
				break;
			case 68:
				niveles.text = "PERDERNALES";
				//	n68.SetActive(true);
				break;
			case 69:
				niveles.text = "INDEPENDECIA";
				//	n69.SetActive(true);
				break;
			case 70:
				niveles.text = "VALVERDE";
				//	n70.SetActive(true);
				break;
			case 71:
				niveles.text = "DAJABON";
				//	n71.SetActive(true);
				break;
			case 72:
				niveles.text = "MONTE CRISTI";
				//	n72.SetActive(true);
				break;
			case 73:
				niveles.text = "PUERTO PLATA";
				///	n73.SetActive(true);
				break;
			case 74:
				niveles.text = "ELIAS PINA";
				//	n74.SetActive(true);
				break;
			case 75:
				niveles.text = "SANTIAGO RODRIGUEZ";
				//n75.SetActive(true);
				break;
			case 76:
				niveles.text = "SANCHEZ RAMIREZ";
				//	n76.SetActive(true);
				break;
			case 77:
				niveles.text = "PROVINCIA DUARTE";
				//n77.SetActive(true);
				break;
			case 78:
				niveles.text = "MARIA TRINIDAD SANCHEZ";
				//	n78.SetActive(true);
				break;
			case 79:
				niveles.text = "SAN PEDRO";
				//	n79.SetActive(true);
				break;
			case 80:
				niveles.text = "MONTE PLATA";
				n80.SetActive(true);
				break;
			case 81:
				niveles.text = "HATO MAYOR";
				//	n81.SetActive(true);
				break;
			case 82:
				niveles.text = "EL SEIBO";
				//n82.SetActive(true);
				break;

			//findelmundo
			case 83:
				niveles.text = "EL QUINTO DIABLO";
				//	n83.SetActive(true);
				break;
			case 84:
				niveles.text = "EL QUINTO DIABLO 2";
				//	n84.SetActive(true);
				break;
			case 85:
				niveles.text = "EL QUINTO DIABLO FINAL";
				//	n85.SetActive(true);
				break;
			case 86:
				PlayerPrefs.SetInt("ff", 1);
				niveles.text = "TRIVIA";
				n86.SetActive(true);
				break;


		}
	}
		
		public void nivelet()
    {
		switch (PlayerPrefs.GetFloat("nivel", 1))
		{
			case 1:
				generarp.cancelargen();
				StartCoroutine(colores());
				StartCoroutine(retraso());
				a4.SetActive(false);
				niveles.text = "CAPOTILLO";

			//	n1.SetActive(true);

				break;
			case 2:
				niveles.text = "LOS MINA";
			//	n5.SetActive(true);
				break;
			case 3:
				niveles.text = "LOS GUANDULES";
			//	n3.SetActive(true);
				break;
			case 4:
				niveles.text = "SABANA PERDIDA";
			//	n4.SetActive(true);
				break;
			case 14:


				niveles.text = "GUALEY";
			//	n2.SetActive(true);
				break;

			case 8:
				niveles.text = "LOS JARDINES";
			//	n9.SetActive(true);
				break;

			case 10:
				niveles.text = "ZONA COLONIAL";
			//	n11.SetActive(true);


				break;

			case 11:
				niveles.text = "RIO OZAMA";
			//	n12.SetActive(true);
				generarp.cancelargen();
				fondo.SetActive(false);


				break;

			case 5:
				niveles.text = "UASD";
			//	n15.SetActive(true);
				generarp.cancelargen();


				break;
			case 15:
				niveles.text = "UASD";
			//	n15.SetActive(true);
				generarp.cancelargen();


				break;
		

			



			case 9:
				niveles.text = "Parque Los Haitices";
			//	n10.SetActive(true);
				generarp.cancelargen();

				break;

	
	
			case 12:
				niveles.text = "Entrada a bani";
			//	n13.SetActive(true);
				fondo.SetActive(true);


				break;
			case 13:
				niveles.text = "Dunas de bani";
			//	n14.SetActive(true);


				break;






			case 7:
				niveles.text = "PLAYA SAN RAFAEL";
			//	n7.SetActive(true);
			
				cam1.SetActive(true);
				cam2.SetActive(false);

				break;

			case 6:
				niveles.text = "CENTRO DE SAN JUAN";
			//	n6.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);
				
				break;

			case 16:
				niveles.text = "Playa Salina";
			//	n16.SetActive(true);
				break;

			case 17:
				niveles.text = "BOSQUE";
			//	n17.SetActive(true);
				break;
			case 18:
				niveles.text = "LOS HAITICES"; //implementsa
			//	n18.SetActive(true);
				break;
			case 19:
				niveles.text = "EL PICO DUAERTE";
			//	n19.SetActive(true);
				break;
			case 20:
				niveles.text = "SAN JUAN";
			//	n20.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);
				break;




			case 21:
				niveles.text = "Teleferico";
			//	n21.SetActive(true);
				break;
			case 22:
				niveles.text = "LA BARQUITA";
			//	n22.SetActive(true);
				break;
			case 23:
				niveles.text = "RIO OZAMA";
			//	n23.SetActive(true);
				fondo.SetActive(false);
				break;
			case 24:
				niveles.text = "GUACHUPITA";
			//	n24.SetActive(true);
				fondo.SetActive(true);
				break;
			case 25:
				niveles.text = "LA CIENAGA"; //implementsa
			//	n25.SetActive(true);
				break;
			case 26:
				niveles.text = "VILLA MELLA";
			//	n26.SetActive(true);
				break;
			case 27:
				niveles.text = "EL CACHON";
			//	n27.SetActive(true);
				break;
			case 28:
				niveles.text = "LOS FRAILES";
			//	n28.SetActive(true);
				break;
			case 29:
				niveles.text = "LOS JIRASOLES";
			//	n29.SetActive(true);
				break;
			case 30:
				niveles.text = "GUARICANO";
			//	n30.SetActive(true);
				break;
			case 31:
				niveles.text = "PANTOJA";
			//	n31.SetActive(true);
				break;
			case 32:
				niveles.text = "LOS TRES BRAZOS";
			//	n32.SetActive(true);
				break;
			case 33:
				niveles.text = "ALMA ROSA";
			//	n33.SetActive(true);
				break;
			case 34:
				niveles.text = "NEYBA";
			//	n34.SetActive(true);
				break;
			case 35:
				niveles.text = "VILLA FARO";
			//	n35.SetActive(true);
				break;
			case 36:
				niveles.text = "CONSTANZA";
			//	n36.SetActive(true);
				break;
			case 37:
				niveles.text = "CONSTANZA 2";
			//	n37.SetActive(true);
				break;
			case 38:
				niveles.text = "VILLAS AGRICOLAS";
			//	n38.SetActive(true);
				break;
			case 39:
				niveles.text = "INVIVIENDA";
			//	n39.SetActive(true);
				break;
			case 40:
				niveles.text = "HAINAMOSA";
			//	n40.SetActive(true);
				break;
			case 41:
				niveles.text = "SAN ISIDRO";
			//	n41.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);
				break;
			case 42:
				niveles.text = "VILLA MELLA 2";
			//	n42.SetActive(true);
				break;
			case 43:
				niveles.text = "VILLA MELLA 3";
			//	n43.SetActive(true);
				cam2.SetActive(true);
				cam1.SetActive(false);

				break;
			case 44:
				niveles.text = "CONSTANZA 3";
			//	n44.SetActive(true);
				break;
			case 45:
				niveles.text = "BAYAHIBE";
			//	n45.SetActive(true);
				break;
			case 46:
				niveles.text = "LOS ALCARRISOS";
			//	n46.SetActive(true);
				break;
			case 47:
				niveles.text = "SAN ISIDRO 2";
			//	n47.SetActive(true);
				break;
			case 48:
				niveles.text = "CONSTANZA 4";
			//	n48.SetActive(true);

				break;
			case 49:
				niveles.text = "BANI 2";
			//	n49.SetActive(true);
				break;
			case 50:
				niveles.text = "UASD 3";
			//	n50.SetActive(true);
				break;

			case 51:
				niveles.text = "BAYAHIBE 2";
			//	n51.SetActive(true);
				break;
			case 52:
				niveles.text = "CONSTANZA 5";
			//	n52.SetActive(true);

				break;
			case 53:
				niveles.text = "LOS MINA 2";
			//	n53.SetActive(true);
				break;
			case 54:
				niveles.text = "LOS PRADOS";
			//	n54.SetActive(true);
				break;
			case 55:
				niveles.text = "SALCEDO";
			//	n55.SetActive(true);
				break;
			case 56:
				niveles.text = "LOS MAMEYES";
			//	n56.SetActive(true);
				break;
			case 57:
				niveles.text = "APEC";
			//	n57.SetActive(true);
				break;
			case 58:
				niveles.text = "BARAHONA 2";
			//	n58.SetActive(true);
				break;
			case 59:
				niveles.text = "UTESA";
			//	n59.SetActive(true);
				break;
			case 60:
				niveles.text = "MOCA";
			//	n60.SetActive(true);
				break;
			case 61:
				niveles.text = "LA ESCUELITA";
			//	n61.SetActive(true);
				break;
			case 62:
				niveles.text = "INTEC";
			//	n62.SetActive(true);
				break;


			case 63:
				niveles.text = "LA ALTAGRACIA";
			//	n63.SetActive(true);
				break;
			case 64:
				niveles.text = "SAN CRISTOBAL";
			//	n64.SetActive(true);
				break;
			case 65:
				niveles.text = "MONSENORNOEL";
				//n65.SetActive(true);
				break;
			case 66:
				niveles.text = "AZUA";
			//	n66.SetActive(true);
				break;
			case 67:
				niveles.text = "SAN JOSE DE OCOA";
			//	n67.SetActive(true);
				break;
			case 68:
				niveles.text = "PERDERNALES";
			//	n68.SetActive(true);
				break;
			case 69:
				niveles.text = "INDEPENDECIA";
			//	n69.SetActive(true);
				break;
			case 70:
				niveles.text = "VALVERDE";
			//	n70.SetActive(true);
				break;
			case 71:
				niveles.text = "DAJABON";
			//	n71.SetActive(true);
				break;
			case 72:
				niveles.text = "MONTE CRISTI";
			//	n72.SetActive(true);
				break;
			case 73:
				niveles.text = "PUERTO PLATA";
			///	n73.SetActive(true);
				break;
			case 74:
				niveles.text = "ELIAS PINA";
			//	n74.SetActive(true);
				break;
			case 75:
				niveles.text = "SANTIAGO RODRIGUEZ";
				//n75.SetActive(true);
				break;
			case 76:
				niveles.text = "SANCHEZ RAMIREZ";
			//	n76.SetActive(true);
				break;
			case 77:
				niveles.text = "PROVINCIA DUARTE";
				//n77.SetActive(true);
				break;
			case 78:
				niveles.text = "MARIA TRINIDAD SANCHEZ";
			//	n78.SetActive(true);
				break;
			case 79:
				niveles.text = "SAN PEDRO";
			//	n79.SetActive(true);
				break;
			case 80:
				niveles.text = "MONTE PLATA";
				//n80.SetActive(true);
				break;
			case 81:
				niveles.text = "HATO MAYOR";
			//	n81.SetActive(true);
				break;
			case 82:
				niveles.text = "EL SEIBO";
				//n82.SetActive(true);
				break;

			//findelmundo
			case 83:
				niveles.text = "EL QUINTO DIABLO";
			//	n83.SetActive(true);
				break;
			case 84:
				niveles.text = "EL QUINTO DIABLO 2";
			//	n84.SetActive(true);
				break;
			case 85:
				niveles.text = "EL QUINTO DIABLO FINAL";
			//	n85.SetActive(true);
				break;
			case 86:
				PlayerPrefs.SetInt("ff", 1);
				niveles.text = "TRIVIA";
				n86.SetActive(true);
				break;
		}


        #endregion


    }
    public camarasigue ccc1;
	public camarasigue ccc2;
	public controladorP controladorp;
	public void tras()
    {
		generarp.GENERAR();
		//	continuar = false;
		cerrarfin();
		gameObject.transform.position = posicioninicial.transform.position;
		f = false;
		h = 0;
		ccc1.start();
		ccc2.start();
		boto.SetActive(true);
		canva.SetActive(true);
		a4.SetActive(false);
		a4.SetActive(true);
		controladorp.ProxPre();
		norepetir = true;
		
		
    }
	public void pop()
    {
		audio.PlayOneShot(tin);
    }
	
	public void comprarpower()
    {
		if (PlayerPrefs.GetFloat("dinero", 0) >= 500)
		{
			pop();
		contadorpoder += 1;
		PLATANOPOWER.text = "" + contadorpoder.ToString("f0");
			PlayerPrefs.SetFloat("poder", contadorpoder);
			PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 500);
			textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

		}
		else
		{
			audio.PlayOneShot(fail);
		}
	}

	public GameObject chancla;
	public void comprarchanclas()
    {
		if (PlayerPrefs.GetFloat("dinero", 0) >= 2000)
		{
			pop();
			Instantiate(chancla, new Vector3(transform.position.x + 3, transform.position.y + 25, -12), Quaternion.identity);
			PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 2000);
			textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

		}
        else
        {
			audio.PlayOneShot(fail);
        }
	}

	public void niveletcerrar()
    {
		switch (PlayerPrefs.GetFloat("nivel", 1)-1)
		{
			case 1:
			//	generarp.cancelargen();
				//StartCoroutine(colores());
				//StartCoroutine(retraso());
				a4.SetActive(false);
			//	niveles.text = "CAPOTILLO";

				n1.SetActive(false);

				break;
			case 2:
			//	niveles.text = "LOS MINA";
				n5.SetActive(false);
				break;
			case 3:
			//	niveles.text = "LOS GUANDULES";
				n3.SetActive(false);
				break;
			case 4:
			//	niveles.text = "SABANA PERDIDA";
				n4.SetActive(false);
				//nerarp.cancelargen();
				break;
			case 14:


			//iveles.text = "GUALEY";
				n2.SetActive(false);
			//enerarp.cancelargen();
				break;

			case 8:
				//niveles.text = "LOS JARDINES";
				n9.SetActive(false);
			//	generarp.cancelargen();
				break;

			case 10:
			//	niveles.text = "ZONA COLONIAL";
				n11.SetActive(false);
			//	generarp.cancelargen();

				break;

			case 11:
			//	niveles.text = "RIO OZAMA";
				n12.SetActive(false);
				


				break;

			case 5:
			//	niveles.text = "UASD";
				n15.SetActive(false);
			


				break;
			case 15:
				//niveles.text = "UASD";
				n15.SetActive(false);
			


				break;
		

			



			case 9:
			//	niveles.text = "Parque Los Haitices";
				n10.SetActive(false);
				

				break;

	
	
			case 12:
				//niveles.text = "Entrada a bani";
				n13.SetActive(false);


				break;
			case 13:
			//	niveles.text = "Dunas de bani";
				n14.SetActive(false);


				break;






			case 7:
				//niveles.text = "PLAYA SAN RAFAEL";
				n7.SetActive(false);
				//generarp.cancelargen();
				break;

			case 6:
				//niveles.text = "CENTRO DE SAN JUAN";
				n6.SetActive(false);
			//	cam2.SetActive(false);
			//	cam1.SetActive(true);
				
				break;

			case 16:
			//	niveles.text = "Playa Salina";
				n16.SetActive(false);
				break;

			case 17:
			//	niveles.text = "BOSQUE";
				n17.SetActive(false);
				break;
			case 18:
				//niveles.text = "LOS HAITICES"; //implementsa
				n18.SetActive(false);
				break;
			case 19:
			//	niveles.text = "EL PICO DUAERTE";
				n19.SetActive(false);
				break;
			case 20:
				//niveles.text = "SAN JUAN";
				n20.SetActive(false);
				//cam2.SetActive(false);
			//	cam1.SetActive(true);
				break;




			case 21:
				//niveles.text = "Teleferico";
				n21.SetActive(false);
				break;
			case 22:
			//	niveles.text = "LA BARQUITA";
				n22.SetActive(false);
				break;
			case 23:
			//	niveles.text = "RIO OZAMA";
				n23.SetActive(false);
				break;
			case 24:
			//	niveles.text = "GUACHUPITA";
				n24.SetActive(false);
				break;
			case 25:
			//	niveles.text = "LA CIENAGA"; //implementsa
				n25.SetActive(false);
				break;
			case 26:
			//	niveles.text = "VILLA MELLA";
				n26.SetActive(false);
				break;
			case 27:
				//niveles.text = "EL CACHON";
				n27.SetActive(false);
				break;
			case 28:
			//	niveles.text = "LOS FRAILES";
				n28.SetActive(false);
				break;
			case 29:
				////.text = "LOS JIRASOLES";
				n29.SetActive(false);
				break;
			case 30:
				//.text = "GUARICANO";
				n30.SetActive(false);
				break;
			case 31:
				//.text = "PANTOJA";
				n31.SetActive(false);
				break;
			case 32:
				//.text = "LOS TRES BRAZOS";
				n32.SetActive(false);
				break;
			case 33:
				//.text = "ALMA ROSA";
				n33.SetActive(false);
				break;
			case 34:
				//.text = "NEYBA";
				n34.SetActive(false);
				break;
			case 35:
				//.text = "VILLA FARO";
				n35.SetActive(false);
				break;
			case 36:
				//.text = "CONSTANZA";
				n36.SetActive(false);
				break;
			case 37:
				//.text = "CONSTANZA 2";
				n37.SetActive(false);
				break;
			case 38:
				//.text = "VILLAS AGRICOLAS";
				n38.SetActive(false);
				break;
			case 39:
				//.text = "INVIVIENDA";
				n39.SetActive(false);
				break;
			case 40:
				//.text = "HAINAMOSA";
				n40.SetActive(false);
				break;
			case 41:
				//.text = "SAN ISIDRO";
				n41.SetActive(false);
			//	cam2.SetActive(false);
				//cam1.SetActive(true);
				break;
			case 42:
				//.text = "VILLA MELLA 2";
				n42.SetActive(false);
				break;
			case 43:
				//.text = "VILLA MELLA 3";
				n43.SetActive(false);
				//cam2.SetActive(false);
				//cam1.SetActive(true);

				break;
			case 44:
				//.text = "CONSTANZA 3";
				n44.SetActive(false);
				break;
			case 45:
				//.text = "BAYAHIBE";
				n45.SetActive(false);
				break;
			case 46:
				//.text = "LOS ALCARRISOS";
				n46.SetActive(false);
				break;
			case 47:
				//.text = "SAN ISIDRO 2";
				n47.SetActive(false);
				break;
			case 48:
				//.text = "CONSTANZA 4";
				n48.SetActive(false);

				break;
			case 49:
				//.text = "BANI 2";
				n49.SetActive(false);
				break;
			case 50:
				//.text = "UASD 3";
				n50.SetActive(false);
				break;

			case 51:
				//.text = "BAYAHIBE 2";
				n51.SetActive(false);
				break;
			case 52:
				//.text = "CONSTANZA 5";
				n52.SetActive(false);

				break;
			case 53:
				//.text = "LOS MINA 2";
				n53.SetActive(false);
				break;
			case 54:
				//.text = "LOS PRADOS";
				n54.SetActive(false);
				break;
			case 55:
				//.text = "SALCEDO";
				n55.SetActive(false);
				break;
			case 56:
				//.text = "LOS MAMEYES";
				n56.SetActive(false);
				break;
			case 57:
				//.text = "APEC";
				n57.SetActive(false);
				break;
			case 58:
				//.text = "BARAHONA 2";
				n58.SetActive(false);
				break;
			case 59:
				//.text = "UTESA";
				n59.SetActive(false);
				break;
			case 60:
				//.text = "MOCA";
				n60.SetActive(false);
				break;
			case 61:
				//.text = "LA ESCUELITA";
				n61.SetActive(false);
				break;
			case 62:
				//.text = "INTEC";
				n62.SetActive(false);
				break;


			case 63:
				//.text = "LA ALTAGRACIA";
				n63.SetActive(false);
				break;
			case 64:
				//.text = "SAN CRISTOBAL";
				n64.SetActive(false);
				break;
			case 65:
				//.text = "MONSENORNOEL";
				n65.SetActive(false);
				break;
			case 66:
				//.text = "AZUA";
				n66.SetActive(false);
				break;
			case 67:
				//.text = "SAN JOSE DE OCOA";
				n67.SetActive(false);
				break;
			case 68:
				//.text = "PERDERNALES";
				n68.SetActive(false);
				break;
			case 69:
				//.text = "INDEPENDECIA";
				n69.SetActive(false);
				break;
			case 70:
				//.text = "VALVERDE";
				n70.SetActive(false);
				break;
			case 71:
				//.text = "DAJABON";
				n71.SetActive(false);
				break;
			case 72:
				//.text = "MONTE CRISTI";
				n72.SetActive(false);
				break;
			case 73:
				//.text = "PUERTO PLATA";
				n73.SetActive(false);
				break;
			case 74:
				//.text = "ELIAS PINA";
				n74.SetActive(false);
				break;
			case 75:
				//.text = "SANTIAGO RODRIGUEZ";
				n75.SetActive(false);
				break;
			case 76:
				//.text = "SANCHEZ RAMIREZ";
				n76.SetActive(false);
				break;
			case 77:
				//.text = "PROVINCIA DUARTE";
				n77.SetActive(false);
				break;
			case 78:
				//.text = "MARIA TRINIDAD SANCHEZ";
				n78.SetActive(false);
				break;
			case 79:
				//.text = "SAN PEDRO";
				n79.SetActive(false);
				break;
			case 80:
				//.text = "MONTE PLATA";
				n80.SetActive(false);
				break;
			case 81:
				//.text = "HATO MAYOR";
				n81.SetActive(false);
				break;
			case 82:
				//.text = "EL SEIBO";
				n82.SetActive(false);
				break;

			//findelmundo
			case 83:
				//.text = "EL QUINTO DIABLO";
				n83.SetActive(false);
				break;
			case 84:
				//.text = "EL QUINTO DIABLO 2";
				n84.SetActive(false);
				break;
			case 85:
				//.text = "EL QUINTO DIABLO FINAL";
				n85.SetActive(false);
				break;
		}
		}

	public GameObject casco;
	public Color gris;
	public GameObject presiona;
	public GameObject plataforma;

	public GameObject ex1;
	public GameObject ex2;
	public GameObject ex3;
	public GameObject ex4;
	public AudioClip tin;

	public IEnumerator colores()
	{ yield return new WaitForSecondsRealtime(3f);
		

		//ex1.SetActive(true);
	//	audio.clip = tin;
		//audio.Play();
	//	yield return new WaitForSecondsRealtime(0.5f);
		//ex2.SetActive(true);
		//audio.clip = tin;
		//audio.Play(); yield return new WaitForSecondsRealtime(0.5f);
	//	ex3.SetActive(true);
		//audio.clip = tin;
		//audio.Play(); yield return new WaitForSecondsRealtime(0.5f);
	//	ex4.SetActive(true);
		//audio.clip = tin;
		//audio.Play();

	//	yield return new WaitForSecondsRealtime(2f);
	//	ex1.SetActive(false);
	//	ex2.SetActive(false);
		//ex3.SetActive(false);
		//ex4.SetActive(false);

		/*	d.color = color1;
			a.color = color3;*/
	}


	public IEnumerator retraso()
	{
		yield return new WaitForSecondsRealtime(1.5f);
		dia1.SetActive(true);
		StartCoroutine(v2());
	}



    #region nivelesantiguos
    public void nive()
	{
		switch (PlayerPrefs.GetFloat("sd", 1))
		{
			case 1:
				generarp.cancelargen();
			//	StartCoroutine(colores());
				StartCoroutine(retraso());
				a4.SetActive(false);
				niveles.text = "CAPOTILLO";

				n1.SetActive(true);
				
				break;
			case 2:
				niveles.text = "LOS MINA";
				n5.SetActive(true);
				break;
			case 3:
				niveles.text = "LOS GUANDULES";
				n3.SetActive(true);
				break;
			case 4:
				niveles.text = "SABANA PERDIDA";
				n4.SetActive(true);
				break;
			case 9:


				niveles.text = "GUALEY";
				n2.SetActive(true);
				break;

			case 6:
				niveles.text = "LOS JARDINES";
				n9.SetActive(true);
				break;

			case 7:
				niveles.text = "ZONA COLONIAL";
				n11.SetActive(true);


				break;

			case 8:
				niveles.text = "RIO OZAMA";
				n12.SetActive(true);
				generarp.cancelargen();


				break;

			case 5:
				niveles.text = "UASD";
				n15.SetActive(true);
				generarp.cancelargen();


				break;
			case 10:
				niveles.text = "UASD";
				n15.SetActive(true);
				generarp.cancelargen();


				break;
			case 11:
				niveles.text = "VILLA MELLA"; // CHICHARRON
				n17.SetActive(true);


				break;
			case 12:
				niveles.text = "VILLA FARO";
				n18.SetActive(true);


				break;
			case 13:
				niveles.text = "GUARICANO";
				n19.SetActive(true);


				break;
			case 14:
				niveles.text = "LOS TRES BRAZOS";
				n20.SetActive(true);


				break;
			case 15:
				niveles.text = "ZONA COLONIAL";
				n21.SetActive(true);


				break;
			case 16:
				niveles.text = "ZONA COLONIAL";
				n22.SetActive(true);
				break;

			case 17:
				niveles.text = "ZONA COLONIAL";
				n23.SetActive(true);
				break;
			case 18:
				niveles.text = "ZONA COLONIAL";
				n24.SetActive(true);
				break;
			case 19:
				niveles.text = "ZONA COLONIAL";
				n25.SetActive(true);
				break;
			case 20:
				niveles.text = "ZONA COLONIAL";
				n26.SetActive(true);
				break;
			case 21:
				niveles.text = "ZONA COLONIAL";
				n27.SetActive(true);
				break;
			case 22:
				niveles.text = "ZONA COLONIAL";
				n28.SetActive(true);
				break;
			case 23:
				niveles.text = "ZONA COLONIAL";
				n29.SetActive(true);
				break;
			case 24:
				niveles.text = "ZONA COLONIAL";
				n30.SetActive(true);
				break;
			case 25:
				niveles.text = "ZONA COLONIAL";
				n31.SetActive(true);
				break;


			
			case 26:
				//	niveles.text = "ESTAN EN DESARROLLO";
				n8.SetActive(true);
				Time.timeScale = 0;

				break;



		}
	}


		



	public void sanjuan()
	{
		//tran();
		//generarp.comenzar();
		switch (sj)
		{

			case 0:
				niveles.text = "CENTRO DE SAN JUAN";
				n6.SetActive(true);
				cam1.SetActive(false);
				cam2.SetActive(true);
				break;
			case 1:
				niveles.text = "CENTRO DE SAN JUAN";
				n6.SetActive(true);
				cam1.SetActive(false);
				cam2.SetActive(true);
				break;

		}
	} public void barahona()
	{
		//tran();
		switch (PlayerPrefs.GetFloat("ba", 1))
		{
			case 1:
				niveles.text = "PLAYA SAN RAFAEL";
				n7.SetActive(true);
				generarp.cancelargen();
				break;

		}
	}


	public void SAMANA()
	{
		//	tran();
		switch (PlayerPrefs.GetFloat("sa", 1))
		{
			case 1:
				niveles.text = "Parque Los Haitices";
				n10.SetActive(true);
				generarp.cancelargen();

				break;

		}
	}
	public void bani()
	{
		//	tran();
		switch (PlayerPrefs.GetFloat("bani", 1))
		{
			case 1:
				niveles.text = "Entrada a bani";
				n13.SetActive(true);


				break;
			case 2:
				niveles.text = "DUNAS DE BANI";
				n14.SetActive(true);


				break;

		}
	}

    #endregion


    public Transform plataform;

	public IEnumerator movetele()

	{

		yield return new WaitForSecondsRealtime(0.02f);
		h = 0;

		/*while (plataform.transform.position.y > -6.35)
		{
			yield return new WaitForFixedUpdate();


			/*if (PlayerPrefs.GetFloat("nivel", 1) != 6 && PlayerPrefs.GetFloat("nivel", 1) != 7 && PlayerPrefs.GetFloat("nivel", 1) != 9)
			{
				transform.Translate(0, -1, 0);
				plataform.transform.Translate(0, -1, 0);
			} // plaforma desactivada
		}*/





	}




	public IEnumerator moveteleup()

	{

		while (plataform.transform.position.y < 11.6)
		{
			yield return new WaitForFixedUpdate();
			plataform.transform.Translate(0, 1, 0);
		}





	}

	public void volverajugaranuncio()
	{

		{
			perdermensaje.SetActive(false);
			if (preguntas.activeSelf)
			{
				controladorp.ProxPre();
			}
			Time.timeScale = 1;
			StartCoroutine(PL());
			vidas = 3;
			if (vidas > 0)
			{
				anim.SetBool("muerte", false);
				muerte = true;
				//	print("prueba");

			}
			canva.SetActive(true);
			boton.SetActive(true);

			//plataforma.SetActive(true);
			StartCoroutine(movetele());

			/*if (PlayerPrefs.GetFloat("nivel", 1) != 6 && PlayerPrefs.GetFloat("nivel", 1) != 7 && PlayerPrefs.GetFloat("nivel", 1) != 9)
			{
				plataform.transform.position = new Vector3(rota.x, plataform.transform.position.y, plataform.transform.position.z);
			}*/

			//anim.SetBool("deten", true);
			
		

			transform.position = rota;
			
			Time.timeScale = 1;
			paus = 1;
		
			//plataforma.SetActive(false);
			//plataforma.SetActive(true);
			continuar = true;
			gestora.pla();
			canmuere = false;
			StartCoroutine(puedemorir());

			canva.SetActive(true);
			h = 0;
		}
	

	}

	public void volverajugar()
	{
		if (PlayerPrefs.GetFloat("dinero", 0) > 499)
		{
			if (preguntas.activeSelf)
			{
				controladorp.ProxPre();
			}
			StartCoroutine(PL());
			vidas = 3;
			if (vidas > 0)
			{
				anim.SetBool("muerte", false);
				muerte = true;
				//	print("prueba");

			}
			canva.SetActive(true);
			boton.SetActive(true);

			//plataforma.SetActive(true);
			StartCoroutine(movetele());

			/*if (PlayerPrefs.GetFloat("nivel", 1) != 6 && PlayerPrefs.GetFloat("nivel", 1) != 7 && PlayerPrefs.GetFloat("nivel", 1) != 9)
			{
				plataform.transform.position = new Vector3(rota.x, plataform.transform.position.y, plataform.transform.position.z);
			}*/

			//anim.SetBool("deten", true);
			Time.timeScale = 1;
			PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 500);
			textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

			transform.position = rota;
			perdermensaje.SetActive(false);
			Time.timeScale = 1;
			paus = 1;
			h = 0;
			//plataforma.SetActive(false);
			//plataforma.SetActive(true);
			continuar = true;
			gestora.pla();
			h = 0;
			canmuere = false;
			StartCoroutine(puedemorir());
			canva.SetActive(true);
		}
		else
		{
			audio.clip = fail;
			audio.Play();
		}

	}


	public GameObject c2;
	public GameObject c3;
	public GameObject c1;
	public GameObject PPOWE;
//	public GameObject camaravibra;
	public Transform camaravi;

	public float celeridad;
	public VIBRA vibra;
	public generarbilletes generarbille;

	// Update is called once per frame

	public bool animacion = true;
	//public bool mt = false;
	public GameObject reflejo;
	public GameObject reflejo2;
	public GameObject reflejo3;
	public float contadorpoder = 0;


		public IEnumerator LACALLEBOTAFUEGO()
	{
		while (!animacion)
		{
			yield return new WaitForSecondsRealtime(0.001f);

			camaravi.transform.Rotate(0, 0, 0.8f);
			camaravi.transform.Translate(.2f, 0, 0);
			yield return new WaitForSecondsRealtime(0.001f);

			camaravi.transform.Rotate(0, 0, -0.8f);
			camaravi.transform.Translate(-.2f, 0, 0);
		}

	}

	
	
	public seguir seguirp;

	public void suicidio()
    {
		StartCoroutine(muere());
		
	}
	
	
	IEnumerator muere()
    {
		yield return new WaitForSecondsRealtime(1f);
		vidas = 0;
		anim.SetBool("muerte", true);
		//audio.PlayOneShot(aah);
		yield return new WaitForSecondsRealtime(1f);
		StartCoroutine(muert());
	}
	public void corrutinatonta()
    {
		
		StartCoroutine(PL2());
	}

	//public GameObject plata2;


	public IEnumerator PL2()
	{


		yield return new WaitForSecondsRealtime(0.1f);
		PLATA.SetActive(false);
		PLATA.SetActive(true);

		seguirp.s();
	}
		public IEnumerator PL()
    {
	
		
		yield return new WaitForSecondsRealtime(0.01f);
		PLATA.SetActive(false);
		PLATA.SetActive(true);

		seguirp.s();

		yield return new WaitForSecondsRealtime(1f);
		boto.SetActive(true);

	}

	public bool inmortal = false;
	public bool canmuere=true;

	public void saltaunpocoantes()
    {
		StartCoroutine(saltojugabilidad());
    }
	IEnumerator saltojugabilidad()
    { int pppp = 0;
		while (pppp<10) {
			yield return new WaitForSecondsRealtime(0.02f);
			pppp++;
            if (suel == true)
            {
				if (suel && animacion)
				{
					if (rompe)
					{
						StartCoroutine(romp());
						cabeza.SetActive(true);
					}
					anim.SetBool("golpe", false);
					anim.SetBool("salto", true);
					StartCoroutine(se());

					//velocidadsalto();
					//	Handheld.Vibrate();
					un = true;
					salto = true;




					h1 = 7 * guardah;

					pppp = 10;
				}
            }
		}


    }
	public IEnumerator puedemorir()
    {
		yield return new WaitForSecondsRealtime(5);
		canmuere = true;
    }

	public GameObject hack;
	public GameObject MENSAJEPOWER2;
	public GameObject PLATA;
	public bool power2 = false;
	public void quitarfuerzas()
    {
		r.velocity = new Vector2(r.velocity.x, 0);
	}

	public bool tigrezone = false;
	void Update()
	{
        if (tigrezone)
        {
			textodinero.text = "" +PlayerPrefs.GetFloat("dinero", 0).ToString();
        }
		gestorlife();
		if(celeridad > 0.1 && power2 || celeridad< -0.1 && power2)
        {
			samurai3.SetActive(true);
        } else
        {
			samurai3.SetActive(false);
        }
    

	




		if (power && suel)
		{
			tiempoespera = 0.5f;
	reflejo.SetActive(true);
			reflejo2.SetActive(true);
			reflejo3.SetActive(true);

			if (guardah == -1)
			{
				sprite.transform.Rotate(0, -180, 0); // arreglar codigo
				guardah = 1;

			}
			PPOWE.SetActive(false);
			PPOWE.SetActive(true);

			fuerza = 120;

			if (cam1.activeSelf) { ccc1.powerfuncion(); } else { ccc2.powerfuncion(); }
			gest.s = true;
			sayayin.SetActive(true);
			StartCoroutine(saya());
			anim.SetBool("poder",true);
			anim.SetBool("nosalte",false);
			animacion = false;
			h = 0;
			h1 = 0;
			r.velocity = new Vector2(0, 0);
			power = false;
			StartCoroutine(LACALLEBOTAFUEGO());


		}


		

		celeridad = r.velocity.x;
		if (celeridad > 0.1 || celeridad < -0.1)
		{
			anim.SetBool("deten", false);
		}
		else
		{
			anim.SetBool("deten", true);
		}




		if (h > 0 || h < 0)
		{
			anim.SetFloat("h", 1);
		}
		else
		{
			anim.SetFloat("h", -1);
		}
		if (h1 > 0 || h1 < 0)
		{
			anim.SetFloat("h1", 1);
		}
		else
		{
			anim.SetFloat("h1", -1);
		}


		





		//h = 0;
		/*
				if (h==0 && h1==0)
				{
					anim.SetBool("deten", true);


				}
				else
				{
					anim.SetBool("deten", false);

				}*/

		


		destruir.transform.position = new Vector3(destruir.transform.position.x, vt.y, vt.z);
		destruir2.transform.position = new Vector3(destruir2.transform.position.x, vt.y, vt.z);

		if (ga)
		{
			audio.clip = ganarp;
			audio.Play();
			ga = false;
		}

		if (pe)
		{
			audio.clip = perder;
			audio.Play();
			pe = false;
		}

		if (tiem)
		{
			Time.timeScale = 0f;
		}


		if (Input.GetKeyDown(KeyCode.UpArrow) && suel)
		{
			saltard();
		}

		if (tigre)
		{
			serio = false;
			mangacami = true;
			cam.gameObject.SetActive(mangacami);
			walk.gameObject.SetActive(serio);
			i.color = CO;

		}
		if (!tigre)
		{
			mangacami = false;
			serio = true;
			cam.gameObject.SetActive(mangacami);
			walk.gameObject.SetActive(serio);
			i.color = CO2;

		}

		if (paus == 0)
		{
			transform.position = new Vector3(gco.x, transform.position.y, gco.z);
		}






	}

	public AudioClip muerteaudio;
	public GameObject linea;
	public string numerodenivel;
	public void nivelactual()
	{if (PlayerPrefs.GetFloat("jn", 0) == 0) 
		{
			SceneManager.LoadScene((int)PlayerPrefs.GetFloat("nivel", 1)); } else
        {
			SceneManager.LoadScene((int)PlayerPrefs.GetFloat("jn", 1));

		}

		
		vidas = vidasi;
		//PlayerPrefs.GetFloat("vidas", 3);// revisar
		notasale();
	}


	private IEnumerator Quitarm()
	{
		yield return new WaitForSeconds(3f);
		m1.gameObject.SetActive(false);
		m2.gameObject.SetActive(false);
		yield return new WaitForSeconds(3f);
	}

	public float rotar;
	public float h1 = 0;
	public float h2 = 0;
	public bool muerte = true;
	//public GameObject fin10;

	public Transform puntoderetorn;
public void cerrarfin()
    {
		/*fin1.SetActive(false);
		fin2.SetActive(false);
		fin3.SetActive(false);
		fin4.SetActive(false);
		fin5.SetActive(false);
		fin6.SetActive(false);
		fin7.SetActive(false);
		fin8.SetActive(false);
		fin9.SetActive(false);
		fin10.SetActive(false);
		fin11.SetActive(false);
		fin12.SetActive(false);
		fin13.SetActive(false);
		fin14.SetActive(false);
		fin15.SetActive(false);
		fin16.SetActive(false);
		fin17.SetActive(false);
		fin18.SetActive(false);
		fin19.SetActive(false);
		fin20.SetActive(false);
		fin21.SetActive(false);
		fin22.SetActive(false);
		fin23.SetActive(false);
		fin24.SetActive(false);
		fin25.SetActive(false);
		fin26.SetActive(false);
		fin27.SetActive(false);
		fin28.SetActive(false);
		fin29.SetActive(false);
		fin30.SetActive(false);
		fin31.SetActive(false);
		fin32.SetActive(false);
		fin33.SetActive(false);
		fin34.SetActive(false);
		fin35.SetActive(false);
		fin36.SetActive(false);
		fin37.SetActive(false);
		fin38.SetActive(false);
		fin39.SetActive(false);
		fin40.SetActive(false);
		fin41.SetActive(false);
		fin42.SetActive(false);
		fin43.SetActive(false);
		fin44.SetActive(false);
		fin45.SetActive(false);
		fin46.SetActive(false);
		fin47.SetActive(false);
		fin48.SetActive(false);
		fin49.SetActive(false);
		fin50.SetActive(false);
		fin51.SetActive(false);
		fin52.SetActive(false);
		fin53.SetActive(false);
		fin54.SetActive(false);
		fin55.SetActive(false);
		fin56.SetActive(false);
		fin57.SetActive(false);
		fin58.SetActive(false);
		fin59.SetActive(false);
		fin60.SetActive(false);
		fin61.SetActive(false);
		fin62.SetActive(false);
		fin63.SetActive(false);
		fin64.SetActive(false);
		fin65.SetActive(false);
		fin66.SetActive(false);
		fin67.SetActive(false);
		fin68.SetActive(false);
		fin69.SetActive(false);
		fin70.SetActive(false);
		fin71.SetActive(false);
		fin72.SetActive(false);
		fin73.SetActive(false);
		fin74.SetActive(false);
		fin75.SetActive(false);
		fin76.SetActive(false);
		fin77.SetActive(false);
		fin78.SetActive(false);
		fin79.SetActive(false);
		fin80.SetActive(false);
		fin81.SetActive(false);
		fin82.SetActive(false);
		fin83.SetActive(false);
		fin84.SetActive(false);
		fin85.SetActive(false);*/
	}
	void FixedUpdate()
	{
		
		/*if (m)
		{

			velocidadsalto();
		}*/



		rota = puntoderetorn.transform.position;
		/*if (PlayerPrefs.GetFloat("nivel", 1) == 6 || PlayerPrefs.GetFloat("nivel", 1) == 7 || PlayerPrefs.GetFloat("nivel", 1) == 9)
		{
			rota = puntoderetorn.transform.position;
		}
		else
		{
			rota = spri.transform.position;
		}*/

		if (continuar)
		{
			adelante();
			StartCoroutine(con());
			ATRAPADO.SetActive(false);

			//	anim.SetBool("deten", false);
			paus = 1f;

			destruir.gameObject.SetActive(false);
			destruir2.gameObject.SetActive(false);
			preguntas.gameObject.SetActive(false);
			continuar = false;
			//boto.SetActive(true);
			StartCoroutine(Quitarm());

			unave = true;
			/*if (m)
			{
				h = 1;
				h1 = 1;
				
			}*/
			
			
			//	generarp.comenzar();
		}
		if (f)
		{
			/*fin1.SetActive(true);
			fin2.SetActive(true);
			fin3.SetActive(true);
			fin4.SetActive(true);
			fin5.SetActive(true);
			fin6.SetActive(true);
			fin7.SetActive(true);
			fin8.SetActive(true);
			fin9.SetActive(true);
			fin10.SetActive(true);
			fin11.SetActive(true);
			fin12.SetActive(true);
			fin13.SetActive(true);
			fin14.SetActive(true);
			fin15.SetActive(true);
			fin16.SetActive(true);
			fin17.SetActive(true);
			fin18.SetActive(true);
			fin19.SetActive(true);
			fin20.SetActive(true);
			fin21.SetActive(true);
			fin22.SetActive(true);
			fin23.SetActive(true);
			fin24.SetActive(true);
			fin25.SetActive(true);
			fin26.SetActive(true);
			fin27.SetActive(true);
			fin28.SetActive(true);
			fin29.SetActive(true);
			fin30.SetActive(true);
			fin31.SetActive(true);
			fin32.SetActive(true);
			fin33.SetActive(true);
			fin34.SetActive(true);
			fin35.SetActive(true);
			fin36.SetActive(true);
			fin37.SetActive(true);
			fin38.SetActive(true);
			fin39.SetActive(true);
			fin40.SetActive(true);
			fin41.SetActive(true);
			fin42.SetActive(true);
			fin43.SetActive(true);
			fin44.SetActive(true);
			fin45.SetActive(true);
			fin46.SetActive(true);
			fin47.SetActive(true);
			fin48.SetActive(true);
			fin49.SetActive(true);
			fin50.SetActive(true);
			fin51.SetActive(true);
			fin52.SetActive(true);
			fin53.SetActive(true);
			fin54.SetActive(true);
			fin55.SetActive(true);
			fin56.SetActive(true);
			fin57.SetActive(true);
			fin58.SetActive(true);
			fin59.SetActive(true);
			fin60.SetActive(true);
			fin61.SetActive(true);
			fin62.SetActive(true);
			fin63.SetActive(true);
			fin64.SetActive(true);
			fin65.SetActive(true);
			fin66.SetActive(true);
			fin67.SetActive(true);
			fin68.SetActive(true);
			fin69.SetActive(true);
			fin70.SetActive(true);
			fin71.SetActive(true);
			fin72.SetActive(true);
			fin73.SetActive(true);
			fin74.SetActive(true);
			fin75.SetActive(true);
			fin76.SetActive(true);
			fin77.SetActive(true);
			fin78.SetActive(true);
			fin79.SetActive(true);
			fin80.SetActive(true);
			fin81.SetActive(true);
			fin82.SetActive(true);
			fin83.SetActive(true);
			fin84.SetActive(true);
			fin85.SetActive(true);*/
			
			f = false;
		}



		// h = 0f;

		//	if ((platano +PlayerPrefs.GetFloat("mango", 0)) > g)
		{
			//contador.text = "" + (platano + PlayerPrefs.GetFloat("mango", 0)+PlayerPrefs.GetFloat("pollo", 0)+ PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0)).ToString("f0");
			//contador2.text = "" + platano + PlayerPrefs.GetFloat("mango", 0).ToString("f0");


			/*if (g > -1)
			{

				puntos.soni = true;
			}
			g += 1f;*/
		}


		if (Input.GetKey(KeyCode.LeftArrow) && suel)
		{




			atras();
		}
		else
			if (Input.GetKey(KeyCode.RightArrow) && suel)
		{
			adelante();

		}



		{


			r.AddForce(Vector2.right * speed * h * paus);
		}


		if (r.velocity.x > maxspeed && h == 1)
		{
			r.velocity = new Vector2(maxspeed * paus * h, r.velocity.y);
		}

		if (r.velocity.x > -velmin && h == -1)
		{
			r.velocity = new Vector2(velmin * paus * h, r.velocity.y);
		}


		if (r.velocity.x < -maxspeed && h == -1)
		{
			r.velocity = new Vector2(maxspeed * paus * h, r.velocity.y);
		} else

		if (r.velocity.x < velmin && h == 1)
		{
			r.velocity = new Vector2(velmin * paus * h, r.velocity.y);
		}


		if (salto && vidas>0)
		{
			r.velocity = new Vector2(0, 0);

			//	anim.SetBool("deten", false);

			r.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
			salto = false;
			if (gest.tiemposaya == true)
			{
				audio.clip = saltopoder;
				audio.Play();
				chispa.SetActive(false);
				chispa.SetActive(true);
			}
			else
			{
				audio.clip = saltoauido;
				audio.Play();
			}


		}
		
		if (saltoi)
		{
			//anim.SetBool("deten", false);
			r.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
			saltoi = false;

			if (gest.tiemposaya == true)
			{
				audio.clip = saltopoder;
				audio.Play();
				chispa.SetActive(false);
				chispa.SetActive(true);
			}
			else
			{
				audio.clip = saltoauido;
				audio.Play();
			}

		}

		
		 


	}

	public bool arribabool;

	public AudioClip saltopoder;
	public GameObject chispa;
	public void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "salida")
		{
			StartCoroutine(moveteleup());
		}
		if (collision.tag == "tigrezona")
		{
			tigrezone = false;
		}

		if (collision.tag == "arriba")
		{
			transform.parent = null;
			arribabool = false;
		}
		



	}

	public IEnumerator stevejob()
    {
		
			yield return new WaitForSecondsRealtime(0.05f);
			if (realmente)
			{
				suel = false;

			}
		}
		
    

	public bool realmente = true;
	public bool suel = false;

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "suelo")
		{
			retorno.suelito = false;
			realmente = true;
			StartCoroutine(stevejob());
			
			//anim.SetBool("salto", true);
			StartCoroutine(espera());

		}


		

		/*	if (col.gameObject.tag == "")
			{
				suel = false;
				anim.SetBool("salto", true);
				StartCoroutine(espera());

			}*/


		if (col.gameObject.tag == "metro")
		{
			linea.SetActive(false);


		}

	}

	
	public Text notas;
	public float Nnotas = 1;
	public void notasale()
	{
		Nnotas = PlayerPrefs.GetFloat("notas", 1);
		switch (Nnotas)
		{
			case 1:
				notas.text = "En ocasiones se roban las tapas de las alcantarillas";
				break;
			case 2:
				notas.text = "Vete al colmado y vende todas las provisiones o te las robaran";
				break;
			case 3:
				notas.text = "Si mangaste tu caminao cuidate de los polis";
				break;
			case 4:
				notas.text = "Si no tienes nada que robarte te podria ir muy mal";
				break;
			case 5:
				notas.text = "Siempre puede pagar para recuperar tu salud cuando te lastimes";
				break;
			case 6:
				notas.text = "Si lo ladrones te ven serio te atracan";
				break;
			case 7:
				notas.text = "Puede comprar herramientas para obtener mas dinero. Piensalo";
				break;
			case 8:
				notas.text = "Ten cuidado cuando viajes";
				break;
			case 9:
				notas.text = "Puedes jugar sin encaramarte en plataformas pero no podras ganar mucho";
				break;
		}
		Nnotas += 1;
		if (Nnotas > 10)
		{
			Nnotas = 1;
		}
		PlayerPrefs.SetFloat("notas", Nnotas);
	}


	public GameObject balita;
	public Transform casquito;
	public bool recarga = true;

	public IEnumerator re()
    {
		yield return new WaitForSecondsRealtime(0.2f);
		recarga = true;
    }
	public void disparador()
    {
		if (recarga && guardah>0)
		{

			Instantiate(balita, casquito.transform.position, Quaternion.identity);
			recarga = false;
			StartCoroutine(re());

		}
	}

	public bool arriba = false;

	public bool un = true;
	void OnCollisionStay2D(Collision2D col)
	{
		if (col.gameObject.tag == "suelo")
		{
			if (!arribabool)
			{
				retorno.suelito = true;
			}
			//cabeza.SetActive(false);
			suel = true;
			realmente = false;
			h1 = 0;
			if (arriba) {
				anim.SetBool("salto", false);
				arriba = false;
			}
		}

		

		if (col.gameObject.tag == "desli")
		{
			h = 0;
		}
		if (col.gameObject.tag == "metro")
		{
			linea.SetActive(true);


		}






	}
	public IEnumerator espera()
	{
		yield return new WaitForSecondsRealtime(0.5f);

		h1 = 0;

	}
	public bool m=true;
	public IEnumerator esperam()
	{
		yield return new WaitForSecondsRealtime(1f);

		m = true;

	}



	public void velocidadsalto()
	{
		if (!suel && h1 == 1)
		{
			h1 = 3;
		}

		if (!suel && h1 == -1)
		{
			h1 = -3;
		}


		if (suel && h1 == -3)
		{
			h1 = -1;
		}
		if (suel && h1 == 3)
		{
			h1 = 1;
		}
	}

	public AudioClip aah;


	public IEnumerator se()
	{
		yield return new WaitForSecondsRealtime(0.2f);
		arriba = true;
	}

	public IEnumerator romp()
	{
		yield return new WaitForSecondsRealtime(0.25f);
		cabeza.SetActive(false);
	}
	public void saltard()
	{ if (suel == false)
		{
			saltaunpocoantes();
		}
		
		if (suel && animacion )
		{
			if (rompe)
			{
				StartCoroutine(romp());
				cabeza.SetActive(true);
			}
			anim.SetBool("golpe", false);
			anim.SetBool("salto", true);
			StartCoroutine(se());

			//velocidadsalto();
			//	Handheld.Vibrate();
			un = true;
			salto = true;

			


			h1 = 7 * guardah;




		}
	}
	public bool saltoi = false;
	public void saltari()
	{
	
		if (suel && ANIMA )
		{

			if (rompe)
			{
				StartCoroutine(romp());
				cabeza.SetActive(true);
			}

			anim.SetBool("golpe", false);
			anim.SetBool("salto", true);
		//velocidadsalto();
			//Handheld.Vibrate();
			un = true;
			salto = true;
			arriba = true;


			h1 = 7 * guardah;

		}
	}





	public bool tuto = false;
	public GameObject playe;
	public GameObject botones;

	public void caminao()
	{




		/*if (PlayerPrefs.GetFloat("nivel", 0) == 7)
		{
			if (!tigre)
			{
				h=0;
			} else
			if (tigre)
			{
				h=1;
			}
			*/

		//	anim.SetBool("deten", !tigre);
		//tigre = !tigre;
		//	}
		//else
		{



			tigre = !tigre;
			anim.SetBool("caminao", tigre);

			if (tigre)
			{
				m2.SetActive(true);
				camara.cam = true;
			
				//audio.Stop();
			}
			else
			{
				m2.SetActive(false);

				camara.nocam = true;
			}

		}





	}

	private IEnumerator quit() // esto no se ha usado
	{
		yield return new WaitForSeconds(2f);



	}

	public float rotacionplayer;

	public void adelante()
	{
		rotacionplayer = transform.rotation.y;
		if (vidas > 0)
		{
			anim.SetBool("golpe", false);
			atr = false;
			alan = true;
			elec.localScale = new Vector3(electric.x, electric.y, electric.z);



			if (animacion)
			{

				//	velocidadsalto();
				//	if (suel)
				{
					//Handheld.Vibrate();

					//anim.SetBool("deten", false);

					if (guardah == -1)
					{
						sprite.transform.Rotate(0, -180, 0); // arreglar codigo
						

					}

					guardah = 1;
					h = 1;
				}
			}
		}
	}

	public float mango = 0;

	public bool atr = true;
	public bool alan = true;
	public void atras()
	{
		if (vidas > 0) { 
		anim.SetBool("golpe", false);
		atr = true;
		alan = false;
			elec.localScale = new Vector3(electric.x, electric.y, -electric.z);
			if (animacion)
		{
				//velocidadsalto();
				//	if (suel)

				{
					//Handheld.Vibrate();
					//	anim.SetBool("deten", false);

					if (guardah == 1)
					{
						sprite.transform.Rotate(0, -180, 0); // arreglar codigo
					



					}

					guardah = -1;
					h = -1;
				}
			}
		}
	}
	public float guardah = 1;
	public void atrasdown()
	{
		if (atr && animacion&& vidas>0 )
		{
			h = 0;
			//h1 = 0;
			anim.SetBool("deten", true);

			if (suel)
			{
				r.velocity = new Vector2(1 * paus * -guardah, r.velocity.y);
			}
			else { r.velocity = new Vector2(0, r.velocity.y); }
		}
	}
	public void alantedown()
	{
		if (alan && animacion&& vidas >0)
		{
			h = 0;
			//h1 = 0;
			anim.SetBool("deten", true);

			if (suel)
			{
				r.velocity = new Vector2(1 * paus * -guardah, r.velocity.y);
			}
			else { r.velocity = new Vector2(0, r.velocity.y); }
		}
	}

	public void saldown()
	{
		if (animacion && vidas<0)
		{
			h1 = 0;
		}
	//h = 0;

	}
	public void saldown2()
	{if(animacion && vidas>0)
		h = 0;
	//	h = 0;

	}



	private IEnumerator iniciarpregunta()
	{



		yield return new WaitForSeconds(timepregunta1);

		preguntas.gameObject.SetActive(true);

		audio.clip = PREGU;
		audio.Play();


	}

	private IEnumerator paras()




	{



		camara.nocam = true;
		yield return new WaitForSeconds(2.2f);


		audio.Stop();



	}

	public GameObject minimenu;
	public GameObject canva;
	public GameObject yund;
	public GameObject ATRAPADO;
	public bool pregg = false;
	public bool tiem = false;
	public AudioClip PREGU;
	public bool unave = true;
	public bool ciclo = false;
	public bool desbloquearyun = true;
	public Transform meta;
	public Text pla;
	public Text man;
	public Text din; 
	public GameObject ptext;
	public GameObject mtext;
	public GameObject dtext;
	public GameObject corazonroto;


	public void gestorlife()
    {
		if (vidas == 2)
		{
			c3.SetActive(false);
			c1.SetActive(true);
			c2.SetActive(true);
		}
		if (vidas == 1)
		{
			c1.SetActive(true);
			c2.SetActive(false);
			c3.SetActive(false);
		}
		if (vidas < 1)
		{
			c1.SetActive(false);
			c2.SetActive(false);
			c3.SetActive(false);
		}

		if (vidas == 3)
		{
			c3.SetActive(true);
			c1.SetActive(true);
			c2.SetActive(true);
		}
		PlayerPrefs.SetFloat("vidas", vidas);
	}


	public IEnumerator muereespera()
	{
		gestorlife();
		yield return new WaitForSecondsRealtime(2);
		if (vidas > 0 && !inmortal)
		{
			corazonroto.SetActive(false);
			corazonroto.SetActive(true);
		}

	}

	public IEnumerator trasnport()
	{ gestorlife();
		//yield return new WaitForSecondsRealtime(0.5f);

		if (vidas > 0)
		{
			

			r.velocity = new Vector2(0, 0);
			
			m = false;
			StartCoroutine(esperam()); 
			
			//	volverajugar();

			//	r.velocity = new Vector3(0, 0, 0);

			if (guardah == -1)
			{
				sprite.transform.Rotate(0, -180, 0); // arreglar codigo

				guardah = 1;
				h = 0;
			}
			//guardah = 0;


			if (!inmortal)
			{
				vidas -= 1;
				if (vidas > 0)
				{
					anim.SetBool("muerte", false);
					muerte = true;
				//	print("prueba");

				}
				else
				{
					if (muerte)
					{
						StartCoroutine(muert());
						muerte = false;
						anim.SetBool("muerte", true);
					}

				}
				if (vidas > 0)
				{
					anim.SetBool("muerte", false);
					muerte = true;
					print("prueba");

				}
				else
				{
					if (muerte)
					{
						StartCoroutine(muert());
						muerte = false;
						anim.SetBool("muerte", true);
					}

				}
			}
			StartCoroutine(PL());

			StartCoroutine(muereespera());
			audio.clip = aah;
			audio.Play();
			//	yield return new WaitForSecondsRealtime(1f); 
			h = 0;
			h1 = 0;
			if (vidas > 0)
			{
				yield return new WaitForSecondsRealtime(2);
				transform.position = rota;
				PLATA.SetActive(false);
				PLATA.SetActive(true);

				seguirp.s();
			}
			//plataforma.SetActive(true);
			StartCoroutine(movetele());
			/*if (PlayerPrefs.GetFloat("nivel", 1) != 6 && PlayerPrefs.GetFloat("nivel", 1) != 7 && PlayerPrefs.GetFloat("nivel", 1) != 9)
			{
				plataform.transform.position = new Vector3(rota.x, plataform.transform.position.y, plataform.transform.position.z);
			}*/  // por ahora teleferico elimindo

			//anim.SetBool("deten", true);
			Time.timeScale = 1;
			//PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 500);


			//	perdermensaje.SetActive(false);
			Time.timeScale = 1;
			paus = 1;
			//h = 0;
		//	plataforma.SetActive(false);
			//plataforma.SetActive(true);
			continuar = true;
			anim.SetBool("deten", true);

		}
		else

		{ 
			audio.clip = aah; // sondio de game over
			audio.Play();
			yield return new WaitForSecondsRealtime(2f);

			perdermensaje.SetActive(true);
			text.text = PlayerPrefs.GetFloat("dinero", 0).ToString();
			gestora.sto();

			notasale();
			//Nnotas += 1;
		//	PlayerPrefs.SetFloat("notas", Nnotas);
		}
		//plataforma.SetActive(false);
		h = 0;
		yield return new WaitForSecondsRealtime(1f);
		h = 0;



		//	paus = 1;


	}
	public Text textodinero;
	public float mil = 1000;
	public GameObject menos;
	public GameObject PUNALA;

	public bool NOMASDE1 = true;

	public IEnumerator NOMAS()
	{
		yield return new WaitForSecondsRealtime(3f);
		{
			NOMASDE1 = true;
			yield return new WaitForSecondsRealtime(2f);
			PUNALA.SetActive(false);
		}
	}

	public IEnumerator mi()
	{

		while (mil > 0)
		{
			yield return new WaitForSecondsRealtime(0.005f);
			PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 10);
			textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
			mil -= 1;
		}
	}

	public bool norepetir = true;

	public AudioClip blillantico;
	public GameObject sayayin;
	public AudioClip sayayiauidio;
	public AudioClip coca;
	public AudioClip metros;

	public IEnumerator saya()
	{
		yield return new WaitForSecondsRealtime(1);
		//fuerza = 80;
		animacion = true;
		sayayin.SetActive(false);
		anim.SetBool("poder", false);
		anim.SetBool("nosalte", true);

	}

	public bool power = false;
	public Text PLATANOPOWER;
	

	
	public void activapower()
	{
		if (contadorpoder>0 && vidas>0)
		{
			power = true;
			contadorpoder -= 1;
			PlayerPrefs.SetFloat("poder", contadorpoder);
			contadorpoder = PlayerPrefs.GetFloat("poder", 0);

            
			
			
			rompe = true;
		// ESTABA AQUI -=1
			
			PLATANOPOWER.text = "" + contadorpoder.ToString("f0");

		} 
	}
	public bool couna = true;
	public IEnumerator coquitos()
	{
		yield return new WaitForSecondsRealtime(0.5f);
		couna = true;
	}


	public IEnumerator muert() {

		audio.clip = muerteaudio;
		audio.Play();
		yield return new WaitForSecondsRealtime(2.5f);
		perdermensaje.SetActive(true);
		text.text = PlayerPrefs.GetFloat("dinero", 0).ToString();
		gestora.sto();
	}
	

	public GameObject samurai1;
	public GameObject samurai2;
	public GameObject samurai3;
	public Transform elec;
	public float t = 1;
	public IEnumerator chanclas()
    {
		t += 7;
		samurai1.SetActive(true);
		samurai2.SetActive(true);
		MENSAJEPOWER2.SetActive(false);
		MENSAJEPOWER2.SetActive(true);
		power2 = true;
		yield return new WaitForSecondsRealtime(7);
		yield return new WaitForSecondsRealtime(t);
		t = -6;
		speed = 18;
		maxspeed = 25;
		velmin = 18;
		anim.SetBool("chanclas", false);
		samurai1.SetActive(false);
		samurai2.SetActive(false);
		power2 = false;
	}
	public bool unacasc = true;


	public AudioClip logro;
	public AudioClip salami;
	public AudioClip spuntos;
	public GameObject bomb;
	public GameObject llave;
	public bomba bomba;
	public GameObject JUICI;

	public Transform c123arribal;
		public GameObject cccc;

	public GameObject botoncasco;
	public AudioClip libro;
	public IEnumerator casc()
    {
		yield return new WaitForSecondsRealtime(15);
		casco.SetActive(false);
		botoncasco.SetActive(false);
		yield return new WaitForSecondsRealtime(2);
		Instantiate(cccc, c123arribal.transform.position, Quaternion.identity);
		unacasc = true;


	}

	public planeta planeta;
	public GameObject librodeconjuto;
	public GameObject polvo;
	void OnTriggerEnter2D(Collider2D otr)
	{
		if (otr.gameObject.tag == "pocima")
		{
			puedeembrujar = true;
			botonbruja.localScale = new Vector3(botonbruja.localScale.x, 3.06f, botonbruja.localScale.z);
			pop();

		}
		if (otr.gameObject.tag == "arriba")
		{
			transform.parent = otr.transform;

			arribabool = true;
			print("esta tocando");


		}

		if (otr.gameObject.tag == "tigrezone")
		{
			tigrezone = true;
		}
		if (otr.tag == "platano")
		{
			cplatano += 1;
			platano += 1;
			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
			if (cplatano == 35)
			{
				//f = true;
				gest.bril = true;
				contadorpoder += 1;
				PLATANOPOWER.text = "" + contadorpoder.ToString("f0");
				PlayerPrefs.SetFloat("poder", contadorpoder);
				cplatano = 0;

			}
		}
		if (otr.tag == "mango")
		{
			PlayerPrefs.SetFloat("mango", PlayerPrefs.GetFloat("mango", 0) + 1);
			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
		}



		if (otr.tag == "ciclo")
		{
			mil = 100;

			{
				audio.clip = blillantico;
				audio.Play();
				textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

				text.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
				StartCoroutine(mi());


			}
		}


		if (otr.tag == "2000")
		{
			mil = 200;

			{
				textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

				text.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

				audio.clip = blillantico;
				audio.Play();
				StartCoroutine(mi());


			}
		}

		if (otr.tag == "mina")
		{
			bomb.SetActive(true);
			llave.SetActive(true);
			audio.PlayOneShot(fail);
			if (bomba.tiempo < 1)
			{
				bomba.tiempo = 30;
			}
			bomba.llave = false;
		}

		if (otr.tag == "llave")
		{
			llave.SetActive(false);
			audio.PlayOneShot(logro);
			bomba.llav();

		}
		if (otr.tag == "fruticas")
		{
			PlayerPrefs.SetFloat("fruticas", PlayerPrefs.GetFloat("fruticas", 0) + 1);
			audio.PlayOneShot(spuntos);
			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
		}


		if (otr.tag == "pollo")
		{

			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
		}

		if (otr.tag == "LIBRO")
		{
			PlayerPrefs.SetInt("brujeria", 1);
			audio.PlayOneShot(libro);
			librodeconjuto.SetActive(false);
			librodeconjuto.SetActive(true);
			StartCoroutine(brujeri());
		}

		if (otr.tag == "destructor")
		{
			//rota = spri.transform.position;
			h = 0;

			if (vibraniun)
			{
				Handheld.Vibrate();
			}
			Time.timeScale = 0;
			paus = 0;


			StartCoroutine(trasnport());
		}

		if (otr.gameObject.tag == "bomba" && !inmortal)
		{
			vidas = 0;
			StartCoroutine(muert());
			muerte = false;
			anim.SetBool("muerte", true);
		}


		if (otr.gameObject.tag == "coco" && inmortal == false)
		{

			if (canmuere)
			{
				canmuere = false;
				StartCoroutine(puedemorir());
				if (vidas > 0 && couna)
				{
					couna = false;
					StartCoroutine(coquitos());
					anim.SetBool("golpe", true);
					h = 0;
					vidas -= 1;
					if (vidas > 0)
					{
						anim.SetBool("muerte", false);
						muerte = true;
						//	print("prueba");

					}
					else
					{
						if (muerte)
						{
							StartCoroutine(muert());
							muerte = false;
							anim.SetBool("muerte", true);
						}

					}
					corazonroto.SetActive(false);
					corazonroto.SetActive(true);

					audio.clip = ay;
					audio.Play();
				}
			}

		}
		if (otr.gameObject.tag == "electry" && inmortal == false)
		{

			if (canmuere) {
				canmuere = false;
				JUICI.SetActive(false);
				JUICI.SetActive(true);
				StartCoroutine(puedemorir());

				if (vidas > 0 && couna)
				{
					couna = false;
					StartCoroutine(coquitos());
					anim.SetBool("golpe", true);
					h = 0;
					vidas -= 1;
					if (vidas > 0)
					{
						anim.SetBool("muerte", false);
						muerte = true;

					}
					else
					{
						if (muerte)
						{
							StartCoroutine(muert());
							muerte = false;
							anim.SetBool("muerte", true);
						}

					}
					corazonroto.SetActive(false);
					corazonroto.SetActive(true);

					audio.clip = ay;
					audio.Play();

					r.AddForce(Vector2.right * 50 * -guardah, ForceMode2D.Impulse);

				}
			}
		}


		if (otr.gameObject.tag == "cubo")
		{
			audio.PlayOneShot(logro);

		}
		if (otr.gameObject.tag == "cate")
		{
			audio.PlayOneShot(spuntos);
			PlayerPrefs.SetFloat("cate", PlayerPrefs.GetFloat("cate", 0) + 1);
			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
		}
		if (otr.gameObject.tag == "metros")
		{
			audio.PlayOneShot(metros);

		}
		if (otr.gameObject.tag == "salami")
		{
			PlayerPrefs.SetFloat("salami", PlayerPrefs.GetFloat("salami", 0) + 1);
			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
			audio.PlayOneShot(salami);


		}
		if (otr.gameObject.tag == "coca")
		{
			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
			PlayerPrefs.SetFloat("coca", PlayerPrefs.GetFloat("coca", 0) + 1);
			audio.PlayOneShot(coca);


		}

		if (otr.gameObject.tag == "chanclas")
		{
			speed = 50;
			velmin = 25;
			maxspeed = 70;
			anim.SetBool("chanclas", true);
			StartCoroutine(chanclas());
		}
		if (otr.gameObject.tag == "suelo")
		{
			anim.SetBool("salto", false);
			polvo.SetActive(false);
			polvo.SetActive(true);
		}

		if (otr.gameObject.tag == "casco")
		{
			casco.SetActive(true);
			botoncasco.SetActive(true);
			if (unacasc)
			{
				StartCoroutine(casc());
				unacasc = false;
			}

		}


		if (otr.gameObject.tag == "sj")
		{
			if (PlayerPrefs.GetFloat("jn", 0) == 0)
			{
				if (PlayerPrefs.GetFloat("nivel", 0) != 20)
				{
					bugs = false;
					PlayerPrefs.SetFloat("bugs", 1);
					minimenu.SetActive(true);
					planeta.inicio();
					canva.SetActive(false);

					PlayerPrefs.SetFloat("platanos", platano);


				}
				else
				{
					PlayerPrefs.SetFloat("platanos", platano);
					SceneManager.LoadScene("inicio");
				}
				StartCoroutine(paras());

				//	paus = 0;



				if (tuto == false) {
					sj += 1f;
					nivel += 1f;
					PlayerPrefs.SetFloat("nivel", nivel);
					PlayerPrefs.SetFloat("dia", PlayerPrefs.GetFloat("dia", 1) + 2);

					PlayerPrefs.SetFloat("sj", sj); }
				PlayerPrefs.SetFloat("gd", PlayerPrefs.GetFloat("dinero", 0));
				PlayerPrefs.SetFloat("gp", PlayerPrefs.GetFloat("poder", 0));
				PlayerPrefs.SetFloat("gpl", PlayerPrefs.GetFloat("platano", 0));
				PlayerPrefs.SetFloat("gpo", PlayerPrefs.GetFloat("pollo", 0));
				PlayerPrefs.SetFloat("gma", PlayerPrefs.GetFloat("mango", 0));
			}
			else
			{
				PlayerPrefs.SetFloat("platanos", platano);
				gest.mostrarreco();
				SceneManager.LoadScene("inicio");

			}

		} if (otr.gameObject.tag == "ba")
		{
			if (PlayerPrefs.GetFloat("jn", 0) == 0)
			{
				bugs = false;
				PlayerPrefs.SetFloat("bugs", 1);
				minimenu.SetActive(true);
				planeta.inicio();
				canva.SetActive(false);

				PlayerPrefs.SetFloat("platanos", platano);

				StartCoroutine(paras());




				if (tuto == false) {
					ba += 1f;
					nivel += 1f;
					PlayerPrefs.SetFloat("nivel", nivel);
					PlayerPrefs.SetFloat("dia", PlayerPrefs.GetFloat("dia", 1) + 1);
					PlayerPrefs.SetFloat("ba", ba); }

				PlayerPrefs.SetFloat("gd", PlayerPrefs.GetFloat("dinero", 0));
				PlayerPrefs.SetFloat("gp", PlayerPrefs.GetFloat("poder", 0));
				PlayerPrefs.SetFloat("gpl", PlayerPrefs.GetFloat("platano", 0));
				PlayerPrefs.SetFloat("gpo", PlayerPrefs.GetFloat("pollo", 0));
				PlayerPrefs.SetFloat("gma", PlayerPrefs.GetFloat("mango", 0));
			}
			else
			{
				PlayerPrefs.SetFloat("platanos", platano);
				gest.mostrarreco();
				SceneManager.LoadScene("inicio");

			}
		}






		if (otr.gameObject.tag == "sa")
		{
			if (PlayerPrefs.GetFloat("jn", 0) == 0)
			{
				bugs = false;
				PlayerPrefs.SetFloat("bugs", 1);
				minimenu.SetActive(true);
				planeta.inicio();
				canva.SetActive(false);

				PlayerPrefs.SetFloat("platanos", platano);
				StartCoroutine(paras());


				if (tuto == false)
				{
					sa += 1f;
					nivel += 1f;
					PlayerPrefs.SetFloat("nivel", nivel);
					PlayerPrefs.SetFloat("dia", PlayerPrefs.GetFloat("dia", 1) + 2);
					PlayerPrefs.SetFloat("sa", sa);
				}
				PlayerPrefs.SetFloat("gd", PlayerPrefs.GetFloat("dinero", 0));
				PlayerPrefs.SetFloat("gp", PlayerPrefs.GetFloat("poder", 0));
				PlayerPrefs.SetFloat("gpl", PlayerPrefs.GetFloat("platano", 0));
				PlayerPrefs.SetFloat("gpo", PlayerPrefs.GetFloat("pollo", 0));
				PlayerPrefs.SetFloat("gma", PlayerPrefs.GetFloat("mango", 0));
			}
			else
			{
				PlayerPrefs.SetFloat("platanos", platano);
				gest.mostrarreco();
				SceneManager.LoadScene("inicio");
			}
		}


		if (otr.gameObject.tag == "bani")
		{
			if (PlayerPrefs.GetFloat("jn", 0) == 0)
			{
				bugs = false;
				PlayerPrefs.SetFloat("bugs", 1);
				minimenu.SetActive(true);
				planeta.inicio();
				canva.SetActive(false);

				PlayerPrefs.SetFloat("platanos", platano);
				PlayerPrefs.SetFloat("dia", PlayerPrefs.GetFloat("dia", 1) + 2);
				StartCoroutine(paras());


				if (tuto == false)
				{
					nbani += 1f;
					nivel += 1f;
					PlayerPrefs.SetFloat("nivel", nivel);

					PlayerPrefs.SetFloat("bani", nbani);
				}


				PlayerPrefs.SetFloat("gd", PlayerPrefs.GetFloat("dinero", 0));
				PlayerPrefs.SetFloat("gp", PlayerPrefs.GetFloat("poder", 0));
				PlayerPrefs.SetFloat("gpl", PlayerPrefs.GetFloat("platano", 0));
				PlayerPrefs.SetFloat("gpo", PlayerPrefs.GetFloat("pollo", 0));
				PlayerPrefs.SetFloat("gma", PlayerPrefs.GetFloat("mango", 0));
			}
			else
			{
				PlayerPrefs.SetFloat("platanos", platano);
				gest.mostrarreco();
				SceneManager.LoadScene("inicio");
			}
		}


		if (otr.gameObject.tag == "yun")
		{
			yund.SetActive(true);
			PlayerPrefs.SetFloat("yun", 1f);
		}

		if (otr.gameObject.tag == "moto" && NOMASDE1)
		{
			if (serio)
			{
				if (vibraniun)
				{
					Handheld.Vibrate();
				}
				NOMASDE1 = false;
				StartCoroutine(NOMAS());
				if (cuenta > 3)
				{
					cuenta = 1;
				}

				if (cuenta == 1 && PlayerPrefs.GetFloat("mango", 0) == 0)
				{
					cuenta = 2;
				}

				if (platano == 0 && cuenta == 2)
				{
					cuenta = 3;
				}


				if (cuenta == 3 && PlayerPrefs.GetFloat("dinero", 0) == 0)
				{
					if (PlayerPrefs.GetFloat("mango", 0) > 0)
					{
						cuenta = 1;
					}
					else if (platano > 0)
					{
						cuenta = 2;
					}
				}
				if (PlayerPrefs.GetFloat("dinero", 0) == 0 && PlayerPrefs.GetFloat("mango", 0) == 0 && platano == 0)
				{
					vidas -= 1;
					if (vidas > 0)
					{
						anim.SetBool("muerte", false);
						muerte = true;


					}
					else
					{
						if (muerte)
						{
							StartCoroutine(muert());
							muerte = false;
							anim.SetBool("muerte", true);
						}

					}
					corazonroto.SetActive(false);
					corazonroto.SetActive(true);
					cuenta = 4;

					if (vidas > -1)
					{
						canvasmensajesdemeneso.SetActive(false);
						canvasmensajesdemeneso.SetActive(true);

						PUNALA.SetActive(true);
						mtext.SetActive(false);
						ptext.SetActive(false);
						dtext.SetActive(false);
					}
					else
					{
						perdermensaje.SetActive(true);
						text.text = PlayerPrefs.GetFloat("dinero", 0).ToString();
						audio.Stop();
						audio2.Stop();

						notasale();
						Time.timeScale = 0f;
					}
				}




				switch (cuenta) {

					case 1:

						if (PlayerPrefs.GetFloat("mango", 0) > 49)
						{
							PlayerPrefs.SetFloat("mango", PlayerPrefs.GetFloat("mango", 0) - 50);
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);

							ptext.SetActive(false);
							dtext.SetActive(false);
							mtext.SetActive(true);
							audio.clip = fail;
							audio.Play();
							man.text = "-50";
							subecuenta();




						} else
						{

							man.text = "-" + PlayerPrefs.GetFloat("mango", 0).ToString("f0");
							PlayerPrefs.SetFloat("mango", 0);
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);

							ptext.SetActive(false);
							dtext.SetActive(false);
							mtext.SetActive(true);
							audio.clip = fail;
							audio.Play();
							subecuenta();
						}
						break;


					case 2:
						if (platano > 49)
						{
							pla.text = "-50";
							platano -= 50;
							audio.clip = fail;
							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);


							dtext.SetActive(false);
							mtext.SetActive(false);
							ptext.SetActive(true);

							subecuenta();
						}
						else
						{
							pla.text = "-" + platano.ToString("f0");
							platano = 0f;
							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);


							dtext.SetActive(false);
							mtext.SetActive(false);
							ptext.SetActive(true);
							subecuenta();
						}
						break;







					case 3:

						if (PlayerPrefs.GetFloat("dinero", 0) > 499)
						{
							din.text = "-500";
							PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 500);
							textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
							audio.clip = fail;
							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);



							mtext.SetActive(false);
							ptext.SetActive(false);
							dtext.SetActive(true);
							din.text = "-500";
							subecuenta();
						}
						else
						{

							din.text = "-" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
							PlayerPrefs.SetFloat("dinero", 0);
							textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);



							mtext.SetActive(false);
							ptext.SetActive(false);
							dtext.SetActive(true);
							subecuenta();
						}
						break;



					case 4:
						break;


				}









			}
		}

		if (otr.gameObject.tag == "platano" || otr.gameObject.tag == "mango" || otr.gameObject.tag == "peso")
		{
			puntos.soni = true;

			provisiones = platano + PlayerPrefs.GetFloat("mango", 0) + PlayerPrefs.GetFloat("pollo", 0) + PlayerPrefs.GetFloat("cate", 0) + PlayerPrefs.GetFloat("coca", 0) + PlayerPrefs.GetFloat("salami", 0) + PlayerPrefs.GetFloat("fruticas", 0);
			contador.text = provisiones.ToString();
			textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");

			text.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
		}




		if (otr.gameObject.tag == "area1" && NOMASDE1)
		{
			if (mangacami)
			{
				if (vibraniun)
				{
					Handheld.Vibrate();
				}
				NOMASDE1 = false;
				StartCoroutine(NOMAS());
				if (cuenta > 3)
				{
					cuenta = 1;
				}
				if (cuenta == 1 && PlayerPrefs.GetFloat("mango", 0) == 0)
				{
					cuenta = 2;
				}

				if (platano == 0 && cuenta == 2)
				{
					cuenta = 3;
				}

				if (cuenta == 3 && PlayerPrefs.GetFloat("dinero", 0) == 0)
				{ if (PlayerPrefs.GetFloat("mango", 0) > 0)
					{
						cuenta = 1;
					} else if (platano > 0)
					{
						cuenta = 2;
					}

				}
				if (PlayerPrefs.GetFloat("dinero", 0) == 0 && PlayerPrefs.GetFloat("mango", 0) == 0 && platano == 0)
				{
					vidas -= 1;
					if (vidas > 0)
					{
						anim.SetBool("muerte", false);
						muerte = true;

					}
					else
					{
						if (muerte)
						{
							StartCoroutine(muert());
							muerte = false;
							anim.SetBool("muerte", true);
						}

					}
					corazonroto.SetActive(false);
					corazonroto.SetActive(true);
					cuenta = 4;
					if (vidas > -1)
					{
						canvasmensajesdemeneso.SetActive(false);
						canvasmensajesdemeneso.SetActive(true);

						PUNALA.SetActive(true);
						mtext.SetActive(false);
						ptext.SetActive(false);
						dtext.SetActive(false);
					}
					else
					{
						perdermensaje.SetActive(true);
						text.text = PlayerPrefs.GetFloat("dinero", 0).ToString();
						audio.Stop();
						audio.clip = aah;
						audio.Play();
						notasale();
						Time.timeScale = 0f;
					}
				}




				switch (cuenta)
				{

					case 1:

						if (PlayerPrefs.GetFloat("mango", 0) > 49)
						{
							PlayerPrefs.SetFloat("mango", PlayerPrefs.GetFloat("mango", 0) - 50);
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);

							ptext.SetActive(false);
							dtext.SetActive(false);
							mtext.SetActive(true);
							audio.clip = fail;
							audio.Play();
							man.text = "-50";
							subecuenta();




						}
						else
						{

							man.text = "-" + PlayerPrefs.GetFloat("mango", 0).ToString("f0");
							PlayerPrefs.SetFloat("mango", 0);
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);

							ptext.SetActive(false);
							dtext.SetActive(false);
							mtext.SetActive(true);
							audio.clip = fail;
							audio.Play();
							subecuenta();
						}
						break;


					case 2:
						if (platano > 49)
						{
							pla.text = "-50";
							platano -= 50;
							audio.clip = fail;
							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);


							dtext.SetActive(false);
							mtext.SetActive(false);
							ptext.SetActive(true);

							subecuenta();
						}
						else
						{
							pla.text = "-" + platano.ToString("f0");
							platano = 0f;
							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);


							dtext.SetActive(false);
							mtext.SetActive(false);
							ptext.SetActive(true);
							subecuenta();
						}
						break;







					case 3:

						if (PlayerPrefs.GetFloat("dinero", 0) > 499)
						{
							din.text = "-500";
							PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 500);
							textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
							audio.clip = fail;
							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);



							mtext.SetActive(false);
							ptext.SetActive(false);
							dtext.SetActive(true);

							subecuenta();
						}
						else
						{

							din.text = "-" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
							PlayerPrefs.SetFloat("dinero", 0);
							textodinero.text = "$" + PlayerPrefs.GetFloat("dinero", 0).ToString("f0");
							audio.Play();
							canvasmensajesdemeneso.SetActive(false);
							canvasmensajesdemeneso.SetActive(true);

							PUNALA.SetActive(false);



							mtext.SetActive(false);
							ptext.SetActive(false);
							dtext.SetActive(true);
							subecuenta();
						}
						break;

					case 4:
						break;


				}




			}
		}


		if (otr.gameObject.tag == "alcantarilla" && u[0])
		{
			audio2.PlayOneShot(alcantarilla);
			dia2.SetActive(true);
			paneles.SetActive(true);
			h = 0;
			StartCoroutine(v1());
			u[0] = false;

		}
		if (otr.gameObject.tag == "d1" && u[1])
		{
			u[1] = false;
			paneles.SetActive(true);

			h = 0;
			StartCoroutine(v1());


			audio2.PlayOneShot(d1);
		}
		if (otr.gameObject.tag == "d2" && u[2])
		{
			u[2] = false;
			a1.SetActive(true);
			//a3.SetActive(true);
			audio2.PlayOneShot(d2);
			dia3.SetActive(true);
			d.color = gris;
			iz.color = gris;
			a.color = gris;
			p.color = gris;
			c.color = color5;
			paneles.SetActive(true);
			h = 0;
			StartCoroutine(v1());
		}
			
		
		if (otr.gameObject.tag == "d3" && u[3])
		{
			u[3] = false;
			paneles.SetActive(true);
			h = 0;
			dia4.SetActive(true);
			dia5.SetActive(true);
			d.color = gris;
			iz.color = gris;
			a.color = gris;
			p.color = color4;
			c.color = gris;
			a2.SetActive(true);
			
			StartCoroutine(v3());
			audio2.PlayOneShot(d3);
		}



			if (otr.gameObject.tag == "d4" && u[4])
		{
			u[4] = false;
			audio2.PlayOneShot(d4);
			dia6.SetActive(true);
			if (contadorpoder > 1)
			{
				contadorpoder = 1;
			}
		
			StartCoroutine(v1());
		}
			if (otr.gameObject.tag == "d5" && u[5])
		{
			u[5] = false;
			audio2.PlayOneShot(d5); paneles.SetActive(true);
			h = 0;
			StartCoroutine(v1());
		}






			if (otr.gameObject.tag == "poli" && confirma)
			{ 


				{

					h = 0;
					ATRAPADO.SetActive(true);

					paus = 0f;
					gco = transform.position;
					if (unave)
					{
						StartCoroutine(iniciarpregunta());
					gestora.sto();
						unave = false;
					}
					anim.SetBool("deten", true);


					destruir.gameObject.SetActive(true);
					destruir2.gameObject.SetActive(true);

					ali.correc = false;
					boto.SetActive(false);
					confirma = false;

				}



			}


		}

	public SONIDOALERTA soni;
		public void subecuenta()
		{
			if (cuenta > 3)
			{
				cuenta = 1;
			}
			cuenta += 1;
		}
		public IEnumerator con()
		{
			yield return new WaitForSecondsRealtime(1f);
			confirma = true;
		}

	public IEnumerator v1()
	{
		yield return new WaitForSecondsRealtime(3f);
		paneles.SetActive(false);
		d.color = color1;
		iz.color = color2;
		a.color = color3;
		p.color = color4;
		c.color = color5;
		a1.SetActive(false);
		a2.SetActive(false);
		yield return new WaitForSecondsRealtime(1f);
		a1.SetActive(false);
		a2.SetActive(false);

		dia2.SetActive(false);
		dia3.SetActive(false);
		dia6.SetActive(false);


	}
	public IEnumerator v2()
	{
	
		yield return new WaitForSecondsRealtime(2f);
		dia1.SetActive(false);
	}

	public Transform pared;
	public GameObject paredg;
	public bool rompe = false;
	public IEnumerator v3()
	{


		yield return new WaitForSecondsRealtime(3f);
		d.color = color1;
		iz.color = color2;
		a.color = color3;
		p.color = color4;
		c.color = color5;
		paneles.SetActive(false);
		a1.SetActive(false);
		a2.SetActive(false);

		yield return new WaitForSecondsRealtime(3f);
		dia4.SetActive(false);

		yield return new WaitForSecondsRealtime(1f);
		dia5.SetActive(false);
		


		yield return new WaitForSecondsRealtime(20);
		/*if (transform.position.x < pared.transform.position.x)
		{
			paredg.SetActive(false);
		}
		yield return new WaitForSecondsRealtime(20);
		if (transform.position.x < pared.transform.position.x)
		{
			paredg.SetActive(false);
		}*/

	}

	public bool[] u = new bool[6];

	public IEnumerator v4()
	{
		bo4.color = Color.red;
		yield return new WaitForSecondsRealtime(0.5f);
		bo4.color = Color.white;
		yield return new WaitForSecondsRealtime(0.5f);
		bo4.color = Color.red;
		yield return new WaitForSecondsRealtime(0.5f);
		bo1.color = Color.white;
		paneles.SetActive(false);

	}
	public IEnumerator v5()
	{
		bo5.color = Color.red;
		yield return new WaitForSecondsRealtime(0.5f);
		bo5.color = Color.white;
		yield return new WaitForSecondsRealtime(0.5f);
		bo5.color = Color.red;
		yield return new WaitForSecondsRealtime(0.5f);
		bo5.color = Color.white;
		paneles.SetActive(false);

	}

    public bool confirma = true;
	public GameObject paneles;
	public GameObject a1;
	public GameObject a2;
	public GameObject a3;
	public GameObject a4;

	public Image bo1;
	public Image bo2;
	public Image bo3;
	public Image bo4;
	public Image bo5;

	
	public void iniciarpld()
    {
		StartCoroutine(pld());
    }
	IEnumerator pld()
    {
		PlayerPrefs.SetFloat("local", botonbruja.localScale.y);
		yield return new WaitForSecondsRealtime(1f);
		if (norepetir)
		{
			norepetir = false;
			if (PlayerPrefs.GetFloat("jn", 0) == 0)
			{

				PlayerPrefs.SetFloat("bugs", 1);
				bugs = false;
				ssd += 1f;
				PlayerPrefs.SetFloat("dia", PlayerPrefs.GetFloat("dia", 1) + 2);
				if (PlayerPrefs.GetFloat("nivel", 1) == 15)
				{
					if (PlayerPrefs.GetFloat("dinero", 0) >= 100000)
					{
						SceneManager.LoadScene("m1win");
					}
					else
					{
						SceneManager.LoadScene("m1lose");
					}

				}
				else if (PlayerPrefs.GetFloat("nivel", 0) == 30)
				{
					SceneManager.LoadScene("deli");
				}
				else if (PlayerPrefs.GetFloat("nivel", 0) == 85)
				{
					SceneManager.LoadScene("final");
                }
                else if(PlayerPrefs.GetFloat("nivel", 0) == 20)
                {
					cargarmenu.SetActive(true);
                }
				else
				{
					minimenu.SetActive(true);
					planeta.inicio();
				}




				canva.SetActive(false);

				PlayerPrefs.SetFloat("platanos", platano);
				StartCoroutine(paras());
				generarp.cancelargen();



				nivel += 1f;
				PlayerPrefs.SetFloat("nivel", nivel);


				PlayerPrefs.SetFloat("sd", ssd);



				PlayerPrefs.SetFloat("gd", PlayerPrefs.GetFloat("dinero", 0));
				PlayerPrefs.SetFloat("gp", PlayerPrefs.GetFloat("poder", 0));
				PlayerPrefs.SetFloat("gpl", PlayerPrefs.GetFloat("platano", 0));
				PlayerPrefs.SetFloat("gpo", PlayerPrefs.GetFloat("pollo", 0));
				PlayerPrefs.SetFloat("gma", PlayerPrefs.GetFloat("mango", 0));



			}
			else
			{ 
				PlayerPrefs.SetFloat("platanos", platano);
				if (PlayerPrefs.GetInt("anuncios", 1) == 1)
				{ gest.mostrarreco(); }
				SceneManager.LoadScene("inicio");
			}

		}
	}

}




