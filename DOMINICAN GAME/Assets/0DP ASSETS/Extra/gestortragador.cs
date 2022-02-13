using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestortragador : MonoBehaviour
{
    public tragaperras1 t1;
    public tragaperras1 t2;
    public tragaperras1 t3;

    public Animator ANIM;
   

    public int x, y, z;
    // Start is called before the first frame update

    public GameObject canvas;
    public GameObject canvas2;

    public void apagacanvas()
    {
        ANIM.SetBool("JUGAR", true);

        canvas.SetActive(false);
        canvas2.SetActive(true);
      
    }
    public void prendecanvas()
    {
        ANIM.SetBool("JUGAR", false);
        ANIM.SetBool("PARAR", false);
        canvas.SetActive(true);
        canvas2.SetActive(false);
    }
    
    void Start()
    {
        
    }
    public void facilidad()
    {
        if (x == y)
        {
            t3.i = t1.i;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    int aa = 0;
    public void ganar()
    {
        
        s[aa].SetActive(false);
        s[aa].SetActive(true);
    }

    public GameObject PARAR;
    public GameObject JUGAR;

    public void P()
    {
        {
            PARAR.SetActive(true);
            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) - 5);
        }
    }

    public GameObject audi;

    public GameObject[] s;
    public void JUG()
    {
       // JUGAR.SetActive(true);
        audi.SetActive(true);
    } 
    public void JUGC()
    {
        
            JUGAR.SetActive(false);
            PARAR.SetActive(true);
        ANIM.SetBool("PARAR", true);
        if (PlayerPrefs.GetInt("anuncios", 1) == 1)
        {
            print("entro");
            scriptEjemploVR.instance.AdsByCall_Intersticial();
        }
        
    }
    public void llamar()
    {
       
            StartCoroutine(prem());
            PARAR.SetActive(false);
        
      
       
    }
    public Text win;



    public void clasificacion()
    {  
        
        switch (x)
        {
            case 11:
                x = 1;
                break;
            case 12:
                x = 2;
                break;
            case 13:
                x = 3;
                break;
            case 14:
                x = 7; //20k
                break;
            case 15:
                x = 6;
                break;
            case 16:
                x = 5;
                break;
            case 17:
                x = 4;
                break;
            case 18:
                x = 9;
                break;
            case 19:
                x = 8;
                break;
            case 10:
                x = 4;
                break;
        } 
        
        
        switch (y)
        {
            case 11:
                y = 1;
                break;
            case 12:
                y = 2;
                break;
            case 13:
                y = 3;
                break;
            case 14:
                y = 7; //20k
                break;
            case 15:
                y = 6;
                break;
            case 16:
                y = 5;
                break;
            case 17:
                y = 4;
                break;
            case 18:
                y = 9;
                break;
            case 19:
                y = 8;
                break;
            case 10:
                y = 4;
                break;
        } 
        
        
        switch (z)
        {
            case 11:
                z = 1;
                break;
            case 12:
                z = 2;
                break;
            case 13:
                z = 3;
                break;
            case 14:
                z = 7; //20k
                break;
            case 15:
                z = 6;
                break;
            case 16:
                z = 5;
                break;
            case 17:
                z = 4;
                break;
            case 18:
                z = 9;
                break;
            case 19:
                z = 8;
                break;
            case 10:
                z = 4;
                break;
        } 
        
        
       
    }
     IEnumerator  prem()
    {
        yield return new WaitForSecondsRealtime(1);
       
        yield return new WaitForSecondsRealtime(1.2f);
        x = t1.i;
        y = t2.i;

        clasificacion();
        facilidad();
       
        audi.SetActive(false);
       
       
        
        yield return new WaitForSecondsRealtime(1);
        z = t3.i;



        clasificacion();


        premios();

        
        JUGAR.SetActive(true);
    }

    public GameObject GANASTE;


    IEnumerator cerrarmensaje()
    {
        yield return new WaitForSecondsRealtime(3f);
        GANASTE.SetActive(false);

    }
    public void premios()
    {
       

        if(x==y && x == z)
        {
            
            GANASTE.SetActive(true);
            StartCoroutine(cerrarmensaje());
            switch (x)
            {
                case 0:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0)+750);
                    win.text = "Ganaste $RD 750";

                    break;

                   
                case 1:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 500);
                    win.text = "Ganaste $RD500";
                    break;
                    

                case 2:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 100);
                    win.text = "Ganaste $RD100";
                    break;
                case 3:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 50);
                    win.text = "Ganaste $RD50";
                    break;
                case 4:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 5000);
                    win.text = "Ganaste $RD5000";
                    break;
                case 5:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 7500);
                    win.text = "Ganaste $RD7500";
                    break;
                case 6:
                    aa = 1;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 10000);
                    win.text = "Ganaste $RD10000";
                    break;
                case 7:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 750);
                    win.text = "Ganaste $RD750";
                    break;
                case 8:
                    aa = 3;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 1000);
                    win.text = "Ganaste $RD1000";
                    break;
                case 9:
                    aa = 0;
                    ganar();
                    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 2000);
                    win.text = "Ganaste $RD2000";
                    break;


            }
        }

        
    }

    
}
