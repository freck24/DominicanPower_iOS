using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarasigue : MonoBehaviour
{
    public Transform player;
    public float BaseY;
    public Vector3 offsetCamera;

    public float diastanciamax=2;
    public float velocidad=5;
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
            ESCUCHADOR.enabled = false;
    }

    public void start()
    {
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
    }
   

    void Update()
    {
    sube = player.transform.position.y > diastanciamax;
    }


    public void FixedUpdate()
    {
        Vector3 posView = new Vector3 (0,0,0);
        posView.x = player.position.x + offsetCamera.x;
        if(sube) posView.y = player.position.y + offsetCamera.y;
        if(!sube) posView.y = BaseY + offsetCamera.y;
        posView.z = player.position.z + offsetCamera.z;

        transform.position = Vector3.Lerp(transform.position, posView, velocidad);
    }
}

