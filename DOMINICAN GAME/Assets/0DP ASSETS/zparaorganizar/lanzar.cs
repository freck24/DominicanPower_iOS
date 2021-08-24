using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzar : MonoBehaviour
{
    // Start is called before the first frame update

    
    public BoxCollider c;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        c = GetComponent<BoxCollider>();
    }
    public IEnumerator w()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        c.enabled = false;

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "suelo")
        {
            StartCoroutine(w());
        }
    }

}
