using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminLvlLoader : MonoBehaviour
{
    public InputField EntradaNivel;

    public void LoadNewLevel()
    {
        float Nivel = System.Convert.ToInt32(EntradaNivel.text);
        PlayerPrefs.SetInt("NivelSaltado", 1);
        PlayerPrefs.SetFloat("NivelSaltado_ID", Nivel - 1);
        PreLoaderLevel.preload.CargaLvl("LEVEL 1 CLONE");
        ChangeGameTime(1);
    }

    public void ChangeGameTime(float time) => Time.timeScale = time;
}
