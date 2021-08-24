using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botella : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D r;
    Vector2 a;
    public float rand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator autodestruirse()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" || collision.tag == "botella")
        {
           // rand = 100;
         //   a = new Vector2(rand, 0);
         //   r.AddForce(a);
            anim.SetBool("rota", true);
            StartCoroutine(autodestruirse());
        }
    }
}
