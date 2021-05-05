using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impuso : MonoBehaviour
{ public float f=1;
public float g=1;

    private Rigidbody2D r;
    // Start is called before the first frame update

    Vector2 a;



    public IEnumerator des()
    {
        yield return new WaitForSecondsRealtime(2);
        Destroy(gameObject);
    }
    void Start()
    { f = Random.Range(2, 5);
    g = Random.Range(-2, 3);
        r = GetComponent<Rigidbody2D>();
      //  r.AddForce(Vector2.up * 299*f);
        // transform.Rotate(g, 30 * g, 25*g);

        a = new Vector2(750*g / 10, f * 400);
        r.AddForce(a);

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "destructor")
        {
            Destroy(gameObject);
        }
    }

}
