using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class preguntasdispo : MonoBehaviour
{
    public GameObject MENSAJE;
    public Text t;
    public Text t1;
    public bool una = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("preguntasd", 200)>0)
        { t.text = "Preguntas disponibles:" + PlayerPrefs.GetInt("preguntasd", 200).ToString(); }
        t1.text = "PUNTAJE ACUMULADO:" + PlayerPrefs.GetFloat("niveld", 0).ToString();
        if(PlayerPrefs.GetInt("preguntasd", 200) == 0 && una)
        {
            MENSAJE.SetActive(true);
            t.text = "Preguntas disponibles: 0";
            una = false;
        }

    }

public void CM()
    {
        MENSAJE.SetActive(false);
    }

}
