using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerTile : MonoBehaviour
{
    public int count_gen;
    public int objGenerar;
    // 2 CONO
    // 3 POLICIA ACOTAO
    // 4 PEATON

    public Transform GenNext_Pos;
    public List<Transform> Gens_Cono;


    public void TilePasado()
    {
        StartCoroutine(Corrutinin());
    }

    IEnumerator Corrutinin()
    {
        yield return new WaitForSeconds(3f);
     FindObjectOfType<TileDestroyer>().addTile(gameObject);

    }

    public void Start()
    {

        GenerarObstaculos();
    }

    public void GenerarObstaculos()
    {
        int objGenerar = Random.Range(0, 6);

        if (objGenerar == 0) Instantiate(RunnerMapGenerator.rmg.Cono, Gens_Cono[2].position, Quaternion.identity).transform.SetParent(Gens_Cono[2]);


        if (objGenerar == 1) GenerarConos(2, RunnerMapGenerator.rmg.Cono); // chequear 3 posiciones Cono
        if (objGenerar == 2) GenerarConos(1, RunnerMapGenerator.rmg.Cono); // chequear 1 posiciones Cono

        if (objGenerar == 3) GenerarConos(3, RunnerMapGenerator.rmg.Hoyo); // chequear 3 posiciones Hoyo
        if (objGenerar == 4) GenerarConos(1, RunnerMapGenerator.rmg.Hoyo); // chequear 1 posiciones Hoyo

        if (objGenerar == 5)
        {
            GenerarConos(2, RunnerMapGenerator.rmg.Cono); // chequear 3 posiciones Cono
            GenerarConos(2, RunnerMapGenerator.rmg.Hoyo); // chequear 1 posiciones Hoyo
        }
    }



    void GenerarConos(int CheckCount, GameObject Obj)
    {
        for (int i = 0; i < CheckCount; i++)
        {
            int generar = Random.Range(0, 2);

            if(generar == 1 && count_gen < 2 && Gens_Cono[i].childCount == 0)
            {
                count_gen++;
                Instantiate(Obj, Gens_Cono[i].position, Quaternion.identity).transform.SetParent(Gens_Cono[i]);
            }
        }
    }
}
