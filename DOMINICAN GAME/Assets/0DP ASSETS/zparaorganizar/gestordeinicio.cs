using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gestordeinicio : MonoBehaviour
{
    // Start is called before the first frame update

    public string nomb;

    public GameObject po;
    public int delete=1;
    void Start()
    {
        PlayerPrefs.SetInt("unavezanu", 0);

        delete = PlayerPrefs.GetInt("DELETE", 0);

        if (delete == 0)//ESTO BORRRARA LOS DATOS DE TODOS
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("DELETE", 1);
        }
      
        nomb = PlayerPrefs.GetString("nombre", "tonypendejo");
        StartCoroutine(elige());
    }




    public void tato()
    {
        StopCoroutine(elige());
        StartCoroutine(ti());

    }

    public IEnumerator ti()
    {
        if (i > 1)
        {
            po.SetActive(true);
        }
        yield return new WaitForSecondsRealtime(0.5f);

        if (nomb == "tonypendejo")
        {
            PreLoaderLevel.preload.CargaLvl("GRAFICOS");
        }
        else
        {
            PreLoaderLevel.preload.CargaLvl("inicio");
        }
    }


   public int i = 10;
    public Text t;
    public IEnumerator elige()
    {
        
        while(i>0)
        {
            t.text = i.ToString("f0");
            yield return new WaitForSecondsRealtime(1f);
            i--;
        }
        if (nomb == "tonypendejo")
        {
            PreLoaderLevel.preload.CargaLvl("GRAFICOS");
        }
        else
        {
            PreLoaderLevel.preload.CargaLvl("inicio");
        }

    }
}
