using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enfoca : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float velocidad = 5;
    public bool una = true;
    public float tiempo;
    public bool devuelvete = false;
    public Vector3 pos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (una)
        {

            if (transform.position.x < target.position.x) { transform.Translate(velocidad, 0, 0); }
            else



            if (transform.position.y < target.position.y)
            {
                transform.Translate(0, velocidad, 0);
            }
            else
            {
                StartCoroutine(espera());
            }

        }
        
    }

    IEnumerator espera()
    {
        yield return new WaitForSecondsRealtime(tiempo);

    }


}
