using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nivel : MonoBehaviour
{
  
    public GameObject cargando;
    public GameObject NOHA;
    public Color completo;
    public AudioClip enter;
    public AudioClip fail;
    public AudioSource AudioFx;

    public Transform NivelesContent;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in NivelesContent)
        {
            int LevelNew = System.Convert.ToInt32(GetDataOfString.GetData(child.name, "Lvl:", "]"));
            if (PlayerPrefs.GetFloat("nivel") > LevelNew) child.GetComponent<Image>().color = completo;
        }

    }
    public void CheckPlay(GameObject obj)
    {
        int LevelNewer = System.Convert.ToInt32(GetDataOfString.GetData(obj.name, "Lvl:", "]"));

        if ( PlayerPrefs.GetFloat("nivel")> LevelNewer)
        {
            // ESTE NIVEL SE VA ABRIR
            PlayerPrefs.SetFloat("jn", LevelNewer);
            
            cargando.SetActive(true);
            NOHA.SetActive(false);
            AudioFx.PlayOneShot(enter);

            int LevelNew = System.Convert.ToInt32(GetDataOfString.GetData(obj.name, "Lvl:", "]"));
            GetComponent<inicietion>().Boton_IniciarSaltado(LevelNew);
        }
        else
        {
            // ESTE NIVEL ESTA BLOQUEADO BEBE
            PlayerPrefs.SetFloat("jn", LevelNewer);
            AudioFx.PlayOneShot(fail);
            NOHA.SetActive(false);
            NOHA.SetActive(true);
            cargando.SetActive(false);
        }
    }
   
}
