using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoManager : MonoBehaviour
{
    public List<SpriteRenderer> Sprites;

    public void SetColors(Color colorsito)
    {
        for (int i = 0; i < Sprites.Count; i++)
        {
            Sprites[i].color = colorsito;
        }
    }
}
