using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PromoManager : MonoBehaviour
{
    public Sprite Face, Insta, Tiktok;

    public Image Rend;

    public static GameObject MyObj;
    public static string FollowingTemp;
    public static string ActualUrl;

    private void Start()
    {
        if (FollowingTemp == "Face") Rend.sprite = Face;
        if (FollowingTemp == "Insta") Rend.sprite = Insta;
        if (FollowingTemp == "Tiktok") Rend.sprite = Tiktok;
    }

    public void OpenUrl()
    {
        Application.OpenURL(ActualUrl);
    }
}
