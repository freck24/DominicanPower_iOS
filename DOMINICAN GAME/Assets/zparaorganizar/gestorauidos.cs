using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestorauidos : MonoBehaviour
{
    private AudioSource a;
    public AudioClip principal;
    public AudioClip principals;
    public AudioClip principalb;
    public AudioClip principalr;
    public AudioClip principalu;
    public AudioClip magnate;
    public AudioClip flow;
    public bool c = false;
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
      // PlayerPrefs.SetFloat("nivel", 6);
        a = GetComponent<AudioSource>();
       
        if (PlayerPrefs.GetFloat("nivel", 1) == 6 || PlayerPrefs.GetFloat("nivel", 1) == 20)
        {
           
           /* cam2.SetActive(true);
            cam1.SetActive(false);*/
            principal = principals;
        }
        if (PlayerPrefs.GetFloat("nivel", 1) == 5)
        {
            principal = principalu;
        } 
        if (PlayerPrefs.GetFloat("nivel", 1) == 7)
        {
            principal = principalb;
        }if (PlayerPrefs.GetFloat("nivel", 1) == 11)
        {
            principal = principalr;
        } if(PlayerPrefs.GetFloat("nivel", 1) > 20 )
        {
            principal = principalr;
        }
        a.clip = principal;
        a.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sonidomagnate()
    {
        principal = magnate;
        flow = magnate;
        a.clip = principal;
        a.Play();
    }

      public void sonidomagnatefin()
    {
        principal = principalb;
        flow = principalb;
        a.clip = principal;
        a.Play();
    }




    public void pla()
    {
        a.Play();
    }
    public void sto()
    {
        a.Stop();
    }

    public void musica()
    {
        c = !c;

        if (c)
        {
            a.clip = flow;
            a.Play();
        }if (!c)
        {
            a.clip = principal;
            a.Play();
        }



    }

}
