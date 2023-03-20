using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score:"+SaveScore.Instance.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
