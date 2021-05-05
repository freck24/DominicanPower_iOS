using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaDeCarga : MonoBehaviour {
    
    public static PantallaDeCarga Instancia { get; private set; }

    public Image imageDeCarga;
    public Image imageDeCarga2;
    [Range(0.01f, 0.1f)]
    public float velocidadAparecer = 0.5f;
    [Range(0.01f, 0.01f)]
    public float velocidadOcultar = 1f;

    void Awake()
    {
        DefinirSingleton();
    }

    private void DefinirSingleton()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
            imageDeCarga.gameObject.SetActive(false);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CargarEscena(string nombreEscena)
    {
        StartCoroutine(MostrarPantallaDeCarga(nombreEscena));
    }
    

    private IEnumerator MostrarPantallaDeCarga(string nombreEscena)
    {
        imageDeCarga.gameObject.SetActive(true);
        Color c = imageDeCarga.color;
        Color d = imageDeCarga2.color;
        c.a = 0.0f;
        d.a = 0.0f;

        //Mientras no esté totalmente visible va aumentando su visibilidad
        while(c.a < 1)
        {
            imageDeCarga.color = c;
            imageDeCarga2.color = d;
            c.a += velocidadAparecer;
            d.a += velocidadAparecer/10;
            yield return null;
        }

        //Carga la escena
        SceneManager.LoadScene(nombreEscena);

        //Espera a que haya cargado la nueva escena
        while (!nombreEscena.Equals(SceneManager.GetActiveScene().name))
        {
            yield return null;
        }

        //Mientras la imagen de carga siga visible va desvaneciéndola
        while (c.a > 0)
        {
            imageDeCarga.color = c;
            imageDeCarga2.color = d;
            c.a -= velocidadOcultar;
            d.a -= velocidadOcultar*10;

            yield return null;
        }
       
        
        imageDeCarga.gameObject.SetActive(false);
    }
}
