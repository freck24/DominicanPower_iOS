using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsigniaSlot : MonoBehaviour
{
    public InsigniaInfoData data;

    [Header("Icono")]

    public Image IconManage;

    public void Check(InsigniaInfoData datax)
    {

    data = datax;

    data.Conseguida = PlayerPrefs.GetInt(data.id_unica, 0) == 1;
    Color color_Logrado = new Color(255, 255, 255);
    Color color_NoLogrado = new Color(92, 92, 92);

    IconManage.color = data.Conseguida ? color_NoLogrado : color_Logrado;
    }
 public void Sing_Click()
    {
        FindObjectOfType<InsigniaInfo>().ShowDesc(data);
    }

}
