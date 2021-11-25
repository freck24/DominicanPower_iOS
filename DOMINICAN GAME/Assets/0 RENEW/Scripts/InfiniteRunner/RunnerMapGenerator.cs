using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class RunnerMapGenerator : MonoBehaviour
{
    public static RunnerMapGenerator rmg;

    public Transform NextPoint;
    public int StartGenerateRoad;
    public List<GameObject> CoinsPatron;
    public List<GameObject> RoadTiles;
    public List<GameObject> Obstaculos;

    [Header("Obstaculos")]
    public GameObject Cono;
    public GameObject Hoyo;

    [Header("Gameplay")]
    public Transform Road;
    public float Velocidad;
    public bool Playing;

    [Header("Canvas")]
    public Text ShowDinero;
    public Text ShowCalibrin;
    public Image Filling_CalibrinTime;
    public float CalibrinTime;
    public float Calibrin_rararara;
    public Animator AnmCanvas;

    public float Remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }


    void ManagePlay()
    {
        if (!Playing) return;

    }

    void RestarCalibrandoTime()
    {
        if(PlayerRunner.pr.Boosting)
        {
            Calibrin_rararara -= Time.deltaTime;
            Filling_CalibrinTime.fillAmount = Mathf.Clamp(Remap(Calibrin_rararara, 0, CalibrinTime, 0, 1)   ,0,1);

            if(Calibrin_rararara < -1)
            {
                PlayerRunner.pr.Boosting = false;
                PlayerRunner.pr.anim.SetBool("Calibrando", false);

            }

        }
    }

    void Update()
    {
        RestarCalibrandoTime();

        AnmCanvas.SetBool("New Bool", PlayerRunner.pr.Boosting);

        if (Time.frameCount % 10 == 0)
        {
            ShowDinero.text = PlayerPrefs.GetFloat("dinero", 0).ToString();
            ShowCalibrin.text = PlayerPrefs.GetInt("runnerboost", 0).ToString();

        }
    }

    public void GenerarSiguienteTile()
    {
      RunnerTile tile = Instantiate(RoadTiles[Random.Range(0, RoadTiles.Count)], NextPoint.position, Quaternion.identity).GetComponent<RunnerTile>();
        NextPoint = tile.GenNext_Pos;
    }

    void Start()
    {
        rmg = this;
        for (int i = 0; i < StartGenerateRoad; i++) GenerarSiguienteTile();
    }
}
