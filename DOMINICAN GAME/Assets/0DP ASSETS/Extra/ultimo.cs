using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultimo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject ob;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ob.SetActive(false);
        }
    }
}
