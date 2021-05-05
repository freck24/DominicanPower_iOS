using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestordeniveles : MonoBehaviour
{
    #region variables
    public Image[] b1 =  new Image[7];
    public Color color;
    public Color color0;
  
    public GameObject FINALNIVEL;
    private AudioSource a;
        public AudioClip pop;
    public GameObject nivel1;
    public GameObject nivel2;
    public GameObject nivel3;
    public GameObject nivel4;
    public GameObject nivel5;
    public GameObject nivel6;
    public GameObject nivel7;
    public GameObject nivel8;
    public GameObject nivel9;
    public GameObject nivel10;
    public GameObject nivel11;
    public GameObject nivel12;
    public GameObject nivel13;
    public GameObject nivel14;
    public GameObject nivel15;
    public GameObject nivel16;
    public GameObject nivel17;
    public GameObject nivel18;
    public GameObject nivel19;
    public GameObject nivel20;
    public GameObject nivel21;
    public GameObject nivel22;
    public GameObject nivel23;
    public GameObject nivel24;
    public GameObject nivel25;
    public GameObject nivel26;
    public GameObject nivel27;
    public GameObject nivel28;
    public GameObject nivel29;
    public GameObject nivel30;
    public GameObject nivel31;
    public GameObject nivel32;
    public GameObject nivel33;
    public GameObject nivel34;
    public GameObject nivel35;
    public GameObject nivel36;
    public GameObject nivel37;
    public GameObject nivel38;
    public GameObject nivel39;
    public GameObject nivel40;
    public GameObject nivel41;
    public GameObject nivel42;
    public GameObject nivel43;
    public GameObject nivel44;
    public GameObject nivel45;
    public GameObject nivel46;
    public GameObject nivel47;
    public GameObject nivel48;
    public GameObject nivel49;
    public GameObject nivel51;
    public GameObject nivel52;
    public GameObject nivel53;
    public GameObject nivel54;
    public GameObject nivel55;
    public GameObject nivel62;
    public GameObject nivel56;
    public GameObject nivel57;
    public GameObject nivel58;
    public GameObject nivel59;
    public GameObject nivel60;
    public GameObject nivel61;
    // si agregas nuevo agregar a cerrar

    #endregion

    public void cerrar()
    {
        a.clip = pop;
        a.Play();
        nivel1.SetActive(false);
        nivel2.SetActive(false);
        nivel3.SetActive(false);
        nivel4.SetActive(false);
        nivel5.SetActive(false);
        nivel6.SetActive(false);
        nivel7.SetActive(false);
        nivel8.SetActive(false);
        nivel9.SetActive(false);
        nivel10.SetActive(false);
        nivel11.SetActive(false);
        nivel12.SetActive(false);
        nivel13.SetActive(false);
        nivel14.SetActive(false);
        nivel15.SetActive(false);
        nivel16.SetActive(false);
        nivel17.SetActive(false);
        nivel18.SetActive(false);
        nivel19.SetActive(false);
        nivel20.SetActive(false);
        nivel21.SetActive(false);
        nivel22.SetActive(false);
        nivel23.SetActive(false);
        nivel24.SetActive(false);
        nivel25.SetActive(false);
        nivel26.SetActive(false);
        nivel27.SetActive(false);
        nivel28.SetActive(false);
        nivel29.SetActive(false);
        nivel30.SetActive(false);
        nivel31.SetActive(false);
        nivel32.SetActive(false);
        nivel33.SetActive(false);
        nivel34.SetActive(false);
        nivel35.SetActive(false);
        nivel36.SetActive(false);
        nivel37.SetActive(false);
        nivel38.SetActive(false);
        nivel39.SetActive(false);
        nivel40.SetActive(false);
        nivel41.SetActive(false);
        nivel42.SetActive(false);
        nivel43.SetActive(false);
        nivel44.SetActive(false);
        nivel45.SetActive(false);
        nivel46.SetActive(false);
        nivel47.SetActive(false);
        nivel48.SetActive(false);
        nivel49.SetActive(false);
       
        nivel51.SetActive(false);
        nivel52.SetActive(false);
        nivel53.SetActive(false);
        nivel54.SetActive(false);
        nivel55.SetActive(false);
        nivel56.SetActive(false);
        nivel57.SetActive(false);
        nivel58.SetActive(false);
        nivel59.SetActive(false);
        nivel60.SetActive(false);
        nivel61.SetActive(false);
        nivel62.SetActive(false);
           
        
    }
    public void ABRIRFIN()
    {
        i = 0;
        while (i < 7)
        {

            b1[i].color = color0;
            i += 1;
        }

        b1[6].color = color;

        
        FINALNIVEL.SetActive(true);
        cerrar();
    }
    public void CERRARFIN()
    {
        FINALNIVEL.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent < AudioSource>();
        quedatedondees();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float nivel;
    public int i = 0;
    public IEnumerator atrasarunpoquito()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        nivel = PlayerPrefs.GetFloat("nivel", 0);
        if (nivel > 62)
        {
            ABRIRFIN();



        }
        else
        if (nivel > 54)
        {

            M6();
        }
        else

            if (nivel > 40)
        {

            M5();
        }
        else if (nivel > 30)
        {

            M4();
        }
        else if (nivel > 23)
        {

            m3();
        }
        else if (nivel > 15)
        {


            m2();
        }
        else
        {

            m1();
        }
    }
    public void quedatedondees()
    {
        StartCoroutine(atrasarunpoquito());
      
    }



    public void m1()
    {
        i = 0;
        while (i < 7)
        {

            b1[i].color = color0;
            i += 1;
        }

        b1[0].color = color;

        cerrar();
        nivel1.SetActive(true);
        nivel2.SetActive(true);
        nivel3.SetActive(true);
        nivel4.SetActive(true);
        nivel5.SetActive(true);
        nivel6.SetActive(true);
        nivel7.SetActive(true);
        nivel8.SetActive(true);
        nivel9.SetActive(true);
        nivel10.SetActive(true);
        nivel11.SetActive(true);
        nivel12.SetActive(true);
        nivel13.SetActive(true);
        nivel14.SetActive(true);
    }

    public void m2()
    {
        i = 0;
        while (i < 7)
        {

            b1[i].color = color0;
            i += 1;
        }

        b1[1].color = color;

        cerrar();
        nivel15.SetActive(true);
        nivel16.SetActive(true);
        nivel17.SetActive(true);
        nivel18.SetActive(true);
        nivel19.SetActive(true);
        nivel20.SetActive(true);
        nivel21.SetActive(true);
        nivel22.SetActive(true);
    }



    public void m3()
    {
        i = 0;
        while (i < 7)
        {

            b1[i].color = color0;
            i += 1;
        }

        b1[2].color = color;

        cerrar();
        nivel23.SetActive(true);
        nivel24.SetActive(true);
        nivel25.SetActive(true);
        nivel26.SetActive(true);
        nivel27.SetActive(true);
        nivel28.SetActive(true);
        nivel29.SetActive(true);
        
    }

    public void M4()
    {
        i = 0;
        while (i < 7)
        {

            b1[i].color = color0;
            i += 1;
        }

        b1[3].color = color;

        cerrar();
        nivel30.SetActive(true);
        nivel31.SetActive(true);
        nivel32.SetActive(true);
        nivel33.SetActive(true);
        nivel34.SetActive(true);
        nivel35.SetActive(true);
        nivel36.SetActive(true);
        nivel37.SetActive(true);
       nivel38.SetActive(true);
        nivel39.SetActive(true);
       // nivel40.SetActive(true);
    } 
    public void M5()
    {
        i = 0;
        while (i < 7)
        {

            b1[i].color = color0;
            i += 1;
        }

        b1[4].color = color;

        cerrar();
     
       nivel40.SetActive(true);
       nivel41.SetActive(true);
       nivel42.SetActive(true);
       nivel43.SetActive(true);
       nivel44.SetActive(true);
       nivel45.SetActive(true);
       nivel46.SetActive(true);
       nivel47.SetActive(true);
       nivel48.SetActive(true);
       nivel49.SetActive(true);
       nivel51.SetActive(true);
       nivel52.SetActive(true);
       nivel53.SetActive(true);
       nivel54.SetActive(true);
    }

    public void M6()
    {
        i = 0;
        while (i < 7)
        {

            b1[i].color = color0;
            i += 1;
        }

        b1[5].color = color;

        cerrar();
        nivel55.SetActive(true);
        nivel56.SetActive(true);
        nivel57.SetActive(true);
        nivel58.SetActive(true);
        nivel59.SetActive(true);
        nivel60.SetActive(true);
        nivel61.SetActive(true);
        nivel62.SetActive(true);
    }
    }
