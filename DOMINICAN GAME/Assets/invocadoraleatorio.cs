using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocadoraleatorio : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] objectos;
    public int i;
    void Start()
    {
        i = Random.Range(0, objectos.Length);
        Instantiate(objectos[i], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
