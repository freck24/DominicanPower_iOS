using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin3D : MonoBehaviour
{
    public enum Dinero
    {
        _5,
        _10,
        _20,
        _25,
        _50,
        _100,
        _200,
        _500,
        _1000,
        _2000,
        _Celular
    }

    public Dinero DineroValor;

    public int Valor;
    public float TimeDestroy;
    public Animator anim;

    [Header("Objetos Dinero")]
    public List<GameObject> Dineros;

    IEnumerator Corrutinin()
    {
        yield return new WaitForSeconds(TimeDestroy);
        FindObjectOfType<TileDestroyer>().addTile(gameObject);

    }

    private void Start()
    {
        Instantiate(Dineros[(int)DineroValor], transform);
        StartCoroutine(Corrutinin());

        if (DineroValor == Dinero._Celular) return;

        string DineroValorX = DineroValor.ToString().Replace("_", "");

        Valor = System.Convert.ToInt32(DineroValorX.ToString());
        StartCoroutine(Corrutinin());

    }

    public void ObtenerMonedas()
    {
        if (DineroValor == Dinero._Celular)
        {
        PlayerPrefs.SetFloat("celular", PlayerPrefs.GetFloat("celular", 0) + 1);
        PlayerRunner.pr.Player.PlayOneShot(PlayerRunner.pr.RecogerTelefono);
        Destroy(gameObject);
        return;
        }

        PlayerRunner.pr.Player.PlayOneShot(PlayerRunner.pr.RecogerDinero);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + Valor);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "yun")
        {
            DestroyImmediate(gameObject);
            print("coin mala destruyendo");
        }
    }
}
