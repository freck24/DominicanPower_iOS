using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class GeneradorPoliControl : MonoBehaviour
{

    public float TiempoRespawn;

    public List<GeneradorData> Regla;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Regla.Count; i++) CambiarVehiculo(Regla[i].ID_List, Regla[i].Carro);
        Generador.gen.tiempo = TiempoRespawn;
    }

    public void CambiarVehiculo(int Id_Cambiar, GameObject NuevoObj) => Generador.gen.VehiculosGen[Id_Cambiar] = NuevoObj;
}


[System.Serializable]
public class GeneradorData
{
    public int ID_List;
    public GameObject Carro;
}
