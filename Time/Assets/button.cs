using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool buttonPressed;

    public TextMeshProUGUI runningNum;
    public int runningNumInt;

    public GameObject GameSystem;
    GameSystem gameSystem;



    public float timeSec;
    WaitForSecondsRealtime waitForSecondsRealtime;
    float timer;
    public int targetNum;

    public static int score;
    int finalScore;

    bool startRound;
    public int rounds;

    public TextMeshProUGUI Target;
    public TextMeshProUGUI Sec;

    // Start is called before the first frame update
    void Awake()
    {

        timeSec = UnityEngine.Random.Range(3, 7);
        targetNum = UnityEngine.Random.Range(1, 100);
        Target.text=targetNum.ToString();
        Sec.text= timeSec.ToString();
        score = 0;
        Time.timeScale = 1.0f;
        runningNum.text = "0";
        runningNumInt = 0;
        timer = 0f;
        startRound = false;
        rounds = 5;

    }

    // Update is called once per frame
    void Update()
    {



        if (rounds != 0)
        {
            
            float waitTime = timeSec / 100;
            if (buttonPressed)
            {
                startRound = true;
                timer += Time.deltaTime;
                print(timer);
                if (timer > waitTime)
                {
                    buttonPressedAndNumUp();
                    timer = timer - waitTime;
                }
                if (runningNumInt > 100)
                {
                    startRound = false;
                    StartNewRound();
                }
            }
            


            else if (buttonPressed == false && runningNumInt <= 100 && runningNumInt > 0 && startRound)
            {


                if (runningNumInt == targetNum)
                {
                    score = 100;
                    startRound = false;

                    FindObjectOfType<GameManager>().FinalScoreCalc();
                    StartNewRound();
                    


                }
                else if (runningNumInt != targetNum)
                {
                    print(targetNum);
                    int calc = targetNum - runningNumInt;

                    print(runningNumInt);
                    print(calc);
                    score = 100 - Math.Abs(calc);

                    startRound = false;
                    
                    FindObjectOfType<GameManager>().FinalScoreCalc();
                    StartNewRound();


                }

            }
        }
        //}else
        //{
        //    print("end of the game");
        //}

    }

    public void buttonPressedAndNumUp()
    {


        runningNumInt++;
        runningNum.text = runningNumInt.ToString();
        

    }

    void IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        buttonPressed = false;
    }

    void IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) 
    { 
        buttonPressed = true;
        

    }

    void StartNewRound()
    {
        rounds--;
        timeSec = UnityEngine.Random.Range(3, 7);
        targetNum = UnityEngine.Random.Range(1, 100);
        Target.text = targetNum.ToString();
        Sec.text = timeSec.ToString();

        runningNum.text = "0";
        runningNumInt = 0;
        timer = 0f;

    }
}
