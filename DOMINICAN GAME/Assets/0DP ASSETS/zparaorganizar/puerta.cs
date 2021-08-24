using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    public GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator pu()
    {
        yield return new WaitForSecondsRealtime(9);
        p.SetActive(true);
    }
}
