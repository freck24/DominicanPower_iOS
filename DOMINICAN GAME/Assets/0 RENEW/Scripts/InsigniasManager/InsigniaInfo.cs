using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InsigniaInfo : MonoBehaviour
{
    public GameObject InsigniaPrefab;
    public List<InsigniaInfoData> Insignias;
    public Transform MostrarInsignias;

    public void ShowDesc(InsigniaInfoData dx)
    {

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
    public Sprite Insignia_Icon;

    [Multiline(5)] public string Descripcion;
    public bool Conseguida;
}
