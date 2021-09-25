using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestordeniveles : MonoBehaviour
{
    public Image[] b1 =  new Image[7];
    public Color color;
    public Color color0;
  
    public GameObject FINALNIVEL;
    private AudioSource a;
    public AudioClip pop;

    public Transform ContenedorNiveles;

    void ActivarGrupo(int Inicio, int Final, bool Valor)
    {
        int children = ContenedorNiveles.childCount;
        for (int i = Inicio; i < Final; ++i) ContenedorNiveles.GetChild(i).gameObject.SetActive(Valor);
    }

    void ActivarColorPagina(int Active)
    {
    for (int i = 0; i < b1.Length - 1; ++i)
    b1[i].color = (i == Active) ? color0 : color;
    }

    public void cerrar()
    {
        a.PlayOneShot(pop);
    FINALNIVEL.SetActive(false);
    ActivarGrupo(0, ContenedorNiveles.childCount, false);

    }
    public void ABRIRFIN()
    {
    cerrar();
    FINALNIVEL.SetActive(true);
    ActivarColorPagina(6);
    }
    public void CERRARFIN() => FINALNIVEL.SetActive(false);
   

    void Start()
    {
        a = GetComponent < AudioSource>();
        quedatedondees();
    }


    public float nivel;
    public int i = 0;
    public IEnumerator atrasarunpoquito()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        nivel = PlayerPrefs.GetFloat("nivel", 0);

        if (nivel > 62) ABRIRFIN();
        else if (nivel > 54)    M6();
        if (nivel > 40)         M5();
        else if (nivel > 30)    M4();
        else if (nivel > 23)    m3();
        else if (nivel > 15)    m2();
        else                    m1();
    }
    public void quedatedondees() => StartCoroutine(atrasarunpoquito());

    public void m1()
    {
    cerrar();
    ActivarColorPagina(0);
    ActivarGrupo(0, 15, true);
    }
    public void m2()
    {
    cerrar();
    ActivarColorPagina(1);
    ActivarGrupo(15, 23, true);
    }
    public void m3()
    {
    cerrar();
    ActivarColorPagina(2);
    ActivarGrupo(23, 30, true);
    }
    public void M4()
    {
    cerrar();
    ActivarColorPagina(3);
    ActivarGrupo(30, 40, true);
    } 
    public void M5()
    {
    cerrar();
    ActivarColorPagina(4);
    ActivarGrupo(40, 55, true);
    }
    public void M6()
    {
    cerrar();
    ActivarColorPagina(5);
    ActivarGrupo(55, 63, true);
    }

    }
