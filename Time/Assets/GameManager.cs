using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    public static GameManager instance;

    int finalScore;
    int scoreTempInt;
    // Start is called before the first frame update
    private void start()
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FinalScoreCalc()
    {
        scoreTempInt = button.score;
        finalScore += scoreTempInt;
        finalScoreText.text = "Score:"+ finalScore.ToString();
    }
}
