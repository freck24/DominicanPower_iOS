using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player1 : MonoBehaviour
{
    Rigidbody rb;
    public float velocidad;
    public Transform target;
    bool vibraniun = true;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("vibrar", 1) == 0)
        {
            vibraniun = false;
        }
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame


    public float movh;
    public float movv;
    public float cx;
    public float cy;
    public float limitevelocidad = 200;
    public Vector4 rotacion;
   public int r;

    public Animator anim;
    public bool unavez = true;


    public void anims()
    {
        anim.SetBool("plop", true);

      //  unavez = true;
    }
    void Update()
    {
        animacion();
         movh = CrossPlatformInputManager.GetAxis("Horizontal") * velocidad;
         movv = CrossPlatformInputManager.GetAxis("Vertical") * velocidad;
      
        
        if(movh!=0 && movv != 0 && unavez)
        {
            anim.SetBool("plop", false);
            unavez = false;
            if(vibraniun)
            Vibration.Vibrate(15);

        }
          
        if(movh==0 && movv == 0 && !unavez)
        {
          
            unavez = true;

        }
        
        

        if (movh > limitevelocidad)
        {
            cx = 500;
            player1anim.SetBool("corre", true);
        }
        else if (movh > 0)
        {
            cx = limitevelocidad;
            player1anim.SetBool("camina", true);
            player1anim.SetBool("corre", false);


        }

        
        if (movh < -limitevelocidad)
        {
            cx = -500;
            player1anim.SetBool("corre", true);

        }
        else if (movh < 0)
        {
            cx = -limitevelocidad;
            player1anim.SetBool("camina", true);
            player1anim.SetBool("corre", false);

        }
        
        if (movv > limitevelocidad)
        {
            cy = 500;
            player1anim.SetBool("corre", true);
        }
        else if (movv > 0)
        {
            cy = limitevelocidad;
            player1anim.SetBool("camina", true);
            player1anim.SetBool("corre", false);
        }

        
        if (movv < -limitevelocidad)
        {
            cy = -500;
            player1anim.SetBool("corre", true);
        }
        else if (movv < 0)
        {
            cy = -limitevelocidad;
            player1anim.SetBool("camina", true);
            player1anim.SetBool("corre", false);

        }

        if (movv == 0)
        {
            cy = 0;
            
        }  if (movh == 0)
        {
            cx = 0;
      
        }
        
        if(cy==0 && cx == 0)
        {
            player1anim.SetBool("corre", false);
            player1anim.SetBool("camina", false);

        }




        rb.AddForce(cx, 0, cy);

        // transform.LookAt(target);

        ponmeenupdate();

        

    }

    public Vector3 v;
    public float relativo;

    public Animator player1anim;



    public void animacion()
    {
        v = rb.velocity;
        relativo = movh * movh + movv * movv;
        if (relativo > 50000)
        {
            player1anim.SetBool("corre", true);

        }
        else if (relativo > 0)
        {
            player1anim.SetBool("camina", true);
            player1anim.SetBool("corre", false);
        }
        else
        {
            player1anim.SetBool("corre", false);
            player1anim.SetBool("camina", false);
        }
    }

    public float x;
    public float y;
    public float angulo;
    public float VELOCIDAD;

    void ponmeenupdate()
    {
          y = CrossPlatformInputManager.GetAxis("Vertical");
           x = CrossPlatformInputManager.GetAxis("Horizontal");
        angulo = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        print("estoy_en_update");

        if (y != 0 && x != 0)
            transform.eulerAngles = new Vector3(0, -angulo, 0);
    }

   



}
