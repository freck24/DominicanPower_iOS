using System;
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
    public GameObject StartCanvas;
    public GameObject GameOverCanvas;
    public Text ShowDinero;
    public Text ShowCalibrin;
    public Image Filling_CalibrinTime;
    public float CalibrinTime;
    public float Calibrin_rararara;
    public Animator AnmCanvas;

    [Header("record")]
    public string RecordKey = "RecordMoto";
    public float DistanciaPartida;
    public float DistanciaRecord;
    public Text DistanciaPartidaTx;
    public Text DistanciaRecordTx;

    public GameObject Explosion;
    public void PerdioPlayer()
    {
        Instantiate(Explosion, PlayerRunner.pr.transform.position, Quaternion.identity);
        PlayerRunner.pr.Player.PlayOneShot(PlayerRunner.pr.Perder);
        PlayerRunner.pr.velMove = 0;
        PlayerRunner.pr.VelMulti = 0;
        PlayerRunner.pr.Velocidad = 0;
        Time.timeScale = 1;

        if (DistanciaPartida > DistanciaRecord)
        PlayerPrefs.SetInt(RecordKey, Convert.ToInt32(DistanciaPartida));

        GameOverCanvas.SetActive(true);
        Invoke("DestruirPlayer", 1.4f);
    }

    public void DestruirPlayer()
    {
        PlayerRunner.pr.gameObject.SetActive(false);

   
    }

    void Start()
    {
        rmg = this;
        for (int i = 0; i < StartGenerateRoad; i++) GenerarSiguienteTile();

        DistanciaRecord = PlayerPrefs.GetInt(RecordKey, 0);
        DistanciaRecordTx.text = DistanciaRecord + "m";
    }

    public void StartGame()
    {
        StartCanvas.SetActive(false);
        StartCoroutine(IniciarJuego());

    }

   
   
    IEnumerator IniciarJuego()
    {
        MotoSound.ms.Change(MotoSound.ms.ArrancarMoto, false, 2);

        PlayerRunner.pr.AutoAumentar();
        yield return new WaitForSeconds(0.5f);

        while(PlayerRunner.pr.VelMulti <= 1.89)
        {
            PlayerRunner.pr.VelMulti += Time.deltaTime;
            yield return new WaitForSeconds(0.018f);
        }

        while (MotoSound.ms.sou.isPlaying)
        {
            yield return new WaitForSeconds(0.01f);
        }

        MotoSound.ms.Change(MotoSound.ms.Cambio1, true, 11);

    }

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
        DistanciaPartidaTx.text = Convert.ToInt32(DistanciaPartida) + "m";

        if(DistanciaPartida > DistanciaRecord)
        DistanciaRecordTx.text = Convert.ToInt32(DistanciaPartida) + "m";
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
      RunnerTile tile = Instantiate(RoadTiles[UnityEngine.Random.Range(0, RoadTiles.Count)], NextPoint.position, Quaternion.identity).GetComponent<RunnerTile>();
        NextPoint = tile.GenNext_Pos;
    }

    
}
