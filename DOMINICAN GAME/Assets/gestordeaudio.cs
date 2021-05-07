using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestordeaudio : MonoBehaviour
{
    public GameObject[] a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Animator anim;
    public Animator anim2;
    public void a1()
    {
        A.volume = 0.5f;
        a[0].SetActive(true);
    }  public void a2()
    {
        a[1].SetActive(true);
    } public void a3()
    {
        A.volume = 0.15f;
        a[2].SetActive(true);
    } public void a4()
    {
        A.volume = 0.10f;
        a[3].SetActive(true);
    }public void a5()
    {
        a[4].SetActive(true);
    }public void a6()
    {
       
        a[5].SetActive(true);
    }public void a12()
    {
       
        a[6].SetActive(true);
    }
    public void a7()
    {
        anim.SetBool("hand", true);
    }  public void a8()
    {
        anim2.SetBool("a1", true);
    }
     public void a9()
    {
        anim2.SetBool("a2", true);
    }  public void a10()
    { 
        poder.SetActive(true);
    } public void a11()
    {
        A.volume = 1;
        FIN.SetActive(true);
    }public void a13()
    {
        StartCoroutine(creditos());
    }



    IEnumerator creditos()
    {
        yield return new WaitForSecondsRealtime(8);
        SceneManager.LoadScene("creditos");
    }
    public GameObject poder;
    public GameObject FIN;

    public AudioSource A;
}
