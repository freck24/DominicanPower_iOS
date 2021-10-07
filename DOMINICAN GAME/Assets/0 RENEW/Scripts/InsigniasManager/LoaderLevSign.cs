using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderLevSign : MonoBehaviour
{
    public Transform ContentLevel;
    public List<GameObject> Niveles;
    public string NombreInsignia;
    public int ActualLvl;
    public InsigniaInfo InfoSign;



    public void CompletarNivel()
    {
    PlayerPrefs.SetInt(NombreInsignia + "_Ganada", 1);
    return;
    }

    public void MostrarInsigniaGanada()
    {
        for (int i = 0; i < InfoSign.Insignias.Count; i++)
            if(InfoSign.Insignias[i].id_unica == PlayerPrefs.GetString("Insignia_Progress", ""))
        InfoSign.ShowDesc(InfoSign.Insignias[i]);
    }





    void Start()
    {
       NombreInsignia = PlayerPrefs.GetString("Insignia_Progress", "");
        string LoadLevel = NombreInsignia + "_LvlInsignia";
        // loadlevel InsigniaPrueba_1
        print("Nivel Insignia A Buscar: " + LoadLevel);


        for (int i = 0; i < Niveles.Count; i++)
        {
        if(Niveles[i].gameObject.name == LoadLevel)
        Instantiate(Niveles[i], ContentLevel);
        }

        MostrarInsigniaGanada();
    }

}
