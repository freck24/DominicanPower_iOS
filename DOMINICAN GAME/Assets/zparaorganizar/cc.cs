using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cc : MonoBehaviour
{
    public SpriteRenderer s;
    public SpriteGlow.SpriteGlowEffect f;

    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<SpriteRenderer>();
        f = GetComponent<SpriteGlow.SpriteGlowEffect>();
        f.GlowColor = s.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
