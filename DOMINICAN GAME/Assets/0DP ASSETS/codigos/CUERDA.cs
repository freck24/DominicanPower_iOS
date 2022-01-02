using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CUERDA : MonoBehaviour
{
    public bool salto= false;
    public float salt = 5;
    public float tiempo = 1;
    public GameObject mensaje;
    public bool PIERDE = false;
    public GameObject boton;
    public Transform rayita;
    Vector3 a;
    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;
        PIERDE = false;
        StartCoroutine(PREGUN());
        mensaje.SetActive(false);
        salt = 5;
        StartCoroutine(PREGUN());

        a = rayita.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rayita.transform.position = new Vector3(rayita.transform.position.x, salt * 42.8f+a.y, rayita.transform.position.z);
    }

    public  IEnumerator PREGUN()
    {

        while (PIERDE == false)
        {

            yield return new WaitForSecondsRealtime(.1f+tiempo);
            if (salt>0 && salt<10)
            {
                tiempo/=1.1f;
              //  boton.SetActive(true);
                yield return new WaitForSecondsRealtime(.5f/t+tiempo);
                salto = false;
               
                salt -= 1;
                
            }
       
            else
            {
               
                mensaje.SetActive(true);
                PIERDE = true;
                Time.timeScale = 0;
                tiempo = 5f;

            }

   
        }
    }
    public float t = 1;
    public float contaador = 0;
    public Text text;

    public void SALTAR()
    { 
        salto = true;
        salt += 1;
        contaador += 1;
        text.text = "" + contaador.ToString("f0");
        //   boton.SetActive(false);


        if (contaador > 100)
        {
            t = 5;
        }
    }

    public void REIN()
    {
        SceneManager.LoadScene("cuerda");
    }

    public void menuREIN()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }

}
