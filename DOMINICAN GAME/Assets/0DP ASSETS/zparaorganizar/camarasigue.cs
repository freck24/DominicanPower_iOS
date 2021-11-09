using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarasigue : MonoBehaviour
{
    public Transform player;
    Vector3 a;
    Vector3 a1;
    Vector3 a2;
    Vector3 b;
    public Vector3 C;
   public Vector3 P;
    Vector3 avector;
    public bool s;
    public float diastanciamax=2;
    public float velocidad=5;
    public Transform limite;
    public controler cont;


    public bool sube = false;
    public bool state = true;
    public bool desc = false;
    public bool power = false;
    public bool power2 = true;
    public AudioListener ESCUCHADOR;
    // Start is called before the first frame update
    void Start()
    {
       
       
    
    
        ESCUCHADOR = GetComponent<AudioListener>();
        if (PlayerPrefs.GetInt("sonido", 1) == 0)
        {

            ESCUCHADOR.enabled = false;
     

    }
        a = transform.position;
      //  diastanciamax += player.transform.position.y - 2f;
        s = true;

    }

    public void powerfuncion()
    {
        power = true;
        power2 = true;
        StartCoroutine(tiempo());
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSecondsRealtime(0.7f);
        power = false;
        yield return new WaitForSecondsRealtime(0.3f);
        power2 = false;
        transform.position = new Vector3(transform.position.x, transform.position.y, a.z);
    }
    public void start()
    {
       
        a = transform.position;
        //diastanciamax += player.transform.position.y - 2f;
        s = true;
    }
    public float entrada=20;

    // Update is called once per frame
    void Update()
    {
        
            b = new Vector3(player.transform.position.x, diastanciamax, transform.position.z);
           
            avector = new Vector3(player.transform.position.x, a.y, transform.position.z);
            a1 = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            a2 = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        C = new Vector3(player.transform.position.x, transform.position.y, a.z + entrada);
        P = new Vector3(player.transform.position.x, transform.position.y, a.z);

      

        if (cont.f == true)
        {
            s = false;
        }



        if (s)
        {
            if (player.transform.position.y > diastanciamax)
            {

                sube = true;
                desc = true;
                state = false;

            }
            else
            {
                sube = false;

            }





            if (transform.position.y < a.y)
            {
                desc = false;
            }


            if (power)
            { if (transform.position.z >= C.z)
                {
                    power = false;
                }
                transform.position = Vector3.Lerp(transform.position, C, velocidad * Time.deltaTime*2);
            }
            else if (power2)
            {
                if (transform.position.z <= a.z)
                {
                    power2 = false;
                }
                    transform.position = Vector3.Lerp(transform.position, P, velocidad * Time.deltaTime*2);
            }
            else

            if (sube)
            {

                transform.position = Vector3.Lerp(a1, b, velocidad * Time.deltaTime);
            }
            else

           if (desc)
            {
                transform.position = Vector3.Lerp(a1, avector, velocidad * Time.deltaTime);

            }

            else



            {

                transform.position = new Vector3(player.transform.position.x, a.y, transform.position.z);


            }



        }

   
    }
}

