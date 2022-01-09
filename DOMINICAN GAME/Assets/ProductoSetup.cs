using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
[ExecuteInEditMode]
#endif

public class ProductoSetup : MonoBehaviour
{
    public bool Setup;
    public bool GiveOne;
    public string PrefsCantidad;

    [Header("Variables")]
    public int Precio;
    public float Cantidad;
    public bool SolaCompra;

    public Sprite Icono;
    public AudioClip CompraCorrecta;
    public AudioClip CompraFallida;


    [Header("Componentes")]
    public Text PrecioTx;
    public Text CantidadTx;
    public Image IconoRend;
    public GameObject Obj1;
    public GameObject Obj2;

    void SetupMe()
    {
        Setup = false;
        IconoRend.sprite = Icono;
        PrecioTx.text = "PRECIO: $" + Precio + "";
    }

    void Give()
    {
        GiveOne = false;
        PlayerPrefs.SetFloat(PrefsCantidad, PlayerPrefs.GetFloat(PrefsCantidad) +1);
    }

    private void Start()
    {
       if(SolaCompra)
        {
            Obj1.SetActive(Cantidad < 1);
            Obj2.SetActive(Cantidad > 0);
        }

    }

    void Update()
    {
       if (Setup) SetupMe();

        if (Application.isPlaying)
        { 
        if (GiveOne) Give();

        Cantidad = PlayerPrefs.GetFloat(PrefsCantidad, 0f);
        CantidadTx.text = Cantidad.ToString("f0");

        if (SolaCompra)
        {
            Obj1.SetActive(Cantidad < 1);
            Obj2.SetActive(Cantidad > 0);
        }
        }



    }

    void FalloCompra()
    {
        colmado._colmado.tunotiene();
        colmado._colmado.j.PlayOneShot(CompraFallida);
    }

    public void VenderObjeto()
    {
        if (!PlayerPrefs.HasKey(PrefsCantidad)) { PlayerPrefs.SetFloat(PrefsCantidad, 0f); return; }
        if (Cantidad < 1f) { FalloCompra(); return; }

        colmado._colmado.j.PlayOneShot(CompraCorrecta);
        PlayerPrefs.SetFloat("dinero", colmado._colmado.dinero + Precio * Cantidad);
        PlayerPrefs.SetFloat(PrefsCantidad, 0f);

        if(PrefsCantidad == "platanos")
        {
        PlayerPrefs.SetFloat("platanov", PlayerPrefs.GetFloat("platanov", 0) + Cantidad);
        }

    }

  
}
