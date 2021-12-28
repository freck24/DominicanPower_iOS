using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MANGEJODESCENA : MonoBehaviour
{
    public GameObject repe;
    public GameObject repegratis;

    public Text text = null;
   

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetFloat("ptrucano", 0) == 0)
        {
            repe.SetActive(false);
            repegratis.SetActive(true);

        }
        text.text = "Su moña es de: " + PlayerPrefs.GetFloat("dinero", 0f).ToString("f0");
    }


    public void REPETIR()
    {
        if (PlayerPrefs.GetFloat("dinero", 0) > 74 && PlayerPrefs.GetFloat("ptrucano", 0) == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - 25f);
        }


        if (PlayerPrefs.GetFloat("ptrucano", 0) == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }
    
    
    public void REPETIRgratos()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void REPETI2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     


    PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0f) - 25f);
    } public void menu()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

        PlayerPrefs.SetFloat("ptrucano", 1);

    }

    
}
