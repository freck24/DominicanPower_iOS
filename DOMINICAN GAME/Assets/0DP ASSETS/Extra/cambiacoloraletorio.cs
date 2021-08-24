using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiacoloraletorio : MonoBehaviour
{
    
    public Material[] m;
    public MeshRenderer mat;
    public int r = 1;
    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(1, m.Length);
        mat.sharedMaterial = m[r];
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
