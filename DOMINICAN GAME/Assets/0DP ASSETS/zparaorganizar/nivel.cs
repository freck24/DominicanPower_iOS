using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nivel : MonoBehaviour
{
    public float numeroni;
    public GameObject cargando;
    public GameObject NOHA;
    public Image boton;
    public Color completo;
    public AudioClip enter;
    public AudioClip fail;
    private AudioSource a;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
        if (PlayerPrefs.GetFloat("nivel") > numeroni)
        {
            boton.color = completo;
        }
    }
    public void fnumero()
    {
        if ( PlayerPrefs.GetFloat("nivel")>numeroni)
        {
            PlayerPrefs.SetFloat("jn", numeroni);
            
            cargando.SetActive(true);
            NOHA.SetActive(false);
       //     SceneManager.LoadScene("nivel1");
            a.clip = enter;
            a.Play();
        }
        else
        {
            PlayerPrefs.SetFloat("jn", numeroni);
            a.clip = fail;
            a.Play();
            NOHA.SetActive(false);
            NOHA.SetActive(true);
            cargando.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
