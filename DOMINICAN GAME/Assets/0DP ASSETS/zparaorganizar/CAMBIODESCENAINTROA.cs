using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class CAMBIODESCENAINTROA : MonoBehaviour
{
    Animator anim;
    private AudioSource a;

    public Escenas cargarEscena;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        a = GetComponent<AudioSource>();

        StartCoroutine(cambio());
        StartCoroutine(musica());
    }

    public void cargares()
    {
        SceneManager.LoadScene("intro");
    }


    public IEnumerator cambio()
    {
        yield return new WaitForSecondsRealtime(16);
        cargares();
    }
    public IEnumerator musica()
    {
        yield return new WaitForSecondsRealtime(11.5f);


        anim.SetBool("apaga", true);

        yield return new WaitForSecondsRealtime(1f);
        a.Stop();

    }


}

public enum Escenasy
{
    nivel1,
    inicio,
    colmado,
    intro
}