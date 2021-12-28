using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//using WaypointsFree;

public class movimientoaleatorio : MonoBehaviour
{
 
    public void jugs()
    {
        PreLoaderLevel.preload.CargaLvl("LEVEL 1 CLONE");
    }
        public void menu()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }
    public Text G1;
    public Text G2;
    public Text G3;
    public Text G4;
    public Animator anim;
    public Transform linea;
    public bool m1 = false;
    public bool m2 = false;
    public bool m3 = false;
    public bool m4 = false;
    public bool d = false;
    public bool i = true;
    public float d1 = 0;
    public float d2 = 0;
    public float d3 = 0;
    public float d4 = 0;
    public float velocidad = 1;
    public float velocidads = 1;
    public Text distancia1;
    public Text distancia2;
    public Text distancia3;
    public Text distancia4;
    public MeshRenderer r;
 
    public SkinnedMeshRenderer pl;
    public Material p2;
    public Material p3;
    public Material p4;

    public SIGUEVELOCIDAD v;
    public AudioClip moneda;
    private AudioSource a;
 //   public WaypointsGroup WAY;
  //  public Waypoint wp;
  //  public WaypointsTraveler wt;

    public lanzar lanzar;
    // Start is called before the first frame update
    void Start()
    {
       // anim = GetComponent<Animator>();
        r=GetComponent< MeshRenderer>();
        a=GetComponent<AudioSource>();
        RandonVelocity();
        if (j >1)
        {
            StartCoroutine(de2());
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            DETEN(); 
        }
            transform.Translate(velocidad * Time.deltaTime, 0, velocidads * Time.deltaTime);
        
    }

