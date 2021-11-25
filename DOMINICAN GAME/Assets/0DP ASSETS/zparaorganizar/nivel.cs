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

    public List<Transform> NivelesSlot;

    public void TestAd()
    {
    scriptEjemploVR.instance.Mostrar_Video();
    }
    public void TestAd2()
    {
    scriptEjemploVR.instance.Mostrar_Intersticial();
    }

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < NivelesSlot.Count-1; i++)
        {
            int LevelNew = System.Convert.ToInt32(GetDataOfString.GetData(NivelesSlot[i].name, "Lvl:", "]"));
            if (PlayerPrefs.GetFloat("nivel") > LevelNew) NivelesSlot[i].GetComponent<Image>().color = completo;

        }

    }
    public void CheckPlay(GameObject obj)
    {
        int LevelNewer = System.Convert.ToInt32(GetDataOfString.GetData(obj.name, "Lvl:", "]"));

        if ( PlayerPrefs.GetFloat("nivel")> LevelNewer)
        {
            // ESTE NIVEL SE VA ABRIR
            PlayerPrefs.SetFloat("jn", LevelNewer);

            if (cargando != null) cargando.SetActive(true);
            if (NOHA != null) NOHA.SetActive(false);
            AudioFx.PlayOneShot(enter);

            int LevelNew = System.Convert.ToInt32(GetDataOfString.GetData(obj.name, "Lvl:", "]"));
            GetComponent<inicietion>().Boton_IniciarSaltado(LevelNew+1);
        }
        else
        {
            // ESTE NIVEL ESTA BLOQUEADO BEBE
            PlayerPrefs.SetFloat("jn", LevelNewer);
            AudioFx.PlayOneShot(fail);
            if(NOHA != null) NOHA.SetActive(false);
            if (NOHA != null) NOHA.SetActive(true);
            if (cargando != null) cargando.SetActive(false);
        }
    }
   
}
