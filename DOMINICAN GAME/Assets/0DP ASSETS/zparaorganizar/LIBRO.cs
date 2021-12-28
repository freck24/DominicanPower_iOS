using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LIBRO : MonoBehaviour
{
    public Transform[] HOJA;
    public GameObject[] HOJAGAME;
    public GameObject[] compra;
    public int X =0;
    public float MAX =0;
    public float f =0;
    public float velocidad;
  public  bool ALANTE = true;
    public Text DINERO;

    // Start is called before the first frame update
    void Start()
    {
        X = 0;

        llama();
       



    }

    public GameObject tatola;

    public void tatocerar()
    {
        tatola.SetActive(false);
    }

   public void llama()
    {
        for (int i = 0; i < compra.Length; i++)
            if (PlayerPrefs.GetInt("conjuro" + i, 0) == 1)
            {
                compra[i].SetActive(true);
            }
    }


 
    
    public void menuss()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");
    }


    public int excepcion;


    public void cerrartodo()
    {
        for(int h = 0; h < HOJAGAME.Length; h++)
        {  if(h!=excepcion)
            HOJAGAME[h].SetActive(false);
        }  
    
    }




    // Update is called once per frame
    void Update()
    {
        DINERO.text = "RD$ "+PlayerPrefs.GetFloat("dinero", 0);
    }
    public GameObject anima;
    public GameObject anima2;
    public void PROX()
    {

        if (excepcion < HOJAGAME.Length-1)
        {
            excepcion += 1;
            cerrartodo();
            HOJAGAME[excepcion].SetActive(true);
            anima.SetActive(false);
            anima.SetActive(true);
        }
    
    }  public void ANTE()
    {
        if (excepcion > 1)
        {
           
            anima2.SetActive(false);
            anima2.SetActive(true);
            StartCoroutine(retardo());
        }
    }

    IEnumerator retardo()
    {
        yield return new WaitForSecondsRealtime(0.25f);
        excepcion -= 1;
        cerrartodo();
        HOJAGAME[excepcion].SetActive(true);
    }
   




   
}
