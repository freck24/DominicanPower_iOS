using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using Lovatto.SceneLoader;

    public class PreLoaderLevel : MonoBehaviour
    {
        public static PreLoaderLevel preload;
    public bool ActualLoading;
        public bl_ButtonSceneLoad miClickLoad;
        public string scena;
        public GameObject letra;

        public bool nomostrable;
        public bool isnivelactualsiguiente = false;
        
        public int AUTOMATICO = 0;

        public string[] datos = new string[15];
        public int i = 0;
        public Text datitos;

    private void Awake()
    {
        preload = this;
        datoscuriosos();

    }

    public void CargaLvl(string Lvl)
        {

        if (ActualLoading) return;
        ActualLoading = true;
        if (Lvl.Length > 2) scena = Lvl;


        if(scena == "inicio") scena = "inicio 1";
            datoscuriosos();

            // obtenemos de la escena anterior el index de la siguiente a cargar
            int nex_level = PlayerPrefs.GetInt("next_level", 0);


            if (isnivelactualsiguiente == false) 
            {
                miClickLoad.sceneName = scena;
                miClickLoad.LoadScene();

            }
            else
            {
                miClickLoad.sceneName = SceneManager.GetActiveScene().name;
            miClickLoad.sceneName = scena;

            miClickLoad.LoadScene();
            }



            if (nomostrable)
            {
               // letra.SetActive(false);
             //   return;
            }

        }

     
        public void datoscuriosos()
        {

        print("llamado dato curioso");
            i = PlayerPrefs.GetInt("datoscuriosos", 0);

          //  if (nomostrable == false)
          //  {
                if (i < datos.Length - 1) PlayerPrefs.SetInt("datoscuriosos", i + 1);
                else PlayerPrefs.SetInt("datoscuriosos", 0);
                datitos.text = datos[i];
           // }

        }

      

    }

