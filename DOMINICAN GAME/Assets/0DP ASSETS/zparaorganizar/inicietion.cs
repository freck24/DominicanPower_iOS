using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Proyecto26;
using EMGame;

public class inicietion : MonoBehaviour
{
    public GameObject DestruirGrupo;
    public PreLoaderLevel ScreenLoader;
    public List<string> NombreEscenas; 

    public GameObject[] CU;
    public string youtube="https://youtube.com/c/EUProduccionesMusicales";

    

    public void you()
    {
        Application.OpenURL(youtube);
    }
    public int version = 0;
    public int versionAPLICACION = 1;
 
    public void verificandoversion()
    {
       U u = new U();
        RestClient.Get<U>("https://domincanpower-70241.firebaseio.com/Version" + ".json").Then(onResolved: response => {

            u = response;
            version = u.v;

        });
    }

    public void Boton_IniciarSaltado( int LevelSaltado)
    {

        print("Iniciar Saltado A: " + LevelSaltado); 
        PlayerPrefs.SetInt("NivelSaltado", 1);
        PlayerPrefs.SetFloat("NivelSaltado_ID", LevelSaltado-1);

        print("NivelJugar: " + (LevelSaltado - 1).ToString());
        NewCargaID(0);


    }
    public void Boton_IniciarAventura()
    {
        print("Iniciar Saltado");

        PlayerPrefs.SetInt("NivelSaltado", 0);
        PlayerPrefs.SetFloat("NivelSaltado_ID", 0);

        if (PlayerPrefs.GetFloat("nivel", 1) == 16)
        { if (PlayerPrefs.GetFloat("gana1", 0) == 0)
            {
                if (PlayerPrefs.GetFloat("dinero", 0) > 99999)
                {
                    NewCargaID(10); //m1 gana
                }
                else
                {
                    NewCargaID(11); //m1 pierde
                }
            }
            else
            {
                NewCargaID(12); // telefono
            }


        } else
        {
            if(PlayerPrefs.GetFloat("nivel", 1) != 86)
            {
                NewCargaID(0); // cargar level 1 clone
            }
            else
            {
                c14();
            }
    
        }

    } 

    public void NewCargaID(int id)
    {
        ScreenLoader.scena = NombreEscenas[id];

        Destroy(DestruirGrupo);

        ScreenLoader.gameObject.SetActive(true);


    }


    public void c2()
    {
        NewCargaID(1);
    } 
    public void c3()
    {
        NewCargaID(2);

    }
    public void c4()
    {
        NewCargaID(3);
    } 
    public void c5()
    {
        NewCargaID(4);
    } 
    public void c6()
    {
        NewCargaID(5);
    } 
    public void c7()
    {
        NewCargaID(6);
    }
    public void c8()
    {
        NewCargaID(7);
    }
    public void c9()
    {
        NewCargaID(8);
    }

    public void c11()
    {
        NewCargaID(10);
    } public void c12()
    {
        NewCargaID(11);
    } public void c13()
    {
        NewCargaID(12);
    } public void c14()
    {
        NewCargaID(13);
    }
   

    public GameObject controles;

    public void abrircontroles()
    {
        controles.SetActive(true);
    }public void cerrarcontroles()
    {
        controles.SetActive(false);
    }
    

    public AudioClip pop;
    public AudioClip fail;
    public AudioClip sa;
    public AudioClip comprar;
    private AudioSource a;
    public GameObject yunr;
    public GameObject trucanor;
    public GameObject par;
    public GameObject mision1;
    public GameObject camaraintro;
    public GameObject moto;
    public GameObject carro;
    public GameObject m30;
    public GameObject conf;
    public GameObject PP;
    public Text DIA;
    public GameObject cred;
    //  float numerosas = 4;

    // Start is called before the first frame update

    public GameObject ccm1;
    public GameObject ccm2;
    public GameObject ccm3;
    public GameObject ccm4;
    public GameObject ccm5;
    public GameObject ccm6;

    public GameObject mision300;
    public GameObject mision500;
    public GameObject misionp;
    public GameObject mision2;
    public GameObject mision3;
    public GameObject cubosm;
    public GameObject delinc;
    public GameObject mis;

