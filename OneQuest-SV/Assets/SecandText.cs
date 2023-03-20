using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SecandText : MonoBehaviour
{
    public TextMeshProUGUI riddleText2;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;
    public TextMeshProUGUI answer3;

    public GameObject gameManager;
    public GameObject Player;
    public List<Button> ButtonList = new List<Button>(3);
    

    
    int count;


    int num1;
    int num2;
    int rightAnswerNum;
    string rightAnswer;

    // Start is called before the first frame update
    void Start()
    {
        count = 4;
        rightAnswer=GenerateBoard();
    }

    // Update is called once per frame
    void Update()
    {

        if (rightAnswer == "answer1"&& gameManager.GetComponent<GameManager>().choice!=""&&count>0)
        {
            if (gameManager.GetComponent<GameManager>().choice == "firstChoice2")
            {
                TheRightAnswerChosen(0);
            }
            else if(gameManager.GetComponent<GameManager>().choice == "SecandChoice2" || gameManager.GetComponent<GameManager>().choice == "ThirdChoice2")
            {
                Player.GetComponent<PlayerMouseMovementCC>().start = true;
                StartCoroutine(WaitTime());
                
            }
        }

        else if (rightAnswer == "answer2" && gameManager.GetComponent<GameManager>().choice != "" && count > 0)
        {
            if (gameManager.GetComponent<GameManager>().choice == "SecandChoice2")
            {
                TheRightAnswerChosen(1);
            }
            else if(gameManager.GetComponent<GameManager>().choice == "firstChoice2" || gameManager.GetComponent<GameManager>().choice == "ThirdChoice2")
            {
                Player.GetComponent<PlayerMouseMovementCC>().start = true;
                StartCoroutine(WaitTime());
                
            }

        }
        else if (rightAnswer == "answer3" && gameManager.GetComponent<GameManager>().choice != "" && count > 0)
        {
            if (gameManager.GetComponent<GameManager>().choice == "ThirdChoice2")
            {
                TheRightAnswerChosen(2);
            }
            else if(gameManager.GetComponent<GameManager>().choice == "firstChoice2" || gameManager.GetComponent<GameManager>().choice == "SecandChoice2")
            {
                Player.GetComponent<PlayerMouseMovementCC>().start = true;
                StartCoroutine(WaitTime());
                
            }
        }

        if (count == 0)
        {
            gameObject.SetActive(false);
            gameManager.GetComponent<GameManager>().thirdPanelStart = true;
        }
    }

    string GenerateBoard()
    {
        num1 = Random.Range(3, 150);
        num2 = Random.Range(3, 150);
        if (num1 == num2)
        {
            num2 = num1 + 1;
        }
        riddleText2.text = "Only smart people can help me\r\nI want to check if you smart enough to help me.\r\nhow much is " + num1.ToString() + "+" + num2.ToString() + "?";
        rightAnswerNum = Random.Range(1, 3);
        switch(rightAnswerNum)
        {
            case 1:answer1.text= (num1 + num2).ToString();
                answer2.text = Random.Range(3, 150).ToString();
                answer3.text = Random.Range(3, 150).ToString();
                return "answer1";

            case 2:answer2.text= (num2 + num1).ToString();
                answer1.text = Random.Range(3, 150).ToString();
                answer3.text = Random.Range(3, 150).ToString();
                return "answer2";
            case 3: answer3.text = (num2 + num1).ToString();
                answer1.text = Random.Range(3, 150).ToString();
                answer2.text = Random.Range(3, 150).ToString();
                return "answer3";
            default:
                return "none";
        }

    }
    private IEnumerator WaitTime()
    {

        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);


    }
    void TheRightAnswerChosen(int indexButton)
    {
        count--;
        
        gameManager.GetComponent<GameManager>().choice = "";
        ButtonList[indexButton].interactable = false;
        rightAnswer=GenerateBoard();
        ButtonList[indexButton].interactable=true;
    }
}

