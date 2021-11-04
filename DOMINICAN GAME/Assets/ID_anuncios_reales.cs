using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ID_anuncios_reales : MonoBehaviour
{

    public bool testing;
    [Header("Datos Plataforma")]
    public string ID_App;
    public string ID_VideoReward;
    public string ID_Intersticial;



    [Header("Datos Android")]
    public string Id_Android_APP = "";
    public string Id_Android_Bonificado = "";
    public string Id_Android_Interticial = "";

    [Header("Datos Iphone")]
    public string Id_iOS_APP = "";
    public string Id_Ios_Bonificado = "";
    public string Id_Ios_Interticial = "";


    [Header("Test")]
    public string Id_TEST_Bonificado = "";
    public string Id_TEST_Interticial = "";




    private void Awake()
    {
        ID_App = MyPlataforma(Id_Android_APP, Id_iOS_APP);

        ID_VideoReward = MyPlataforma(Id_Android_Bonificado, Id_Ios_Bonificado);
        ID_Intersticial = MyPlataforma(Id_Android_Interticial, Id_Ios_Interticial);

        if(testing)
        {
            ID_VideoReward = Id_TEST_Bonificado;
            ID_Intersticial = Id_TEST_Interticial;
        }

    }


    public string MyPlataforma(string Android, string Apple)
    {
    #if UNITY_ANDROID
    return Android;
#elif UNITY_IOS
    return Apple;
#else
return Android;
#endif
    }


}
