using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quality : MonoBehaviour
{
    public Text qualityText;
    private string qualitysNames;

    public int newQuality;

    public void NextQuality()
    {
        newQuality++;
        Qualitys();
    }
    public void BackQuality()
    {
        newQuality--;
        Qualitys();
    }

    public void Aplicar()
    {
     QualitySettings.SetQualityLevel(newQuality, true);
    }

    private void Qualitys()
    {
        newQuality = Mathf.Clamp(newQuality, 0, 5);
      
        switch (newQuality)
        {
            case 0://Very Low
                qualitysNames = "Very Low";
                
                break;
            case 1://Low
                qualitysNames = "Low";
                break;
            case 2://Medium
                qualitysNames = "Medium";
                break;
            case 3://High
                qualitysNames = "High";
                break;
            case 4://Very High
                qualitysNames = "Very High";
                break;
            case 5://Ultra
                qualitysNames = "Ultra";
                break;
        }


        switch (newQuality)
        {
            case 0:

                Screen.SetResolution(480, 270, true);
                break;
            case 1:
                Screen.SetResolution(640, 360, true);
                break;
            case 2:
                Screen.SetResolution(960, 540, true);
                break;
            case 3:
                Screen.SetResolution(960, 540, true);
                break;
            case 4:
                Screen.SetResolution(1280, 720, true);
                break;
            case 5:
                Screen.SetResolution(1280, 720, true);
                break;
        }
        qualityText.text = qualitysNames;
        PlayerPrefs.SetInt("Q", newQuality);

    }

    private void Start()
    {
        newQuality = PlayerPrefs.GetInt("Q", 5);
        switch (newQuality)
        {
            case 0://Very Low
                qualitysNames = "Very Low";

                break;
            case 1://Low
                qualitysNames = "Low";
                break;
            case 2://Medium
                qualitysNames = "Medium";
                break;
            case 3://High
                qualitysNames = "High";
                break;
            case 4://Very High
                qualitysNames = "Very High";
                break;
            case 5://Ultra
                qualitysNames = "Ultra";
                break;
        }
        qualityText.text = qualitysNames;

    }
}
