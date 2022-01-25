using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarPiso : MonoBehaviour
{
    public bool EliminarPiso;
    public bool Colorear;
    public Color colors;
    // Start is called before the first frame update
    void Start()
    {
       if(EliminarPiso)  FindObjectOfType<FondoManager>().gameObject.SetActive(false);
       if(Colorear)  FindObjectOfType<FondoManager>().SetColors(colors);
    }
 
}
