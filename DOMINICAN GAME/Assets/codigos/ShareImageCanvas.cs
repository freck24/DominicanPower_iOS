﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;


public class ShareImageCanvas : MonoBehaviour
{
    // public
    // private
    private bool isProcessing = false;
    public Image buttonShare;
    public string mensaje;

    //function called from a button
    public void ButtonShare()
    {
        buttonShare.enabled = false;
        if (!isProcessing)
        {
            StartCoroutine(ShareScreenshot());
            StartCoroutine(ima());

        }
    }

    IEnumerator ima()
    {
        imagen.SetActive(true);
     
        yield return new WaitForSecondsRealtime(2f);
        imagen.SetActive(false);
    }

    public GameObject imagen;
    public IEnumerator ShareScreenshot()
    {



        {
            yield return new WaitForEndOfFrame();

            Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
            ss.Apply();

            string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
            File.WriteAllBytes(filePath, ss.EncodeToPNG());

            // To avoid memory leaks
            Destroy(ss);

            new NativeShare().AddFile(filePath)
                .SetSubject("Descargalo ").SetText("https://play.google.com/store/apps/details?id=prueba1.SDS").Share();
            // .SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
            //  .Share();

            // Share on WhatsApp only, if installed (Android only)
            //if( NativeShare.TargetExists( "com.whatsapp" ) )
            //	new NativeShare().AddFile( filePath ).SetText( "Hello world!" ).SetTarget( "com.whatsapp" ).Share();

          //  buttonShare.enabled = true;
        }
    } 
}