using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tragaperras1 : MonoBehaviour
{
    public GameObject AUDIO;
    public float suave = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int tiempo;
   public int i = 19;
    public bool parado = false;
    public Transform ro;
    public float rotacion;
    // Update is called once per frame
    void Update()
    {
        rotacion = transform.rotation.x;
        if (parado == false)
        {
            transform.Rotate(500 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, target[i].rotation, Time.deltaTime * suave);
        }
        }
   


    public Transform tragadora;

    public Transform[] target;

    public void jugar()
    {
        StartCoroutine(tragando());
    }


    IEnumerator tragando()
    {
        yield return new WaitForSecondsRealtime(tiempo);
        AUDIO.SetActive(true);

        i = Random.Range(0, 20);
        if (i == 14)
        {
            i = 7;
        }
        parado = true;
        yield return new WaitForSecondsRealtime(0.75f);
        AUDIO.SetActive(false);
        



    }
    public void PA()
    {
        parado = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "parador")
        {
            parado = true;
        }
    }

}
