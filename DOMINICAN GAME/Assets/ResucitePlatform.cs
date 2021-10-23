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
    if (Time.frameCount % 5 != 0) return;

        Debug.Log("Moving Resucite PF");
        if (Player.suel && Player.vidas > 0)
        {

            Vector3 newP = transform.position;
            newP.x = Player.transform.position.x;
            newP.y = Player.transform.position.y;
            transform.position = newP;
        }


    }

    public void GenPlat()
    {
        GameObject newP = Instantiate(Plataforma, transform);
        newP.transform.SetParent(null, true);
        newP.SetActive(true);
        Player.transform.position = PlayerRespawn.position;
    }
}
