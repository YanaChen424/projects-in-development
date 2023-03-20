using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenager : MonoBehaviour
{
    public void Player1()
    {
        SceneManager.LoadScene("Player1Won");
    }

    public void Player2()
    {
        SceneManager.LoadScene("Player2Won");
    }

    public void StartOver()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
