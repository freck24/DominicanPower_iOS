using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunner : MonoBehaviour
{
    public static PlayerRunner runner;
    public Transform Camera;
    public float offsetZ;

    [Header("Audio")]
    public AudioSource Player;
    public AudioClip Perder;            //
    public AudioClip CalibrarFx;            //
    public AudioClip RecogerDinero;         //
    public AudioClip PerderCalibrarChoque;  //
    public AudioClip PerderCalibrarTiempo;
    public AudioClip Empezar;

    [Header("RunDistance")]
    public float MetersRunning;
    public float MetersRecord;
    public float VelMulti;

    public List<float> RunningBoostTimes;

    public static PlayerRunner pr;
    [Header("Componentes")]
    public Animator anim;
    public Rigidbody rb;



    [Header("Deslizamiento")]
    [Range(1, 3)] public int MotoCarril = 2;
    public List<Transform> OffsetsPos;
    public float velMove = 0.5f;
    public bool EnEspera;

    [Header("Movimiento")]
    public float Velocidad;
    public bool PuedeSaltar;

    [Header("Boost")]
    public bool Boosting;
    public int Calibrar;
    public bool Clic1;
    public bool Clic2;
    public float TiempoEntreClic;


    void CalibrarCheck()
    {
        if (Boosting || Calibrar < 1) return;

        if (Input.GetMouseButtonDown(0))
        {
            if (!Clic1)
            {
                Clic1 = true;
                StartCoroutine(QuitarBool("c1", TiempoEntreClic));
                return;
            }

            if (Clic1 && !Boosting)
            {
                Clic2 = true;
                Clic1 = false;
                StartCoroutine(QuitarBool("c2", 2f));
                Boosting = true;

                Calibrar--;
                PlayerPrefs.SetInt("runnerboost", Calibrar);
                PlayerRunner.pr.Player.PlayOneShot(PlayerRunner.pr.CalibrarFx);

                RunnerMapGenerator.rmg.CalibrinTime = RunningBoostTimes[PlayerPrefs.GetInt("rinnerboostlvl", 0)];
                RunnerMapGenerator.rmg.Calibrin_rararara = RunnerMapGenerator.rmg.CalibrinTime;

                anim.SetBool("Calibrando", true);
                print("CALIBRIN!!!");
            }

        }

    }

    IEnumerator QuitarBool(string value, float enTiempo)
    {
        yield return new WaitForSeconds(enTiempo);

        if (value == "c1") Clic1 = false;
        if (value == "c2") Clic2 = false;
    }


    void MovimientoAvanzar()
    {
        rb.velocity = new Vector3(0f, rb.velocity.y, Velocidad * VelMulti * Time.fixedDeltaTime);
        Camera.position = new Vector3(Camera.position.x, Camera.position.y, transform.position.z + offsetZ);

        MetersRunning += Time.deltaTime * VelMulti;
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "arriba")
        {
            Destroy(other.GetComponent<Collider>());
            RunnerMapGenerator.rmg.GenerarSiguienteTile();
        }

        if (other.tag == "abajo")
        {
            Destroy(other.GetComponent<Collider>());
            if(!Boosting)
            PlayerRunner.pr.Player.PlayOneShot(PlayerRunner.pr.Perder);
            else
            PlayerRunner.pr.Player.PlayOneShot(PlayerRunner.pr.PerderCalibrarChoque);
            TakeChoque();
        }

        if (other.tag == "walk")
        {
            other.GetComponent<Coin3D>().ObtenerMonedas();
            Destroy(other.GetComponent<Collider>());
        }

    }

    private void Start()
    {
    pr = this;
    Calibrar = PlayerPrefs.GetInt("runnerboost", 0);
    MetersRecord = PlayerPrefs.GetFloat("MetersRecord", 0);

    }

    void Update()
    {
        MovimientoAvanzar();
        CalibrarCheck();

        Vector3 posis = transform.position;
        posis.x = OffsetsPos[MotoCarril].position.x;
        transform.position = Vector3.Lerp(transform.position, posis, velMove * Time.deltaTime);

    }

    public void MovePlayer(int Move)
    {
        int AnteriorMove = MotoCarril;

        MotoCarril = Mathf.Clamp(MotoCarril + Move, 1, 3);

        if (AnteriorMove != MotoCarril)
        {
            if (Move > 0) anim.SetTrigger("Inc_Derecha");
            if (Move < 0) anim.SetTrigger("Inc_Izquierda");
        }

        anim.SetInteger("Carril", MotoCarril);

      //  BoxCollider bx = GetComponent<BoxCollider>();
        //   bx.center = new Vector3(OffsetsPos[MotoCarril], bx.center.y, bx.center.z);

        
    }



    public void TakeChoque()
    {
        if(Boosting)
        {
        Boosting = false;
        anim.SetBool("Calibrando", false);
            return;
        }

        anim.SetTrigger("Choque_" + Random.Range(1,4));


    }



}
