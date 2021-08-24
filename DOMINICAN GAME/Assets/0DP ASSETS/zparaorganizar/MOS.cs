using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOS : MonoBehaviour
{ public float v = 5;
 public float Y = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(D());   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-v * Time.deltaTime, -Y*Time.deltaTime, 0);



    }
    public GameObject ene;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Y = -Y;
        }
        if (collision.tag == "ganar2" )
        {
        
            Instantiate(ene, transform.position, Quaternion.identity);
            Destroy(gameObject);
            PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) - 1);
        }


        if(collision.tag == "suelo")
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) -1);
        }

    }

    public IEnumerator D()
    {
        yield return new WaitForSecondsRealtime(6);
        Destroy(gameObject);
        PlayerPrefs.SetInt("cg", PlayerPrefs.GetInt("cg", 0) - 1);
    }

}
