using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroyer : MonoBehaviour
{
    public int TilesWaiting;
    public int DestroyIn;

    public void addTile(GameObject gb)
    {
        TilesWaiting++;
        gb.SetActive(false);
        gb.transform.parent = transform;

        if(TilesWaiting >= DestroyIn)
        {
            foreach (Transform child in transform)
            {
            Destroy(child.gameObject);
                TilesWaiting--;

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "arriba")
            Destroy(other.transform.parent.gameObject);
    }
}
