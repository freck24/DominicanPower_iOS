using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace EMGame
{
    public class PreLoaderLevel : MonoBehaviour
    {

        public GameObject BotonIr;
        public GameObject GrupoEntrando;

        public bool CargaAutomatica;

        public bool nomostrable = false;
        public bool nocargada = true;
        public RectTransform progressBar;
        public string scena;
        public Text textComponent;
        public bool immediateActivateScene = false;

        protected AsyncOperation async;
        protected float progressPercent;
        public Toggle A;

        public bool isnivelactualsiguiente = false;
        public bool ISNIVELES = false;
        
        public int AUTOMATICO = 0;
        public GameObject letra;

        public Vector2 progressBarSizeDelta;
        public float parentWidth;
        public string[] datos = new string[15];
        public int i = 0;
        public Text datitos;

        public GameObject continuar;
        public Animator Anim;

        public void BO() // void Boton InicioAutomatico
        {
            immediateActivateScene = !immediateActivateScene;

            if (immediateActivateScene) PlayerPrefs.SetInt("AUTOMATICO", 1);
            else PlayerPrefs.SetInt("AUTOMATICO", 0);
        }


    public void CheckLoad()
    {
    if(async.isDone)
    {
    GrupoEntrando.SetActive(true);
    BotonIr.SetActive(false);
    }

    }


        public void cargar()
        {
            if (progressPercent >= 90)
                async.allowSceneActivation = true;

            GrupoEntrando.SetActive(true);
            BotonIr.SetActive(false);
        }



        public void cargar2()
        {

            async.allowSceneActivation = true;

            GrupoEntrando.SetActive(true);
            BotonIr.SetActive(false);
        }

        public virtual void Start()
        {

            print("Loading 1 (Enter Sart)");

            if(CargaAutomatica)
                AUTOMATICO = 1;
             else  
            AUTOMATICO = PlayerPrefs.GetInt("AUTOMATICO", 0);
           
            
            print("Loading 2 (Start Entered)");

            datoscuriosos();
            print("Loading 3 (Dato Curioso)");

            // obtenemos de la escena anterior el index de la siguiente a cargar
            int nex_level = PlayerPrefs.GetInt("next_level", 0);

            /* si no tiene valor hubo un error y devuelve a menu principal
            if (!PlayerPrefs.HasKey("next_level"))
            {
                nex_level = 0;
            }
            else
            {
                // se resetea el dato persistente para evitar errores
                PlayerPrefs.DeleteKey("next_level");
                PlayerPrefs.Save();
            }
            // se inicia la carca asincrona del nivel */
            print("Loading 4 (Pass Dato Curioso)");
            print("Loading 5 (Sett Async)");


            if (isnivelactualsiguiente == false) 
            { 
            async = SceneManager.LoadSceneAsync(scena);
            }
            else
            {
              //  async = SceneManager.LoadSceneAsync(scena);
             async = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
                    //async = SceneManager.LoadSceneAsync((int)PlayerPrefs.GetFloat("nivel",1));
            }

            // se establece si se activara la escena inmediatamente
            async.allowSceneActivation = AUTOMATICO == 1;

            print("Loading 6 (Set AutoLoad)");

            if (nomostrable)
            {
                async.allowSceneActivation = true;

                letra.SetActive(false);
                StartCoroutine(verificando());
                return;

            }

            if (!nomostrable)
            {
                if (AUTOMATICO == 0)
                {
                    A.isOn = false;
                    PlayerPrefs.SetInt("AUTOMATICO", 0);
                }
                else
                {
                    A.isOn = true;
                    PlayerPrefs.SetInt("AUTOMATICO", 1);
                }
            }



            print("Loading 1 (ShowData)");


            StartCoroutine(verificando());

            print("Loading (Started Verify)");

        }


        public void AcualizarData()
        {

            if (async != null) progressPercent = async.progress * 100;
            if (nocargada) textComponent.text =  ((int)progressPercent).ToString() + " %";
            if (nocargada)
            {
                // aqui cada implementacion puede ser diferente
               float parentWidth = (progressBar.parent as RectTransform).rect.width;
                progressBarSizeDelta = progressBar.sizeDelta;
                // ValueFromPercent calcula el valor de un porcentaje en base a su maximo valor x = (maxFactor / 100) * porentaje
                progressBarSizeDelta.x = (parentWidth + progressPercent*parentWidth/45);
                progressBar.sizeDelta = progressBarSizeDelta;
            }
        }

        
        public void datoscuriosos()
        {
            i = PlayerPrefs.GetInt("datoscuriosos", 0);

            if (nomostrable == false)
            {
                if (i < datos.Length - 1) PlayerPrefs.SetInt("datoscuriosos", i + 1);
                else PlayerPrefs.SetInt("datoscuriosos", 0);

                datitos.text = datos[i];
            }

        }

       
       IEnumerator verificando()
        {
         while (progressPercent<90)
            {
                AcualizarData();
                yield return new WaitForSecondsRealtime(0.5f); 
            }

         if(AUTOMATICO == 1)
                cargar2();

            nocargada = false;
            progressBarSizeDelta.x = 2230;
            progressBar.sizeDelta = progressBarSizeDelta;
            textComponent.text =  "100%";
            Anim.SetBool("Cargado", true);
            Time.timeScale = 1;

        }

    }


    
   






}