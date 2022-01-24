using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using EliezerYT.UIAdjust;

public class planeta : MonoBehaviour
{

    [Header("Contador Minijuego")]
    public bool ActivedCounter;
    public float TiempoContando = 2.3f;
    public Text Tiempo;
    public GameObject mensajeminijuego;

    public AudioClip provin;
    public AudioSource a;
    public GameObject SD;
    public GameObject sj;
    public GameObject BA;
    public GameObject samana;
    public GameObject bani;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject SPAILLAT;
    public GameObject SALCEDO;
    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject f4;
    public GameObject f5;
    public GameObject f6;
    public GameObject f7;
    public GameObject f8;
    public GameObject f9;
    public GameObject f10;
    public GameObject f11;
    public GameObject f12;
    public GameObject f13;
    public GameObject f14;
    public GameObject f15;
    public GameObject f16;
    public GameObject f17;
    public GameObject f18;
    public GameObject f19;
    public GameObject f20;
    public GameObject f21;
    public GameObject fc1;
    public GameObject fc2;
    public GameObject fc3;
    public GameObject fc4;
    public GameObject fc5;
    public GameObject fc6;
    public GameObject fc7;
    public GameObject fc8;
    public GameObject fc9;
    public GameObject fc10;
    public GameObject fc11;
    public GameObject fc12;
    public GameObject fc13;
    public GameObject fc14;
    public GameObject fc15;
    public GameObject fc16;
    public GameObject fc17;
    public GameObject fc18;
    public GameObject fc19;
    public GameObject fc20;
    public GameObject fc21;
    public GameObject fc22;
  
    public Image CSD;
    public Image Csj;
    public Image CBA;
    public Image csamana;
    public Image cbani;
    public GameObject CANVAS;
    public GameObject SIGUIENTE;
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public Color color6;
    int N = 100;
    public float niv = 0;
    int i = 0;


    public GameObject[] c= new GameObject[10];

    // Start is called before the first frame update

    public GameObject fondo;

    public void inicio()
    {
        transform.parent.gameObject.SetActive(true);
        gameObject.SetActive(true);
        fondo.SetActive(false);
        a = GetComponent<AudioSource>();
        StartCoroutine(plan());
        Time.timeScale = 1;
        color2 = CSD.color;
        color3 = Csj.color;
        color4 = CBA.color;
        color5 = csamana.color;
        color6 = cbani.color;

        if (PlayerPrefs.GetFloat("nivel", 0) > 33)
        {
            P1.SetActive(true);
            c[6].SetActive(true);
        }

        if (PlayerPrefs.GetFloat("nivel", 0) > 35)
        {
            P2.SetActive(true);
            c[7].SetActive(true);
        }

        if (PlayerPrefs.GetFloat("nivel", 0) > 44)
        {
            P3.SetActive(true);
            c[5].SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 54)
         
        {
            SALCEDO.SetActive(true);
            c[9].SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 59)

        {
            SPAILLAT.SetActive(true);
            c[8].SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 62 + i)

        {
            f1.SetActive(true);
            fc1.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 63 + i)

        {
            f2.SetActive(true);
            fc2.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 64 + i)

        {
            f3.SetActive(true);
            fc3.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 65 + i)

        {
            f4.SetActive(true);
            fc4.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 66 + i)

        {
            f5.SetActive(true);
            fc5.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 67 + i)

        {
            f6.SetActive(true);
            fc6.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 68 + i)

        {
            f7.SetActive(true);
            fc7.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 69 + i)

        {
            f8.SetActive(true);
            fc8.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 70 + i)

        {
            f9.SetActive(true);
            fc9.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 71 + i)

        {
            f10.SetActive(true);
            fc10.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 72 + i)

        {
            f11.SetActive(true);
            fc11.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 73 + i)

        {
            f12.SetActive(true);
            fc12.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 74 + i)

        {
            f13.SetActive(true);
            fc13.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 75 + i)

        {
            f14.SetActive(true);
            fc14.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 76 + i)

        {
            f15.SetActive(true);
            fc15.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 77 + i)

        {
            f16.SetActive(true);
            fc16.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 78 + i)

        {
            f17.SetActive(true);
            fc17.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 79 + i)

        {
            f18.SetActive(true);
            fc18.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 80 + i)

        {
            f19.SetActive(true);
            fc19.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 81 + i)

        {
            f20.SetActive(true);
            fc20.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 82 + i)

        {
            f21.SetActive(true);
            fc21.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("nivel", 0) > 85 + i)

        {

            fc22.SetActive(true);
        }
    }

    private void Start()
    {
        UIA_Manager uia = FindObjectOfType<UIA_Manager>();
        uia.GroupOriginal.SetActive(false);
    }

