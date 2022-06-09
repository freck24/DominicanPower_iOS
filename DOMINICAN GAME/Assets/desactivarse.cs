using UnityEngine;

public class desactivarse : MonoBehaviour
{

    void Awake()
    {
        if(PlayerPrefs.GetInt("Q", 5)==0 || PlayerPrefs.GetInt("Q", 5)==1 || PlayerPrefs.GetInt("Q", 5) == 2)
        {
            gameObject.SetActive(false);
        }
    }

}
