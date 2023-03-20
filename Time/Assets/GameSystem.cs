using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameSystem : MonoBehaviour
{

    public TextMeshProUGUI Score;

    public GameObject button;
    button buttonScript;
    int scoreTempInt;

    int finalScore;
    public int targetint;


    // Start is called before the first frame update
    void start()
    {
        buttonScript = button.GetComponent<button>();
        buttonScript.rounds = 5;
        finalScore = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }



    //public void StartOver()
    //{
    //    if (buttonScript.runningNumInt <= 100)
    //    {
    //        print(buttonScript.runningNumInt);
    //        FinalScoreCalc();
    //    }
    //    buttonScript.rounds -= 1;
    //    target.text = Random.Range(1, 100).ToString();
    //    numberOfSec.text = Random.Range(3, 7).ToString();
    //    buttonScript.runningNumInt = 0;
    //}
}
