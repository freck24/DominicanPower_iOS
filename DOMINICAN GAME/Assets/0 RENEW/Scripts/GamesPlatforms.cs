using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesPlatforms : MonoBehaviour
{
    public List<GamesEntry> Juegos;


    public bool IsAppleVersion;
    public bool Active;

    public GameObject NoJuegos;

    private void Start()
    {
        if(Active) IsAppleVersion = PlatformSelect.ps.IsAppleVersion;

        int Count = 0;
        for (int i = 0; i < Juegos.Count; i++)
        {
            if (Juegos[i].Android && !IsAppleVersion || Juegos[i].Apple && IsAppleVersion)
            {
                Count++;
                Juegos[i].Entrada.SetActive(true);
            }
        }

         NoJuegos.SetActive(Count == 0);
    }
}

[System.Serializable]
public class GamesEntry
{
    public GameObject Entrada;
    public bool Android;
    public bool Apple;
}
