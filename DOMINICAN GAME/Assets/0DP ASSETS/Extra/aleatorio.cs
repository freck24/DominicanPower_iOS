using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aleatorio : MonoBehaviour
{
    
    public GameObject[] fondos;
   

    // public SpriteRenderer a;
   
    
   
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(0, fondos.Length-1);

        fondos[i].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
