using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaropmpible : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "pies")
        {
            anim.SetBool("tocado", true);
            StartCoroutine(s());
        }
    }

    public  IEnumerator s()
    {
        yield return new WaitForSecondsRealtime(2f);
        anim.SetBool("tocado", false);

    }
}
