using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocasuelodestruye : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator dest()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "suelo")
        {
            StartCoroutine(dest());
        }
    }
}
