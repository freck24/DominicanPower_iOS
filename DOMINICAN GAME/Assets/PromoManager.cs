using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PromoManager : MonoBehaviour
{
    public Sprite Face, Insta, Tiktok;

    public Image Rend;


    public GameObject PanelDisponible;
    public GameObject PanelNoDisponible;

    public static GameObject MyObj;
    public GameObject MyObjWin;
    public static string FollowingTemp;
    public static string ActualUrl;

    public bool OpenedLink;

    public string Keycod;

    private void Start()
    {
        if (FollowingTemp == "Face")
        {
            Rend.sprite = Face;
            Keycod = "Face";
        }

        if (FollowingTemp == "Insta")
        {
            Rend.sprite = Insta;
            Keycod = "Insta";
        }

        if (FollowingTemp == "Tiktok")
        {
            Rend.sprite = Tiktok;
            Keycod = "Tiktok";
        }

        if(PlayerPrefs.GetInt(Keycod, 0) == 1)
        {
        PanelDisponible.SetActive(false);
        PanelNoDisponible.SetActive(true);
        }
        else
        {
        PanelDisponible.SetActive(true);
        PanelNoDisponible.SetActive(false);
        }


    }

public void OpenUrl()
    {
        transform.localScale = Vector3.zero;

        if (!OpenedLink)
        {
            OpenedLink = true;
            transform.localScale = Vector3.zero;
            Invoke("CrearRecompensa", 2f);
        }

        Application.OpenURL(ActualUrl);
    }

    public void CrearRecompensa()
    {
        PlayerPrefs.SetInt(Keycod, 1);
        Instantiate(MyObjWin);
        gameObject.SetActive(false);
        PlayerPrefs.SetFloat("dinero", PlayerPrefs.GetFloat("dinero", 0) + 2000);
    }
}
