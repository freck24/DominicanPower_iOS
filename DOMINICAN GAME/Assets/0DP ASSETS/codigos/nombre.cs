using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nombre : MonoBehaviour
{

    public Font fuente;
    public string nombr = "";
    public GameObject stupido;
    public Text n;
    public GameObject inicio;
    // Start is called before the first frame update
    void Start()
    {
        p1 = PlayerPrefs.GetFloat("p1", 0);
        if (p1 == 1)
        {
            inicio.SetActive(true);
        }
       


    }

    // Update is called once per frame
    void Update()
    {
        nombr = n.text;
        if (nombr != "")
        {
            no.SetActive(false);
            aceptar.SetActive(true);
        }
        else
        {
            no.SetActive(true);
            aceptar.SetActive(false);
        }    



    }

    private void OnGUI()
    {


      

    }
    public GameObject intro;

    public GameObject pantalla;
    public float p1;
    public GameObject no;
    public bool una = true;
    public GameObject aceptar;
    public void seguir()
    {
        if (p1==0)
        {


            if (nombr == "")
            {
                stupido.SetActive(true);
            }
            else
            {
                pantalla.SetActive(true);
                PlayerPrefs.SetString("nombre", nombr);
                intro.SetActive(true);
            }
        }
        
    }
    
}


