using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pamedestruyo : MonoBehaviour
{
    public bool avisatipa = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "enemy")
        {
            gameObject.SetActive(false);
            avisatipa = true;

        }
    }



}
