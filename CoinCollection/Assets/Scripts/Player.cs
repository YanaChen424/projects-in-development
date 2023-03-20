using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D m_Rigidbody;
    float speed;
    //int score;
    int redCount;

    public int score;

    void Start()
    {
        score = 0;
        speed = 0.4f;
       redCount = 0;
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.AddForce(transform.up * speed);
        //if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        //{


        //    gameObject.transform.position += new Vector3(0, 1*speed, 0);
        //}
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            gameObject.transform.position += new Vector3(1*speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            gameObject.transform.position += new Vector3(-1*speed, 0, 0);
        }

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "green")
        {
            //score += 1;
            score += 1;
            SaveScore.Instance.score = score;
            speed+=0.2f;
            print(speed);
            Destroy(other.gameObject);

        }
        if(other.tag == "red")
        {
            redCount++;
            if(redCount==5)
            {
                FindObjectOfType<SceneMenager>().Lose();
            }
        }
    }

}
