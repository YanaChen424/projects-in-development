using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum BattleState {Start,Player1,Player2,Won};
    
public class BattleSystem : MonoBehaviour
{
    public BattleState state;
    public TextMeshProUGUI num1;
    public TextMeshProUGUI num2;
    int player1number;
    int player2number;
    int ScorePlayer1;
    int ScorePlayer2;
    
    // Start is called before the first frame update
    void Start()
    {
        ScorePlayer1 = 0;
        ScorePlayer2 = 0;
        state=BattleState.Player1;
  
    }
    public void OnPlayer1()
    {
        if (state == BattleState.Player1)
        {
            player1number=PrintNumber(num1);
            state = BattleState.Player2;
            return;
        }
    }
    public void OnPlayer2()
    {
        if (state == BattleState.Player2)
        {
            player2number=PrintNumber(num2);
            if(player1number > player2number)
            {
                ScorePlayer1++;
            }else if(player1number < player2number)
            {
                ScorePlayer2++;
            }
            if(ScorePlayer1 == 5)
            {
                FindObjectOfType<SceneMenager>().Player1();
            }
            else if(ScorePlayer2 == 5)
            {
                FindObjectOfType<SceneMenager>().Player2();
            }

            state = BattleState.Player1;
            return;
        }
    }

    public int PrintNumber(TextMeshProUGUI num)
    {
        num.text=Random.Range(1,13).ToString();
        return int.Parse(num.text);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
