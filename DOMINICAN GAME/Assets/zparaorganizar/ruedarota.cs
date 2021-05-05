using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ruedarota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //  StartCoroutine(transi());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -1500 * Time.deltaTime);
    }



    public IEnumerator transi()
    {
        yield return new WaitForSecondsRealtime(10f);
        SceneManager.LoadScene("nivel1");
    }


}
