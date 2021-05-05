using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOMBALAGRIMOGINA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MUERE());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MUERE()
    {
        yield return new WaitForSecondsRealtime(5);

        Destroy(gameObject);
        PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) - 1);
    }
}
