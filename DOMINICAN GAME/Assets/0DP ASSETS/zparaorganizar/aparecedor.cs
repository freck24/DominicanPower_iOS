using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecedor : MonoBehaviour
{
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(aparece());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int n = 25;
    IEnumerator aparece()
    { 
      //  while (n > 0)
        
        {
            yield return new WaitForSecondsRealtime(1);
            o1.SetActive(true);
            yield return new WaitForSecondsRealtime(1.2f);
            o2.SetActive(true);
            yield return new WaitForSecondsRealtime(1.25f);
            o3.SetActive(true);
            yield return new WaitForSecondsRealtime(0.1f);
            o4.SetActive(true);
            yield return new WaitForSecondsRealtime(0.05f);

        }
    }


}
