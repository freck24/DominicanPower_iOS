using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBG : MonoBehaviour
{

    public Material Mat;
    public float TimeMoveX;
    public float TimeMoveY;
    void Update()
    {
        Mat.mainTextureOffset += new Vector2(TimeMoveX * Time.deltaTime, TimeMoveY * Time.deltaTime);
    }
}
