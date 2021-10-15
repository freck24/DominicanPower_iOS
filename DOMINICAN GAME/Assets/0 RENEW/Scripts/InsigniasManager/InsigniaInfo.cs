using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InsigniaInfo : MonoBehaviour
{
    public GameObject InsigniaPrefab;
    public List<InsigniaInfoData> Insignias;
    public Transform MostrarInsignias;

    public GameObject ConseguirInsignia;

    [Header("Muestra De Insignia")]
    public GameObject Show;
    public Text Nombre;
    public Text Descripcion;
    public Image IconRender;

    InsigniaInfoData ddd;
    public void LoadLevelInsignia()
    {
        PlayerPrefs.SetString("Insignia_Progress", ddd.id_unica);
        SceneManager.LoadScene("LEVELLOADER INSIGNIA");
    }
    public void ShowDesc(InsigniaInfoData dx)
    {
        ddd = dx;

        Show.SetActive(true);
        Nombre.text = dx.Nombre;
        Descripcion.text = dx.Descripcion;
        IconRender.sprite = dx.Insignia_Icon;

        ConseguirInsignia.SetActive(!dx.Conseguida);

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
