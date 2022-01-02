using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    // this is to make player move
    private float dir = 1;
    public float speed;
    public float jumpHeight;
    private Rigidbody2D playerRB;
    bool facingRight = true;

    //touch/swipecontrol

   //these two will help us know what exactly is a swipe
    public float maxSwipeTime;//0.5
    public float minSwipeDistance;//100


    //these three will help us know how long did our swipe took
    private float startTime;
    private float endTime;
    private float swipeTime;//this will be compared with maxTime;


    //these three will help us know how long the swipe is
    private Vector2 swipeStartPos;
    private Vector2 swipeEndPos;
    private float swipeDistance;//this will be compared with minSwipeDistance;




    void Start()
    {
        speed = 10;
        playerRB = GetComponent<Rigidbody2D>();
    }
    public bool d = false;
    public bool i = false;
    void Update()
    {
        playerRB.velocity = new Vector2(dir * speed * Time.deltaTime, playerRB.velocity.y);
        Playermovement();
        PlayerJump();
        SwipeTest();


        if (d)
        {
            derechad();
            i = false;
        }
        if (i)
        {
            isquierdad();
                d = false;
        }

    }
    
    void Playermovement()
    {//makes player flip left and right and move left and right
        if (Input.GetKeyDown(KeyCode.A) && facingRight)
        {
            FlipAndMove();//player will flip and go left
            
        }
        else if (Input.GetKeyDown(KeyCode.D) &&  !facingRight)
        {
            FlipAndMove();// player will flip and go right
            
              
        }
    }
    public float r = 5;
    public float velocidadr = 5;


    public void derecha()
    {
        d = true;
    }
    public void isquierda()
    {
        i = true;
    } public void derechad()
    {   
        transform.Translate(velocidadr*Time.deltaTime, 0, 0);
        transform.Rotate(0,0,-velocidadr * Time.deltaTime);
    }
    public void isquierdad()
    {
        transform.Translate(-velocidadr * Time.deltaTime, 0, 0);
        transform.Rotate(0,0,velocidadr * Time.deltaTime);
    }

    public void deten()
    {
        i = false;
        d = false;
    }


    public void FlipAndMove()
    {//makes the player flip and move
        StartCoroutine(velocit());
        r = -r;
        dir = -dir;
        transform.Rotate(0, 0,r);
        facingRight = !facingRight;
    }
    void PlayerJump()
    {// makes player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.velocity = Vector2.up * jumpHeight * Time.deltaTime;
        }
        
    } 

    void SwipeTest()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                startTime = Time.time;//this will see when we started touching the screen
                swipeStartPos = touch.position;//where we have started touching the screen
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTime = Time.time;//the time when we left th screen
                swipeEndPos = touch.position;//the position when we left the screen

                swipeTime = endTime - startTime;//this will calculate how long our swip took
                swipeDistance = (swipeEndPos - swipeStartPos).magnitude; //this will calculate how long our swipe is
                
                if(swipeTime<maxSwipeTime && swipeDistance > minSwipeDistance) 
                {//here if we swipe fast and long enough then it will be a swipe
                    SwipeControl();
                }
            }
        }
    }
    public float v;


    public void cambiare()
    {
        PreLoaderLevel.preload.CargaLvl("inicio");

    }

    public IEnumerator velocit()
    {
       
        v = Random.Range(-10, 10);
        speed = 50;
        yield return new WaitForSecondsRealtime(1);
        playerRB.velocity = new Vector2(v, 0);
        speed = v;
        transform.Rotate(0, 0,-r);

    }
    void SwipeControl()
    {
        Vector2 distance = swipeEndPos - swipeStartPos;
        float xDistance = Mathf.Abs(distance.x);
        float yDistance = Mathf.Abs(distance.y);
        if (xDistance > yDistance)
        {
            
            Debug.Log("horizontal swipe");
            if (distance.x > 0 && !facingRight)
            {
               
                FlipAndMove();
            }
            else if (distance.x < 0 && facingRight == true)
            {
                //your swiping left
                StartCoroutine(velocit());
                FlipAndMove();
            }
        }
        if (xDistance < yDistance)//if you are swiping up or down
        {
            Debug.Log("vertical swipe");
            StartCoroutine(velocit());
            if (distance.y > 0){
                //your swiping up
                playerRB.velocity = Vector2.up * jumpHeight * Time.deltaTime;
            }
            else if (distance.y < 0)
            {
                StartCoroutine(velocit());
                playerRB.velocity = Vector2.down * jumpHeight * Time.deltaTime;
                // your swiping down
            }
                
        }
    }
}