    void Update()
    {
        if(ActivedCounter)
        {
            TiempoContando -= Time.deltaTime;

            if (TiempoContando >= 0.1f) Tiempo.text = "CARGANDO MINIJUEGO EN: " + System.Convert.ToInt32(TiempoContando) + " SEGUNDOS";
            else Tiempo.text = "CARGANDO MINIJUEGO";
        }
    }


    public IEnumerator plan()
    {
        niv = PlayerPrefs.GetFloat("nivel", 1);

        if (niv > 1)
        {
            SD.SetActive(true);
           // c[0].SetActive(true);
        }

        if (niv > 5)
        {
            sj.SetActive(true);
            c[1].SetActive(true);
        }

        if (niv > 6)
        {
            BA.SetActive(true);
            c[2].SetActive(true);
        }


        if (niv > 8)
        {
            samana.SetActive(true);
            c[3].SetActive(true);
        }

        if (niv > 10)
        {
            bani.SetActive(true);
            c[4].SetActive(true);
        }





        yield return new WaitForSeconds(1f);


        if (niv == 1)
        {
            a.clip = provin;
            a.Play();
            yield return new WaitForSeconds(0.1f);
            SD.SetActive(true);
        }


        if (niv == 5)
        {
            c[1].SetActive(true);
            a.clip = provin;
            a.Play();
            yield return new WaitForSeconds(0.1f);
            sj.SetActive(true);
        }
        if (niv == 6)
        {
            c[2].SetActive(true);
            a.clip = provin;
            a.Play();
            yield return new WaitForSeconds(0.1f);
            BA.SetActive(true);
        }
        if (niv == 8)
        {
            c[3].SetActive(true);
            a.clip = provin;
            a.Play();
            yield return new WaitForSeconds(0.1f);
            samana.SetActive(true);
        }
        if (niv == 11)
        {
            c[4].SetActive(true);
            a.clip = provin;
            a.Play();
            yield return new WaitForSeconds(0.1f);
            bani.SetActive(true);
        }
            yield return new WaitForSeconds(.8f);
            CANVAS.SetActive(true);
            SIGUIENTE.SetActive(true);


            if (niv < 5 || niv == 7 || niv==9 || niv==10 || niv == 12|| niv == 17 ) // SANTO DOMINGO
            {
                if (niv == 2)
                {
                    mensajeminijuego.SetActive(true);
                    ActivedCounter = true;
                    yield return new WaitForSeconds(4f);
                    SceneManager.LoadScene("yun");

                }
                else if (niv == 7)
                {
                    mensajeminijuego.SetActive(true);
                    ActivedCounter = true;
                    yield return new WaitForSeconds(4f);
                    SceneManager.LoadScene("pa");
                }
                else if (niv == 70)
                {
                    mensajeminijuego.SetActive(true);
                    ActivedCounter = true;
                    yield return new WaitForSeconds(4f);
                    SceneManager.LoadScene("trucano");
                }  else if (niv == 17)
                {
                    mensajeminijuego.SetActive(true);
                    ActivedCounter = true;
                    yield return new WaitForSeconds(4f);
                    SceneManager.LoadScene("avion");
                }
            else if(niv == 35)
                {
                    mensajeminijuego.SetActive(true);
                    ActivedCounter = true;
                    yield return new WaitForSeconds(4f);
                    SceneManager.LoadScene("rayita");
                }
                else
                {

                    while (N > 0)
                    {
                        yield return new WaitForSeconds(0.2f);
                        CSD.color = color1;
                        yield return new WaitForSeconds(0.2f);
                        CSD.color = color2;
                        N -= 1;
                    }
                }
            }


            if (niv == 5)  // SAN JUAN
            {


                while (N > 0)
                {
                    yield return new WaitForSeconds(0.2f);
                    Csj.color = color1;
                    yield return new WaitForSeconds(0.2f);
                    Csj.color = color3;
                    N -= 1;
                }
            }
            if (niv == 6)  // BAARAHONA
            {


                while (N > 0)
                {
                    yield return new WaitForSeconds(0.2f);
                    CBA.color = color1;
                    yield return new WaitForSeconds(0.2f);
                    CBA.color = color5;
                    N -= 1;
                }
            }

            if (niv == 8)  // samana
            {


                while (N > 0)
                {
                    yield return new WaitForSeconds(0.2f);
                    csamana.color = color1;
                    yield return new WaitForSeconds(0.2f);
                    csamana.color = color5;
                    N -= 1;
                }
            } 
        
        if (niv == 11 || niv==12)  // samana
            {


                while (N > 0)
                {
                    yield return new WaitForSeconds(0.2f);
                    cbani.color = color1;
                    yield return new WaitForSeconds(0.2f);
                    cbani.color = color6;
                    N -= 1;
                }
            }

        }



    }




    

