using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instaciadorsimle : MonoBehaviour
{
    public GameObject ene;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(it());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator it()
    {
        int i = 0;
        while (i < 10)
        {
            Instantiate(ene, transform.position, Quaternion.identity);
            yield return new WaitForSecondsRealtime(0.5f);
            i--;
        }
    }
}
