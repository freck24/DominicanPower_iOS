using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InsigniaInfo : MonoBehaviour
{
    public GameObject InsigniaPrefab;
    public List<InsigniaInfoData> Insignias;
    public Transform MostrarInsignias;


    [Header("Muestra De Insignia")]
    public GameObject Show;
    public Text Nombre;
    public Text Descripcion;
    public Image IconRender;



    public void ShowDesc(InsigniaInfoData dx)
    {
        Show.SetActive(true);
        Nombre.text = dx.Nombre;
        Descripcion.text = dx.Descripcion;
        IconRender.sprite = dx.Insignia_Icon;
    }

     void Start()
    {
        for (int i = 0; i < Insignias.Count; i++)
            CreateSlot(Insignias[i]);
    }

    public void CreateSlot(InsigniaInfoData ide)
    {
        Instantiate(InsigniaPrefab, MostrarInsignias).GetComponent<InsigniaSlot>().Check(ide);
    }

}


[System.Serializable]
public class InsigniaInfoData
{

    public string Nombre;
    public string id_unica;
    public Sprite Insignia_Icon;


    [Multiline(5)] public string Descripcion;
    public bool Conseguida;
}