    public void cerrarmisiones()
    {
        mis.SetActive(false);
        a.PlayOneShot(pop);
    }
    public void abrirmisiones()
    {
        mis.SetActive(true);
        a.PlayOneShot(pop);
    }

    public Text VIBRARR;
    public AudioListener ESCUCHADOR;
    public void ACTVIBRAR()
    { if (PlayerPrefs.GetInt("vibrar", 1) == 0)
        {
            PlayerPrefs.SetInt("vibrar", 1);
            VIBRARR.text = "VIBRAR: SI";
        } else
        {
            PlayerPrefs.SetInt("vibrar", 0);
            VIBRARR.text = "VIBRAR: NO";

        }
    } public void SONIDOF()
    { if (PlayerPrefs.GetInt("sonido", 1) == 0)
        {
            PlayerPrefs.SetInt("sonido", 1);
            SONIDO.text = "SONIDO: SI";
            ESCUCHADOR.enabled = true;
        } else
        {
            PlayerPrefs.SetInt("sonido", 0);
            SONIDO.text = "SONIDO: NO";
            ESCUCHADOR.enabled = false;
        }
    }



    public Text PV;
    void misiones()
    {

        if (PlayerPrefs.GetFloat("dinero", 0) > 99999 && PlayerPrefs.GetFloat("cm1", 0) == 0)
        {
            PlayerPrefs.SetFloat("cm1", 1);
            ccm1.SetActive(true);


        }


        if (PlayerPrefs.GetFloat("cm1", 0) == 1)
        {

            misionp.SetActive(false);
        }

        if (PlayerPrefs.GetFloat("cm1", 0) == 1 && PlayerPrefs.GetFloat("cm6", 0) == 0)
        {
            cubosm.SetActive(true); //poner cuando acepte mision

        }

        if (PlayerPrefs.GetFloat("niveld", 0) > 149 && PlayerPrefs.GetFloat("cm2", 0) == 0)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 25000);
            PlayerPrefs.SetFloat("cm2", 1);
            ccm2.SetActive(true);

        }
        if (PlayerPrefs.GetFloat("cm2", 0) == 1 && PlayerPrefs.GetFloat("cm4", 0) == 0)
        {
            mision300.SetActive(true);

        }
        if (PlayerPrefs.GetFloat("cm2", 0) == 1)
        {

            mision2.SetActive(false);
        }

        if (PlayerPrefs.GetFloat("platanov", 0) > 999 && PlayerPrefs.GetFloat("cm3", 0) == 0)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 25000);
            PlayerPrefs.SetFloat("cm3", 1);
            ccm3.SetActive(true);
        }
        else
        {
            PV.text = PlayerPrefs.GetFloat("platanov", 0) + "/1000";
        }

        if (PlayerPrefs.GetFloat("cm3", 0) == 1)
        {
            mision3.SetActive(false);
        }

        if (PlayerPrefs.GetFloat("niveld", 0) > 299 && PlayerPrefs.GetFloat("cm4", 0) == 0)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 25000);
            PlayerPrefs.SetFloat("cm4", 1);
            ccm4.SetActive(true);

        }

        if (PlayerPrefs.GetFloat("cm4", 0) == 1 && PlayerPrefs.GetFloat("cm5", 0) == 0)
        {
            mision500.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("cm4", 0) == 1)
        {
            mision300.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("niveld", 0) > 499 && PlayerPrefs.GetFloat("cm5", 0) == 0)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 50000);
            PlayerPrefs.SetFloat("cm5", 1);
            ccm5.SetActive(true);
        }






        if (PlayerPrefs.GetFloat("cubosm", 0) == 1 && PlayerPrefs.GetFloat("cm6", 0) == 0)
        {
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 250000);
            PlayerPrefs.SetFloat("cm6", 1);
            ccm6.SetActive(true);

        }


        /*  if (PlayerPrefs.GetFloat("cm6", 0) == 1)
          {
              misionc.SetActive(false);
          }*/
    }





    public void credi()
    {
        POP();
        cred.SetActive(true);
    } public void ccredi()
    {
        POP();
        cred.SetActive(false);
    }
    public void config()
    {
        POP();
        conf.SetActive(true);
    } public void cconfig()
    {
        POP();
        conf.SetActive(false);
    }
    public void iracasa()
    {
        POP();
        if (PlayerPrefs.GetFloat("dinero", 0) > 99999)
        {
            SceneManager.LoadScene("m1win");
        }
        else
        {
            SceneManager.LoadScene("m1lose");
        }
    }




    public Text NIVELDOMI;
    public Text NIVELDOMI2;
    public Text NIVELDOMI23;
    public GameObject ni;
    public GameObject tni;
    public GameObject compartir;

    public GameObject con1;
    public GameObject con2;

    public void compa()
    {
        POP();
        compartir.SetActive(true);
    } public void ccompa()
    {
        POP();
        compartir.SetActive(false);
    }
    public GameObject TEMPORADA;
    public void anio()
    {
        POP();
        ni.SetActive(true);
        tni.SetActive(true);
        TEMPORADA.SetActive(true);

    }
    public void canio()
    {
        POP();
        ni.SetActive(false);
        tni.SetActive(false);
        TEMPORADA.SetActive(false);
    }

    public GameObject valoracion;


    public void cvaloracion()
    {
        POP();
        valoracion.SetActive(false);
    }
    public string game;
    public string ig;
    public string FC;
    public void valor()
    {
        POP();
        Application.OpenURL(game);
        PlayerPrefs.SetFloat("v", 1);
        valoracion.SetActive(false);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 5000);
    }
    public void igs()
    {
        POP();
        Application.OpenURL(ig);
    }

    public void FCS()
    {
        POP();
        Application.OpenURL(FC);
    }


    public void cerrar1()
    {
        ccm1.SetActive(false);
        POP();
    } public void cerrar2()
    {
        ccm2.SetActive(false);
        POP();
        mision2.SetActive(false);
    } public void cerrar3()
    {
        ccm3.SetActive(false);
        POP();
    } public void cerrar4()
    {
        ccm4.SetActive(false);
        mision300.SetActive(false);
        POP();
    } public void cerrar5()
    {
        mision500.SetActive(false);
        ccm5.SetActive(false);
        POP();
    } public void cerrar6()
    {
        ccm6.SetActive(false);
        cubosm.SetActive(false);
        POP();
    }

    public GameObject mensajecubos;
    public GameObject botonnocubos;
    public void completarcubos()
    {
        mensajecubos.SetActive(true);
    }
    public void ccompletarcubos()
    {
        minijueos();
        anio();
        mensajecubos.SetActive(false);
    }

    public GameObject cubo1;
    public GameObject cubo2;
    public GameObject cubo3;
    public GameObject cubo4;
    public GameObject cubo5;
    public GameObject misionc;

    public GameObject nuevo;
    public GameObject blocka;
    public GameObject juegos;
    public string urlsoygenio;

    public void masjuegos()
    {
        juegos.SetActive(true);
    }
    public void cmasjuegos()
    {
        juegos.SetActive(false);
    }
    public void irsoygenio()
    {
        Application.OpenURL(urlsoygenio);
    }


    public void subenivels()
    {
        PlayerPrefs.SetFloat("nivel", PlayerPrefs.GetFloat("nivel", 0) + 1);
        PlayerPrefs.SetFloat("dinero", 1000000);


    }

    public void TIENDA()
    {
        you();

    }

    public void CHICHI()
    {
        SceneManager.LoadScene("chichi");
    } public void minijuego5()
    {
        SceneManager.LoadScene("minijuego5");
    }
    public void RAYITA()
    {
        SceneManager.LoadScene("rayita");
    }


    public float dia;
    public float nivel;
    public Text correctas;
    public Text incorrectas;
    public Transform correctast;
    public GameObject nohaydatos;
    public float c;
    public float i;
    public float d;
    public GameObject considera;
    public GameObject considera2;

    public void cerrarconsideras()
    {
        considera.SetActive(false);
        considera2.SetActive(true);
        StartCoroutine(cierr());
        PlayerPrefs.SetInt("comprapublicidad", 1);


    }

    IEnumerator cierr()
    {
        yield return new WaitForSecondsRealtime(10);
        considera2.SetActive(false);
    }

    public GameObject animacion;
    public void trancicion()
    {
        animacion.SetActive(false);
        animacion.SetActive(true);
    }

    public string[] FCUBOS = new string[5];
    public void estadisticas()
    {
        c = PlayerPrefs.GetInt("correct", 0);
        i = PlayerPrefs.GetInt("incorrect", 0);

        if (c == 0 && i == 0)
        {
            i = 1;
        }

        d = c / (c + i);
        if (d > 0)
        {
            correctast.localScale = new Vector3(correctast.localScale.x * d, correctast.localScale.y, correctast.localScale.z);
            correctas.text = c.ToString("f0");
            incorrectas.text = i.ToString("f0");
        }
        else
        {
            nohaydatos.SetActive(true);
        }

    }


    public Text SONIDO;
    public Text FALTANCU;
    public GameObject A;



    void Start()
    {
        Time.timeScale = 1;

        //PlayerPrefs.SetFloat("nivel", 86);
        Check_Liberado();


        if (PlayerPrefs.GetInt("anuncios", 1) == 0 || PlayerPrefs.GetInt("VIP", 0) == 1)
        {
            A.SetActive(true);
        }
        //  PlayerPrefs.SetFloat("nivel", 84);
        estadisticas();
        if (PlayerPrefs.GetInt("comprapublicidad", 0) == 0 && PlayerPrefs.GetFloat("nivel", 0) > 6 && PlayerPrefs.GetInt("anuncios", 1) == 1)
        {
            considera.SetActive(true);
        }



        dia = PlayerPrefs.GetFloat("dia", 1);
        nivel = PlayerPrefs.GetFloat("nivel", 1);


        if (PlayerPrefs.GetInt("vibrar", 1) == 1)
        {
            VIBRARR.text = "VIBRAR: SI";
        }
        else
        {

            VIBRARR.text = "VIBRAR: NO";
        }

        if (PlayerPrefs.GetInt("sonido", 1) == 1)
        {

            SONIDO.text = "SONIDO: SI";

        }
        else
        {

            SONIDO.text = "SONIDO: NO";
            ESCUCHADOR.enabled = false;
        }


        if (PlayerPrefs.GetFloat("nivel", 0) == 31)
        {
            delinc.SetActive(true);
        }
        // PlayerPrefs.SetFloat("nivel", 30);
        if (PlayerPrefs.GetFloat("cubosm", 0) == 0 && PlayerPrefs.GetFloat("nivel", 0) == 21)
        {
            botonnocubos.SetActive(true);
            mensajecubos.SetActive(true);
        }


        if (PlayerPrefs.GetFloat("nivel", 0) > 16) {
            blocka.SetActive(false);
        }
        //  PlayerPrefs.SetFloat("dinero", 100005);


        if (PlayerPrefs.GetFloat("nivel", 0) == 16 && PlayerPrefs.GetFloat("cm1", 0) == 1 || PlayerPrefs.GetFloat("nivel", 0) == 21 && PlayerPrefs.GetFloat("cubosm", 0) == 1 || PlayerPrefs.GetFloat("nivel", 0) == 31 || PlayerPrefs.GetFloat("nivel", 0) == 41 || PlayerPrefs.GetFloat("nivel", 0) == 55)
        {
            nuevo.SetActive(true);
        }



        if (PlayerPrefs.GetFloat("cuboa", 0) > 0) {
            CU[0].SetActive(true);
            FCUBOS[0] = "";
        }
        if (PlayerPrefs.GetFloat("cubor", 0) > 0) {
            CU[1].SetActive(true);
            FCUBOS[1] = "";
        } if (PlayerPrefs.GetFloat("cubov", 0) > 0) {
            CU[2].SetActive(true);
            FCUBOS[2] = "";
        }
        if (PlayerPrefs.GetFloat("cuboro", 0) > 0) {
            CU[3].SetActive(true);
            FCUBOS[3] = "";
        } if (PlayerPrefs.GetFloat("cuboaz", 0) > 0) { CU[4].SetActive(true);
            FCUBOS[4] = "";
        }


        for (int wwe = 0; wwe < FCUBOS.Length; wwe++)
        {
            FALTANCU.text += FCUBOS[wwe] + "\n";
        }

        FALTANCU.text += "REPITE EL NIVEL Y BUSCALOS";


        misiones();

        if (PlayerPrefs.GetFloat("v", 0) == 0 && PlayerPrefs.GetFloat("nivel", 0) > 13)
        {
            valoracion.SetActive(true);
        }





        if (PlayerPrefs.GetFloat("dia", 0) > 30)
        {
            mision1.SetActive(false);

        }
        if (PlayerPrefs.GetFloat("dia", 0) > 30 && PlayerPrefs.GetFloat("cm6", 0) == 0)
        {
            misionc.SetActive(true);

        }



        PlayerPrefs.SetFloat("jn", 0);
        NIVELDOMI.text = "" + PlayerPrefs.GetFloat("niveld", 0);
        NIVELDOMI2.text = "" + PlayerPrefs.GetFloat("niveld", 0);
        NIVELDOMI23.text = "" + ((PlayerPrefs.GetFloat("niveld", 0) / 500) * 100).ToString("f0") + "%";
        if (PlayerPrefs.GetFloat("dia", 1) == 30)
        {
            m30.SetActive(true);
        }

        if (PlayerPrefs.GetFloat("moto", 0) == 1)
        {
            moto.SetActive(true);
            carro.SetActive(false);

        } else
    if (PlayerPrefs.GetFloat("carro", 0) == 1)
        {
            carro.SetActive(true);
            moto.SetActive(false);
        }
        DIA.text = "DÍA " + PlayerPrefs.GetFloat("dia", 1);
        a = GetComponent<AudioSource>();
        panel.SetActive(false);


        if (PlayerPrefs.GetFloat("p1", 0) == 0) {

            camaraintro.SetActive(true);
            mision1.SetActive(false);
            StartCoroutine(intro());

        }
        else
        {
            // StartCoroutine(sasasa());
        }

        /*     if (PlayerPrefs.GetFloat("dia", 1) > 30)
             {
                 mision1.SetActive(false);
             }*/
        StartCoroutine(VER());

    }

    public GameObject actualiza;

    public string url;

    public void ir()
    {
        Application.OpenURL(url);

    }
    public void mastarde()
    {
        actualiza.SetActive(false);
    }

    IEnumerator VER()
    {
        yield return new WaitForSecondsRealtime(2);
        verificandoversion();
        yield return new WaitForSecondsRealtime(1);

        if (version > versionAPLICACION)
        {
            actualiza.SetActive(true);
        }
    }
    public IEnumerator sasasa()
    {

        {
            yield return new WaitForSecondsRealtime(0);
            a.clip = sa;
            a.Play();




        }
    }

    public IEnumerator intro()
    {
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("introa");
    }


    // Update is called once per frame
    void Check_Liberado()
    {

        if (PlayerPrefs.GetFloat("nivel", 0) > 7) blockcu.SetActive(false);



        if (PlayerPrefs.GetFloat("nivel", 0) > 1) yunr.SetActive(false);
        else yunr.SetActive(true);


        if (PlayerPrefs.GetFloat("nivel", 0) > 4) trucanor.SetActive(false);
        else trucanor.SetActive(true);


        if (PlayerPrefs.GetFloat("nivel", 0) > 6) par.SetActive(false);
        else par.SetActive(true);




        if (PlayerPrefs.GetFloat("nivel", 0) > 1)
        {
            cont.SetActive(true);
            emp.SetActive(false);
        }
        else
        {
            cont.SetActive(false);
            emp.SetActive(true);
        }
    }



    public GameObject panel;
    public GameObject CAP;
    public GameObject cont;
    public GameObject emp;
    public GameObject PORTADACAP2;
    public GameObject mensajenotienes;


    public void del()
    {
        SceneManager.LoadScene("deli");
    }

    public void minijueos()
    {
        a.clip = pop;
        a.Play();
        panel.SetActive(false);
        panel.SetActive(true);

    }
    public void cminijueosc()
    {
        a.clip = pop;
        a.Play();
        panel.SetActive(false);

    }


    public void yun()
    {

        if (PlayerPrefs.GetFloat("nivel", 0) > 1 && PlayerPrefs.GetFloat("dinero", 0) > 4)
        {
            a.clip = comprar;
            a.Play();
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - 5f);
            SceneManager.LoadScene("yun");
        }

        else
        {
            a.clip = fail;
            a.Play();
        }


        if (PlayerPrefs.GetFloat("dinero", 0) < 5)
        {
            mensajenotienes.SetActive(true);
            StartCoroutine(mensaje());

            a.clip = fail;
            a.Play();
        }



    } public void AVION()
    {

        if (PlayerPrefs.GetFloat("nivel", 0) > 16 && PlayerPrefs.GetFloat("dinero", 0) > 99)
        {
            a.clip = comprar;
            a.Play();
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - 100f);
            SceneManager.LoadScene("avion");
        }

        else
        {
            a.clip = fail;
            a.Play();
        }


        if (PlayerPrefs.GetFloat("dinero", 0) < 100)
        {
            mensajenotienes.SetActive(true);
            StartCoroutine(mensaje());

            a.clip = fail;
            a.Play();
        }



    }
    public void pa()
    {

        if (PlayerPrefs.GetFloat("nivel", 0) > 6 && PlayerPrefs.GetFloat("dinero", 0) > 74)
        {
            a.clip = comprar;
            a.Play();
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - 75f);
            SceneManager.LoadScene("pa");
        }
        else

        {
            a.clip = fail;
            a.Play();
        }

    }



    public void facil()
    {
        SceneManager.LoadScene("trucano");
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - 25f);
        a.clip = comprar;
        a.Play();
    } public void nacil()
    {
        SceneManager.LoadScene("trucano 1");
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - 25f);
        a.clip = comprar;
        a.Play();
    }

    public GameObject TRUCANMINI;


    public void trucano()

    {


        if (PlayerPrefs.GetFloat("nivel", 0) > 3 && PlayerPrefs.GetFloat("dinero", 0) > 24)

        {

            a.clip = pop;
            a.Play();
            TRUCANMINI.SetActive(true);

        }
        else
        {
            a.clip = fail;
            a.Play();
        }



        if (PlayerPrefs.GetFloat("dinero", 0) < 25)
        {
            mensajenotienes.SetActive(true);
            StartCoroutine(mensaje());
            a.clip = fail;
            a.Play();
        }

    }

    public void CERRARM()
    {
        mensajenotienes.SetActive(false);
    }


    public void POP()
    {
        a.clip = pop;
        a.Play();
    }

    public void capitulo()
    {
        POP();
        CAP.SetActive(true);
    } public void BLOQ()
    {
        a.clip = fail;
        a.Play();
    } public void CAP2()
    {
        if (PlayerPrefs.GetFloat("nivel", 1) > 6)
        {
            PORTADACAP2.SetActive(false);
            PORTADACAP2.SetActive(true);
        }
        else
        {
            BLOQ();
        }
    }




    public void POLITICA()
    {
        PP.SetActive(false);
        PP.SetActive(true);
    }
    public void Ccapitulo()
    {
        POP();
        CAP.SetActive(false);
    }

    public IEnumerator mensaje()
    {


        yield return new WaitForSeconds(2f);
        CERRARM();
    }



    public void desbloquear()
    {
        PlayerPrefs.SetFloat("yun", 1f);
        PlayerPrefs.SetFloat("trucano", 1f);
        PlayerPrefs.SetFloat("platanos", 1000);
        PlayerPrefs.SetFloat("nivel", 10);
    }

    public GameObject blockcu;
    public void cuerda()
    {
        if (PlayerPrefs.GetFloat("nivel", 0) > 7)
        {
            SceneManager.LoadScene("cuerda");
        }
    }









    // gestor de misiones

    public GameObject rm1;
    public GameObject rm2;
    public GameObject rm3;
    public GameObject rm4;
    public GameObject rm5;


    public void m1()
    {
        POP();
        rm1.SetActive(true);
    }


    public void cm1()
    {
        POP();
        rm1.SetActive(false);
    }



    public void m2()
    {
        POP();
        rm2.SetActive(true);
    }


    public void cm2()
    {
        POP();
        rm2.SetActive(false);
    }


    public void m3()
    {
        POP();
        rm3.SetActive(true);
    }


    public void cm3()
    {
        POP();
        rm3.SetActive(false);
    }


    public void m4()
    {
        POP();
        rm4.SetActive(true);
    }


    public void cm4()
    {
        POP();
        rm4.SetActive(false);
    }



    public void m5()
    {
        POP();
        rm5.SetActive(true);
    }


    public void cm5()
    {
        POP();
        rm5.SetActive(false);
    }





    public class U
    
    
    {
       public int v;
              

        public U()
        {
        }

        public U(int v)
        {
            this.v = v;
           
        }
    }







}
