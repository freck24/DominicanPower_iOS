using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public static CoinGenerator cg;

    public float offsetZ;


    public Coin3D coin;
    public Coin3D.Dinero GenerarDinero;
    public List<Transform> Posiciones;



    [Header("Tiempo Entre Cadena")]
    public float EveryTime;
        
    public int PosicionToGenerate;
    public int CurveToGenerate;
    public int CoinsParaGenerar;
    void Start()
    {
        cg = this;
    }

    public void CheckRound()
    {
    CoinsParaGenerar = Random.Range(4, 12);
    StartCoroutine(GenerateCoins());
    }


    IEnumerator GenerateCoins()
    {
        while(CoinsParaGenerar > 0)
        {
            // POSICION
            PosicionToGenerate = Random.Range(0, 3);
            if (PosicionToGenerate == 0) CurveToGenerate = Random.Range(1, 3);
            else if (PosicionToGenerate == 2) CurveToGenerate = Random.Range(0, 2);
            else CurveToGenerate = Random.Range(0, 3);
            Vector3 posGen = Posiciones[PosicionToGenerate].position;
            posGen.z = offsetZ + PlayerRunner.pr.transform.position.z;


            coin.DineroValor = RandomCoinLevel();
            CoinsParaGenerar--;
            GameObject generated = Instantiate(coin.gameObject, posGen, Quaternion.identity);
            generated.SetActive(true);


            if (CoinsParaGenerar > 4) print("GENERAR UNA MONEDA EN LA POSICION:" + PosicionToGenerate);
            else print("GENERAR UNA MONEDA EN LA POSICION CURVA:" + CurveToGenerate);


            yield return new WaitForSeconds(EveryTime);
        }


        Invoke("CheckRound", Random.Range(2f, 5f));
        yield return null;
    }
    

    public Coin3D.Dinero RandomCoinLevel()
    {
        int MetersLevel = System.Convert.ToInt32(PlayerRunner.pr.MetersRunning);

        List<int> OpcionesDisponibles = new List<int>(0);

        OpcionesDisponibles.Add((int)Coin3D.Dinero._20);

        if (MetersLevel > 25) OpcionesDisponibles.Add((int)Coin3D.Dinero._50);

        if (MetersLevel > 90) OpcionesDisponibles.Add((int)Coin3D.Dinero._100);

        if (MetersLevel > 200) OpcionesDisponibles.Add((int)Coin3D.Dinero._200);

        if (MetersLevel > 350) OpcionesDisponibles.Add((int)Coin3D.Dinero._500);

        if (MetersLevel > 500) OpcionesDisponibles.Add((int)Coin3D.Dinero._1000);

        if (MetersLevel > 800) OpcionesDisponibles.Add((int)Coin3D.Dinero._2000);

        return (Coin3D.Dinero)OpcionesDisponibles[Random.Range(0, OpcionesDisponibles.Count)];

    }


}
