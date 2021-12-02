using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseArcher : MonoBehaviour
{
    public float Normal;

    public float NivelPokemon;
    public float Current_XP_Level;
    public float Next_XP_Level;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Normal = MyRemapper(NivelPokemon, Current_XP_Level, Next_XP_Level, 0, 1);

    }

    public static float MyRemapper(float from, float fromMin, float fromMax, float toMin, float toMax)
    {
        float num = (from - fromMin) / (fromMax - fromMin);
        return (toMax - toMin) * num + toMin;
    }
}
