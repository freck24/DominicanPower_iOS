using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BRUJERIA : MonoBehaviour
{
    int i = 0;
    public int numeros = 0;
    public GameObject[] BOTONES = new GameObject[9];
    public Transform[] slide = new Transform[9];
    public Vector3[] vectores = new Vector3[9];
    public Vector3 target;
    public float escala = 0;

    public float distancia = 0;
    public float distanciaref = 0.15f;
    public float proporsion = 0;
    public Transform player;
    public int[] VAMO = new int[9];
    
    
    // Start is called before the first frame update
    void Start()
    {
       for(int c = 0; c < 7; c++)
        {
            if (PlayerPrefs.GetInt("conjuro" + c) == 1)
            {
                conjuro[c].sprite = imagenes[c].sprite;
                conjuro[c].color = new Color(1, 1, 1, 1);
                VAMO[c] = PlayerPrefs.GetInt("conjuro" + c);
            }
            else
            {
                VAMO[c] = 666;
            }
        }
    }
    public void abrir()
    {
        for (int a = 0; a < 9; a++)
        {
            BOTONES[a].SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("abajo");
        }
        if (Input.GetMouseButtonDown(1))
        {
            print("ariiba");
        }

       /* if (a)
        {
            activar();
        }*/
    }
    public void activar()
    {
        distancia = Vector3.Distance(vectores[i], target);
        proporsion = distancia / distanciaref;
        slide[i].localScale = new Vector3(slide[i].localScale.x * proporsion, slide[i].localScale.y, slide[i].localScale.z);
    }

    public AudioSource a;
    public controler cont;
    public GameObject plataforma;
    public GameObject r14;
    public GameObject r12;
    public GameObject r15;
    public GameObject r25;
    public GameObject r24;
    public GameObject r26;
    public GameObject r23;
    public GameObject r36;
    public GameObject r35;
    public GameObject r45;
    public GameObject r47;
    public GameObject r48;
    public GameObject r56;
    public GameObject r57;
    public GameObject r58;
    public GameObject r59;
    public GameObject r68;
    public GameObject r78;
    public GameObject r69;
    public GameObject r87;
    public GameObject r89;
    public float contador = 0 ;
    public float  codigos = 0;

    public GameObject canvas;
    public void cerrar()
    {
     r14.SetActive(false);
     r12.SetActive(false);
     r15.SetActive(false);
     r25.SetActive(false);
     r24.SetActive(false);
     r26.SetActive(false);
     r23.SetActive(false);
     r36.SetActive(false);
     r35.SetActive(false);
     r45.SetActive(false);
     r47.SetActive(false);
     r48.SetActive(false);
     r56.SetActive(false);
     r57.SetActive(false);
     r58.SetActive(false);
     r59.SetActive(false);
     r68.SetActive(false);
     r78.SetActive(false);
     r69.SetActive(false);
     r87.SetActive(false);
     r89.SetActive(false);


        for(int a = 0; a<9; a++)
        {
            BOTONES[a].SetActive(false);
        }
}

    public GameObject aparecedorplata;
    public GameObject efectotiempo;
    public GameObject efectosuicidio;
    IEnumerator apagaaparecedor()
    {
        yield return new WaitForSecondsRealtime(1f);
        aparecedorplata.SetActive(false);
    }

    public GameObject invocandopollos;
    public GameObject invocandoplatanos;
    public GameObject destructor;
    public GameObject constructor;
    public Animator anim;
    public Image[] conjuro;
    public Image[] imagenes;
    int f1 = 777;
    int f2 = 777;
    int f3=777;
    int f4 = 777;
    int f5 = 777;
    int f6 = 777;
    int f7 = 777;
    public void magia() 
    {
        tiempoespera = 0;

        if (VAMO[0] == 1)
        {
            f1 = 1;
        }

        if (VAMO[1] == 1)
        {
            f2 =2;
        }

        if (VAMO[2] == 1)
        {
            f3 = 3;
        }

        if (VAMO[3] == 1)
        {
            f4 = 4;
        }

        if (VAMO[4] == 1)
        {
            f5 = 5;
        }



        if (VAMO[5] == 1)
        {
            f6 = 6;
        }

        if (VAMO[6] == 1)
        {
            f7 = 7;
        }
      

        if (codigos == 951 || codigos==f1) // aparece plataforma
        {if(codigos == 951)
            {
                PlayerPrefs.SetFloat("local", 1.5f);
            }
            
            a.PlayOneShot(mag);
          //  plataforma.SetActive(false);
          //  plataforma.SetActive(true);
            cont.corrutinatonta();
            aparecedorplata.SetActive(false);
            aparecedorplata.SetActive(true);
            StartCoroutine(apagaaparecedor());
            anim.SetInteger("conjuro", 5);
            tiempoespera = 1;
           
        }
        if (codigos == 963 || codigos == f3) // suicidio
        {
            if (codigos == 963)
            {
                PlayerPrefs.SetFloat("local", 1.5f);
            }
            efectosuicidio.SetActive(false);
            efectosuicidio.SetActive(true);
            cont.suicidio();
            tiempoespera = 1;
        }


        if (codigos == 36951 || codigos == f4) 
        {
            if (codigos == 36951)
            {
                PlayerPrefs.SetFloat("local", 1.5f);
            }
            Instantiate(invocandopollos, new Vector3(player.transform.position.x, player.transform.position.y+13,player.transform.position.z), Quaternion.identity);
            anim.SetInteger("conjuro", 2);
            tiempoespera = 1;
        }
        if (codigos == 1478951 || codigos == f6) 
        {
            if (codigos == 1478951)
            {
                PlayerPrefs.SetFloat("local", 1.5f);
            }
            Instantiate(invocandoplatanos, new Vector3(player.transform.position.x, player.transform.position.y+13,player.transform.position.z), Quaternion.identity);
            anim.SetInteger("conjuro", 2);
            tiempoespera = 1;

        }

        if (codigos ==3698741 || codigos == f5)
        {
            if (codigos == 3698741)
            {
                PlayerPrefs.SetFloat("local", 1.5f);
            }
            Instantiate(destructor, new Vector3(player.transform.position.x, player.transform.position.y+5, player.transform.position.z), Quaternion.identity);
            anim.SetInteger("conjuro", 1);
            tiempoespera = 1.5f;

        }

        if (codigos == 753 || codigos == f7)
        {
            if (codigos == 753)
            {
                PlayerPrefs.SetFloat("local", 1.5f);
            }
            Instantiate(constructor, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
            anim.SetInteger("conjuro", 1);
            tiempoespera = 1.5f;

        }

        Time.timeScale = 1f;
        if (codigos == 789 || codigos == f2) 
        {
            if (codigos == 789)
            {
                PlayerPrefs.SetFloat("local", 1.5f);
            }
            Time.timeScale = 0.4f;
            a.PlayOneShot(mag);
            efectotiempo.SetActive(false);
            efectotiempo.SetActive(true);
            StartCoroutine(tiempoend());
            tiempoespera = 2.5f;

        }
        StartCoroutine(r());
        StartCoroutine(espe());

       
    }

    IEnumerator tiempoend()
    {
        yield return new WaitForSecondsRealtime(4);
        Time.timeScale = 1;
        efectotiempo.SetActive(false);
    }
    public GameObject panelconjuro;
    public float tiempoespera = 0;
    public IEnumerator espe()
    {
        yield return new WaitForSecondsRealtime(tiempoespera);
        panelconjuro.SetActive(false);
    }

    IEnumerator r()
    {
        anim.SetBool("magic", false);
        i = 0;
        contador = 0;
        codigos = 0;
        cerrar();
        cont.brujeriaactiva = false;
        cont.corutinabrujeria();
        yield return new WaitForSecondsRealtime(1);
        
        yield return new WaitForSecondsRealtime(1);
        yield return new WaitForSecondsRealtime(tiempoespera);

        canvas.SetActive(false);
      
    }


    public AudioClip clan;
    public AudioClip mag;
    public void enciende()
    {
        cont.vivi();
        codigos += (i+1) * Mathf.Pow(10, contador);
        contador += 1;
        a.PlayOneShot(clan);

        switch (numeros)
        {
            case 0:
                switch (i)
                {
                    case 1:
                        r12.SetActive(true);
                        break;
                    case 4:
                        r15.SetActive(true);
                        break;
                    case 3:
                        r14.SetActive(true);
                        break;
                }
                break; 
            
            case 1:
                switch (i)
                {
                    case 0:
                        r12.SetActive(true);
                        break;
                    case 4:
                        r25.SetActive(true);
                        break;
                    case 3:
                        r24.SetActive(true);
                        break;
                    case 5:
                        r26.SetActive(true);
                        break;
                    case 2:
                        r23.SetActive(true);
                        break;
                }
                break;  
            case 2:
                switch (i)
                {
                    case 5:
                        r36.SetActive(true);
                        break;
                    case 4:
                        r35.SetActive(true);
                        break;
                   
                 

                    case 1: //ok
                        r23.SetActive(true);
                        break;
                }
                break;
            case 3:
                switch (i)
                {
                    case 0:
                        r14.SetActive(true);
                        break;
                    case 1:
                        r24.SetActive(true);
                        break;
                                  
                    case 4: 
                        r45.SetActive(true);
                        break;
                    case 7: 
                        r48.SetActive(true);
                        break;
                    case 6: 
                        r47.SetActive(true);
                        break;
                }
                break;
            case 4:
                switch (i)
                {
                    case 0:
                        r15.SetActive(true);
                        break;
                    case 1:
                        r14.SetActive(true);
                        break;
                                  
                    case 3: //ok
                        r45.SetActive(true);
                        break;
                    
                    case 2: 
                        r35.SetActive(true);
                        break;
                    case 5: 
                        r56.SetActive(true);
                        break;
                    case 8: 
                        r59.SetActive(true);
                        break;
                    case 7: 
                        r58.SetActive(true);
                        break;
                    case 6: 
                        r57.SetActive(true);
                        break;
                }
                break;
            case 5:
                switch (i)
                {
                    case 2:
                        r36.SetActive(true);
                        break;
                    case 1:
                        r26.SetActive(true);
                        break;
                                  
                    case 4: 
                        r56.SetActive(true);
                        break;
                    
                    case 7: 
                        r68.SetActive(true);
                        break;
                   
                    case 8: 
                        r69.SetActive(true);
                        break;
                 
                }
                break;
            
            case 6:
                switch (i)
                {
                    case 3:
                        r47.SetActive(true);
                        break;
                    case 1:
                        r26.SetActive(true);
                        break;
                                  
                    case 4: 
                        r57.SetActive(true);
                        break;
                    
                    case 7: 
                        r78.SetActive(true);
                        break;                
                
                 
                }
                break;
            case 7:
                switch (i)
                {
                    case 6:
                        r87.SetActive(true);
                        break;
                    case 3:
                        r48.SetActive(true);
                        break;
                                  
                    case 4: 
                        r58.SetActive(true);
                        break;
                    
                    case 5: 
                        r58.SetActive(true);
                        break;                
                 case 8: 
                        r89.SetActive(true);
                        break;                
                
                 
                }
                break;
            case 8:
                switch (i)
                {
                    case 7:
                        r89.SetActive(true);
                        break;
                    case 4:
                        r59.SetActive(true);
                        break;
                                  
                   
                    
                    case 5: 
                        r69.SetActive(true);
                        break;                
                         
                
                 
                }
                break;
        }
    }

    
    public void p1()
    {
       
        
       
        numeros = i;
        i = 0;
        vectores[0] = target;
        enciende();

    } public void p2()
    {
       
        numeros = i;
        i = 1;
        vectores[1] = target;
        enciende();
    } public void p3()
    {
       
        numeros = i;
        i = 2;
        vectores[2] = target;
        enciende();
    } public void p4()
    {
       
        numeros = i;
        i = 3;
        vectores[3] = target;
        enciende();
    } public void p5()
    {
       
        numeros = i;
        i = 4;
        vectores[4] = target;
        enciende();
    } public void p6()
    {
       
        numeros = i;
        i = 5;
        vectores[5] = target;
        enciende();
    } public void p7()
    {
       
        numeros = i;
        i = 6;
        vectores[6] = target;
        enciende();
    } public void p8()
    {
      
        numeros = i;
        i = 7;
        vectores[7] = target;
        enciende();
    } public void p9()
    {

        numeros = i;
        i = 8;
        vectores[8] = target;
        enciende();
    }

}
