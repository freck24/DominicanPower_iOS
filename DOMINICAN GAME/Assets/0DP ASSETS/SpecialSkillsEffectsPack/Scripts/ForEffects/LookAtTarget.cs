using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform Target;
    public int x = 1;
    public int y = 1;
    public int z = 1;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(Target.position.x*x, Target.position.y * y, Target.position.x * z));
    }
}
