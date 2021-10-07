using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsigniaSlot : MonoBehaviour
{
    public InsigniaInfoData data;

    [Header("Icono")]

    public Image IconManage;

    public Color color_Logrado = new Color(255, 255, 255);
    public Color color_NoLogrado = new Color(92, 92, 92);

    public void Check(InsigniaInfoData datax)
    {

    data = datax;

        data.Conseguida = PlayerPrefs.GetInt(data.id_unica + "_Ganada", 0) == 1;
   

    IconManage.color = data.Conseguida ? color_Logrado : color_NoLogrado;
        IconManage.sprite = data.Insignia_Icon; 

        print("Insignia:" + data.Conseguida);
    }
 public void Sing_Click()
    {
        FindObjectOfType<InsigniaInfo>().ShowDesc(data);
    }

}
