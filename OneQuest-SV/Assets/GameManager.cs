using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;

    public GameObject Coins;
    public TextMeshProUGUI timer;
    float timeLeft;

    public GameObject green;
    public string choice;

    public GameObject Player;
    public bool thirdPanelStart;
    // Start is called before the first frame update
    void Start()
    {
        thirdPanelStart = false;
        timeLeft = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //if (choice != "")
        //{
        //    Panel1.SetActive(false);
        //}
        if (choice== "firstChoice1")
        {
            green.transform.position += new Vector3(0, 0, 3);
            choice = "";
            Panel1.SetActive(false);
            Player.GetComponent<PlayerMouseMovementCC>().start = true;
        }
       if(choice== "SecandChoice1")
        {
            Panel1.SetActive(false);
            Panel2.SetActive(true);


        }
       if(thirdPanelStart)
        {
            Panel3.SetActive(true);
            if(timeLeft>0)
            {
                timerCoins();
            }
        }

       if(choice== "SecandChoice3")
        {
            Panel3.SetActive(false);
            Player.GetComponent<PlayerMouseMovementCC>().start = true;
        }

       if(choice== "firstChoice3")
        {
            Panel3.SetActive(false);
            Coins.SetActive(true);
        }

    }

    private void timerCoins()
    {
        timer.text = timeLeft.ToString();
        timeLeft -= Time.deltaTime;
    }

    private IEnumerator WaitTime()
    {

        yield return new WaitForSeconds(2);

    }
}