public void RandonVelocity()
    {
        if (velocidad > 0)
        {
            velocidad = Random.Range(1f, 3);
        }
        else
        {
            velocidad = -Random.Range(1f, 3);
        }
        velocidad = -velocidad;
    }
    public void RandonVelocitys()
    {
        if (velocidads > 0)
        {
            velocidads = 2*Random.Range(1f, 3);
        }
        else
        {
            velocidads = -2*Random.Range(1f, 3);
        }
        velocidads = -velocidads;
    }

    public void OnTriggerEnter(Collider other)
    { if(other.tag == "Player")
        {
            r.enabled = false;
        }
        if(other.tag == "d")
        {
            i = true;
            d = false;
            RandonVelocity();

           
        }
        if (other.tag == "i")
        {
            d = true;
            i = false;
            RandonVelocity();
            

        } 
        if(other.tag == "a")
        {

            RandonVelocitys();
        }
        if (other.tag == "b")
        {

            RandonVelocitys();

        }


        

    }

    public void DETEN()
    {
        a.clip = moneda;
        a.Play();
        anim.SetBool("t1", true);
        velocidad = 0;
        velocidads = 0;
        if (transform.position.z - linea.transform.position.z < 0)
        {
            d1 = -transform.position.z + linea.transform.position.z;
        }
        else
        {
            d1 = transform.position.z - linea.transform.position.z;
        }
        distancia1.text = (d1*10).ToString("F2");
        StartCoroutine(JUGADORES());

       // lanzar.start = true;
        m1 = true;
       // wp.position = transform.position;
  
     //   WAY.waypoints.Add(wp);
      //  WAY.GetWaypointChildren(true).Add(wp);

       // wt.Move(true);

    } public void DETEN2()
    {
        pl.material = p2;
        v.u2();
        velocidad = 0;
        velocidads = 0;
      
        if (transform.position.z - linea.transform.position.z < 0)
        {
            d2 = -transform.position.z + linea.transform.position.z;
        }
        else
        {
            d2 = transform.position.z - linea.transform.position.z;
        }
        distancia2.text = (d2*10).ToString("F2");
        StartCoroutine(JUGADORES());
        m2 = true;
        velocidad = 0;
    } public void DETEN3()
    {
        pl.material = p3;
        v.u3();
        velocidad = 0;
        velocidads = 0;
        if (transform.position.z - linea.transform.position.z < 0)
        {
            d3 = -transform.position.z + linea.transform.position.z;
        }
        else
        {
            d3 = transform.position.z - linea.transform.position.z;
        }
        distancia3.text = (d3*10).ToString("F2");
        StartCoroutine(JUGADORES());
        m3 = true;
    } public void DETEN4()
    {
        pl.material = p4;
        v.u4();
        velocidad = 0;
        velocidads = 0;
        if (transform.position.z - linea.transform.position.z < 0)
        {
            d4 = -transform.position.z + linea.transform.position.z;
        }
        else
        {
            d4 = transform.position.z - linea.transform.position.z;
        }
        distancia4.text = (d4*10).ToString("F2");
        StartCoroutine(JUGADORES());
        m4 = true;
    }
    public int j = 2;
    public GameObject j2;
    public float DISTANCIAPRUEBA = 3;
    public float DISTANCIADIFICULTAD = 3;


    public GESTOR gestor;
    public void calcula()
    {
        if (transform.position.z - linea.transform.position.z < 0)
        {
            DISTANCIAPRUEBA = -transform.position.z + linea.transform.position.z;
        }
        else
        {
            DISTANCIAPRUEBA = transform.position.z - linea.transform.position.z;
        }

    }


    IEnumerator de2()
    {


        

        yield return new WaitForSecondsRealtime(2);
        calcula();
        if (j == 2)
        {
            while (DISTANCIAPRUEBA > DISTANCIADIFICULTAD)
            {
                yield return new WaitForSecondsRealtime(0.1f);
                calcula();
               
            }
            DETEN2();
            a.clip = moneda;
            a.Play();

        } if (j == 3)
        {
            while (DISTANCIAPRUEBA > DISTANCIADIFICULTAD)
            {
                yield return new WaitForSecondsRealtime(0.1f);
                calcula();
              
            }
            DETEN3();
            a.clip = moneda;
            a.Play();

        } if (j == 4)
        {
            while (DISTANCIAPRUEBA > DISTANCIADIFICULTAD)
            {
                yield return new WaitForSecondsRealtime(0.1f);
                calcula();
                
            }
            a.clip = moneda;
            a.Play();
            DETEN4();
            yield return new WaitForSecondsRealtime(1f);
            win();

           
            cam2.SetActive(true);
            cam1.SetActive(false);


        }

       




    }
    public GameObject mensajewin;
    public GameObject mensajenowin;
    public GameObject cam1;
    public GameObject cam2;
    public void win()
    {
        if(float.Parse(distancia1.text)< float.Parse(distancia2.text)&&float.Parse(distancia1.text)< float.Parse(distancia3.text)&&float.Parse(distancia1.text)< float.Parse(distancia4.text))
        {
            mensajewin.SetActive(true);
            gestor.ganar();
            G1.text = "HA GANADO EL AMARILLO";
        }
        else
        {
            if (float.Parse(distancia2.text) < float.Parse(distancia1.text) && float.Parse(distancia2.text) < float.Parse(distancia3.text) && float.Parse(distancia2.text) < float.Parse(distancia4.text))
            { G2.text = "HA GANADO EL AZUL"; 
            }

            if (float.Parse(distancia3.text) < float.Parse(distancia1.text) && float.Parse(distancia3.text) < float.Parse(distancia2.text) && float.Parse(distancia3.text) < float.Parse(distancia4.text))
            {
                G3.text = "HA GANADO EL ROSA";
            }
            if (float.Parse(distancia4.text) < float.Parse(distancia1.text) && float.Parse(distancia4.text) < float.Parse(distancia2.text) && float.Parse(distancia4.text) < float.Parse(distancia3.text))
            {
                G4.text = "HA GANADO EL ROJO";
            }
            mensajenowin.SetActive(true);
        }


    }

    IEnumerator  JUGADORES()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        anim.SetBool("t1", false);
        yield return new WaitForSecondsRealtime(1);
        j2.gameObject.SetActive(true);
        velocidad = 0;
        velocidads = 0;



    }
    }

