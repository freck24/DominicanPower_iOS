using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResucitePlatform : MonoBehaviour
{
    public Transform PlayerRespawn;
    public GameObject Plataforma;
    public controler Player;

    // Update is called once per frame
    void Update()
    {
    if (Time.frameCount % 6 != 0 || Plataforma.activeSelf) return;

    if (Player.suelito && Player.vidas > 0)
    transform.position = Player.transform.position;
    }

    public void GenPlat()
    {
        GameObject newP = Instantiate(Plataforma, transform);
        newP.transform.SetParent(null, true);
        newP.SetActive(true);
    }
}
