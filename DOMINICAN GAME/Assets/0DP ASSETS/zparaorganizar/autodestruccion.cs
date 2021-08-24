using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodestruccion : MonoBehaviour
{
    // Start is called before the first frame update

    public float tiempodestruir = 0.25f;
    void Start()
    {
        StartCoroutine(des());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator des()
    {
        yield return new WaitForSecondsRealtime(tiempodestruir);
        Destroy(gameObject);
    }
}
