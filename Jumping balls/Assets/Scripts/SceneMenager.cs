using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenager : MonoBehaviour
{
    public void Win()
    {
        SceneManager.LoadScene("Won");
    }

    public void Lose()
    {
        SceneManager.LoadScene("Lost");
    }

    public void StartOver()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
