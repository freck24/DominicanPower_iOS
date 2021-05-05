using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIGUEVELOCIDAD : MonoBehaviour
{
    public movimientoaleatorio M1;
    public movimientoaleatorio M2;
    public movimientoaleatorio M3;
    public movimientoaleatorio M4;
    public float velocidad = 1;
    public float velocidads = 1;
    public int j = 1;
   public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = M1.velocidad;
        anim = anim.GetComponent<Animator>();
       // velocidads = M1.velocidads;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (j == 1)
        {
            velocidad = M1.velocidad;
        } 

    }

   IEnumerator fal()
    {
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("t2", false);
        anim.SetBool("t3", false);
        anim.SetBool("t4", false);

    }
    public void u2()
    {
        transform.position = new Vector3(M2.transform.position.x, transform.position.y, transform.position.z);
        anim.SetBool("t2", true);
        StartCoroutine(fal());
    }
    public void u3()
    {
        transform.position = new Vector3(M3.transform.position.x, transform.position.y, transform.position.z);
        anim.SetBool("t3", true);
        StartCoroutine(fal());
    }
    public void u4()
    {
        transform.position = new Vector3(M4.transform.position.x, transform.position.y, transform.position.z);
        anim.SetBool("t4", true);
        StartCoroutine(fal());
    }
}
