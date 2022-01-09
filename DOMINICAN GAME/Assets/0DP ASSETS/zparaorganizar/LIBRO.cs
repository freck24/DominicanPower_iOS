using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LIBRO : MonoBehaviour
{

    public GameObject BotonCompra;
    public GameObject Informacion;


    public Image Img;
    public Text NombreTx;
    public Text DescripcionTx;
    public Text PrecioTx;
    public static LIBRO Libro;
    public AudioSource sou;

    public ConjuroSlot OpenedSlot;

    public void AbrirInfo(ConjuroSlot slot)
    {
        OpenedSlot = slot;
        Informacion.SetActive(true);

        Img.sprite = slot.img.sprite;
        NombreTx.text = slot.NombreConjuro;
        DescripcionTx.text = slot.Descripcion;
        PrecioTx.text = "RD$" + slot.PrecioConjuro;

        BotonCompra.SetActive(!slot.Comprado);
    }

    public void SendCompra()
    {
        OpenedSlot.ComprarConjuro();
    }


    // Start is called before the first frame update
    void Start()
    {
        Libro = this;
    }

   

    public void menuss()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");
    }
   
}
