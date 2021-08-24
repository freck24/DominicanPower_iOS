using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocando : MonoBehaviour
{
    public GameObject ene;
    public Transform[] position;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(corrution());
    }
    

    IEnumerator corrution()
    {
        int i = 0;
        while(i<6)
        
        {
            Instantiate(ene, position[i].transform.position, Quaternion.identity);
            yield return new WaitForSecondsRealtime(0.2f);

            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
