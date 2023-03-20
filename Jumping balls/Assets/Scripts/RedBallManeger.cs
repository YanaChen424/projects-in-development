using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallManeger : MonoBehaviour
{
    public int redballCounter;
    public int redballCreated;
    public GameObject redball;
    float randomX;
    float randomY;



    // Start is called before the first frame update
    void Start()
    {
        redballCounter = 0;
        redballCreated = 0;

    }

    //newEnemy.GetComponent<EnemyEngine>().enemyManeger = this;

    private void Update()
    {
        if (redballCounter == 0)
        {
            while (redballCounter < redballCreated)
            {
                for (int i = 0; i < 20; i++)
                {
                    randomX = Random.Range(-2.5f, 2.5f);
                    randomY = Random.Range(0f, 3f);
                    GameObject newEnemy = Instantiate(redball, new Vector2(randomX, randomY), redball.transform.rotation);
                    redballCounter++;
                }
            }
            redballCreated++;
        }
    }
}
