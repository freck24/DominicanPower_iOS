using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comienzaboss : MonoBehaviour
{
    public boss b;
    public bool una = true;
    public camarasigue c;
    public gestorauidos g;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject pared;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && una)
        {
            g.sonidomagnate();
            una = false;
            b.dale();
            pared.SetActive(true);
            canvas.SetActive(true);
        }
    }
}
