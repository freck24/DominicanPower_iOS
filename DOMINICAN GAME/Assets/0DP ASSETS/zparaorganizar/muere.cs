using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muere : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public GameObject matador;

    public int n = 5;

    public bool una = true;
    IEnumerator piedra()
    {

       
        
            anim.SetBool("mata", true);
            yield return new WaitForSecondsRealtime(1f);
            matador.SetActive(true);
            yield return new WaitForSecondsRealtime(1f);
            matador.SetActive(false);
            anim.SetBool("mata", false);
           
        

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && una)
        {
            StartCoroutine(piedra());
            una = false;
        }

    }
}