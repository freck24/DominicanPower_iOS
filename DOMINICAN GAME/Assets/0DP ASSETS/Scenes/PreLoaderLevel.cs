using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace EMGame
{
    public class PreLoaderLevel : MonoBehaviour
    {
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

        public void BO() // void Boton InicioAutomatico
        {
            immediateActivateScene = !immediateActivateScene;

            if (immediateActivateScene)
            {
                PlayerPrefs.SetInt("AUTOMATICO", 1);
            }
            else
            {
                PlayerPrefs.SetInt("AUTOMATICO", 0);
            }
        }
         
        public virtual void Start()
        {
            if (nomostrable) letra.SetActive(false);

            StartCoroutine(verificando());

            AUTOMATICO = PlayerPrefs.GetInt("AUTOMATICO", 0);


            if (nomostrable == false)
                { 
                if (AUTOMATICO == 0)
                {
                    A.isOn = false;
                }
                else
                {
                    A.isOn = true;
                } 
            }

            datoscuriosos();

            // obtenemos de la escena anterior el index de la siguiente a cargar
            int nex_level = PlayerPrefs.GetInt("next_level");

            // si no tiene valor hubo un error y devuelve a menu principal
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
            // se inicia la carca asincrona del nivel

            if (isnivelactualsiguiente == false) 
            { 
                async = SceneManager.LoadSceneAsync(scena); 
            } 
            else
            {

                if (ISNIVELES == false)
                {
                    async = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
                    //async = SceneManager.LoadSceneAsync((int)PlayerPrefs.GetFloat("nivel",1));
                }
                else
                {
                    async = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
                    //  async = SceneManager.LoadSceneAsync((int)PlayerPrefs.GetFloat("jn", 1));
                }
            }
            
            // se establece si se activara la escena inmediatamente
            async.allowSceneActivation = immediateActivateScene;
        }
        public void cargar()
        {
            if(progressPercent >= 90)
            async.allowSceneActivation = true;
        }

        public void cargar2()
        {
            
            async.allowSceneActivation = true;
          
        }

        public virtual void Update()
        {
            if (async != null) progressPercent = async.progress * 100;

            if (textComponent && nocargada) textComponent.text =  ((int)progressPercent).ToString() + " %";

            if (progressBar && nocargada)
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
                if (i < datos.Length - 1)
                {
                    PlayerPrefs.SetInt("datoscuriosos", i + 1);
                }
                else
                {
                    PlayerPrefs.SetInt("datoscuriosos", 0);
                }
                datitos.text = datos[i];

            }


        }


        public GameObject continuar;
       IEnumerator verificando()
        {
         while (progressPercent<90)
            {
                yield return new WaitForSecondsRealtime(0.1f);
            }
            nocargada = false;
            progressBarSizeDelta.x = 2230;
            progressBar.sizeDelta = progressBarSizeDelta;
            textComponent.text =  "100%";
            continuar.SetActive(true);

        }

    }


    
   






}