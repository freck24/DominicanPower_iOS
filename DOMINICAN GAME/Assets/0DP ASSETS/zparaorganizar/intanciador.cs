using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intanciador : MonoBehaviour
{   public GameObject ene;
  //  public GESTORPRINCIPAL gestor;
    public bool espera = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator esp()
    {
        yield return new WaitForSecondsRealtime(1);
        espera = true;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && espera)
        {
            if (PlayerPrefs.GetInt("cg", 0) < 6)
            {
                Instantiate(ene, transform.position, Quaternion.identity);
                PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) + 1);
                espera = false;
                StartCoroutine(esp());
            }
        }
    }
}
