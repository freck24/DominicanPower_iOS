using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSelect : MonoBehaviour
{
    public static PlatformSelect ps;
    public static PlatformSelect psLocal;
    public bool statica;
    public bool IsAppleVersion;


    [Header("Links")]
    public string Link_Android;
    public string Link_Apple;

    void Start()
    {
        if (statica) ps = this;
        else psLocal = this;
    }

    public string Get_PlatformLink()
    {
        return (PlatformSelect.ps.IsAppleVersion) ? Link_Apple : Link_Android;
    }


    void AbrirLink(string sX)
    {
    AbrirLink(PlatformSelect.psLocal.Get_PlatformLink());

    print(sX);
    }

}
