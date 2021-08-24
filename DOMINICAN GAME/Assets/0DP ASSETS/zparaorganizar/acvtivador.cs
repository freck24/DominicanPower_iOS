using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acvtivador : MonoBehaviour
{

   // public GameObject r11;
    public GameObject r12;
    public GameObject r13;
    public GameObject r14;
    public GameObject r15;
    public GameObject r16;
    public GameObject r17;
    public GameObject r18;
    public GameObject r19;
    public GameObject r20;
    public GameObject ganar1;
   //ublic GameObject cosita;

    public way w;





    public controlartrucano cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (w.contador == 10)
        {
            acth.SetActive(true);
        
        }
    }
    public bool uno = true;

    public GameObject acth;
    public GameObject fin;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player" && uno)
        {
  
            r12.SetActive(true);
            r14.SetActive(true);
            r13.SetActive(true);
            r15.SetActive(true);
            r16.SetActive(true);
            r17.SetActive(true);
            r18.SetActive(true);
            r19.SetActive(true);
            r20.SetActive(true);
          //cosita.SetActive(true);
                 if(w.contador == 9)
            {
                r13.SetActive(false);
            }        if(w.contador == 8)
            {
                r14.SetActive(false);
            }        if(w.contador == 7)
            {
                r15.SetActive(false);
            }        if(w.contador == 6)
            {
                r16.SetActive(false);
            }        if(w.contador == 5)
            {
                r17.SetActive(false);
            }        if(w.contador == 4)
            {
                r18.SetActive(false);
            }        if(w.contador == 3)
            {
                r19.SetActive(false);
            }      
            
            
            if(w.contador == 2)
            {
                r20.SetActive(false);
            }
       cont.s = false;
          
            ganar1.SetActive(true);
            uno = false;

            if (w.contador == 10)
            {
                fin.SetActive(true);
            }

        }
        
        {  
        }
    }
}
