using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cmr : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject boton4;

//   public way w;
    public controlartrucano cont;

        public bool c = false;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (c == false && cont.s == false)
        {
            boton1.transform.localScale = new Vector3(1, 1, 1);
            boton2.transform.localScale = new Vector3(-1, 1, 1);
            boton3.transform.localScale = new Vector3(-1, 1, 1);
            boton4.transform.localScale = new Vector3(-.8f, 1, 1);
        }
        else
        {
            boton1.transform.localScale = new Vector3(-1, 1, 1);
            boton2.transform.localScale = new Vector3(1, 1, 1);
            boton3.transform.localScale = new Vector3(1, 1, 1);
            boton4.transform.localScale = new Vector3(.9f, .9f, 1);
        }
    }

    public GameObject men;
    public void menu()
    {
        men.SetActive(true);
    }

    public void camcambiar()
    {
        c = !c;
        cam1.SetActive(c);
        cam2.SetActive(!c);
        

    }

    public void cambiafecha()
    {

    }
}
