using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerMovement : MonoBehaviour
{
    //shoot
    float mouseX;
    float mouseY;
    public int speed;
    Rigidbody2D rb;

    int ColRedBall;
    int WinScore;
   

    public TextMeshProUGUI Score;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        WinScore = 0;
        rb = GetComponent<Rigidbody2D>();
        ColRedBall = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        Score.text= WinScore.ToString();
         if (Input.GetMouseButtonDown(1) &&ColRedBall>0)
        {
           rb.velocity=transform.position+ Vector3.up * 3;
            print(ColRedBall);
            print("1 up");
            ColRedBall--;

        }
        if(Input.GetMouseButtonDown(0) && ColRedBall >= 10)
        {
            rb.velocity = transform.position + Vector3.up * 9;
            print(ColRedBall);
            print("3 up");
            ColRedBall-=10;
        }
        if(WinScore==20)
        {
            FindObjectOfType<SceneMenager>().Win();
        }
        if(transform.position.x>8.4||transform.position.x<-8.4)
        {
            FindObjectOfType<SceneMenager>().Lose();
        }
    }

    void Shoot()
    {
        Vector3 playerPosition = transform.position;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 velocityDirection = mousePosition - playerPosition; //new Vector3(mousePosition.x-playerPosition.x, mousePosition.y-playerPosition.y, 0);
        speed = 10;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = velocityDirection.normalized * speed;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RedBall")
        {
            Destroy(collision.gameObject);
            WinScore++;
            ColRedBall++;
            print(ColRedBall);
        }

    }

}
