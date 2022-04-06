using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform lookAt;
    void LateUpdate()
    {
        transform.LookAt(lookAt);
    }
}
