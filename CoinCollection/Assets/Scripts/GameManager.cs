using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject green;
    public GameObject red;

    List<int> positionsX=new List<int>();
    List<int> positionsY=new List<int>();




    void Start()
    {
        
        for(int i=-8;i<=8;i++)
        {
            positionsX.Add(i);
        }
        for(int j=3;j<=63;j++)
        {
            positionsY.Add(j);
        }
        if (green != null && red != null)
        {
            for (int i = 0; i < 20; i++)
            {
                int positionGreenY = positionsY[Random.Range(0, positionsY.Count)];

                Vector3 positionGreen = new Vector3(positionsX[Random.Range(0,15)], positionGreenY);
                Instantiate(green, positionGreen, Quaternion.identity);

                positionsY.Remove(positionGreenY);

                int positionRedY = positionsY[Random.Range(0, positionsY.Count)];
                Vector3 positionRed = new Vector3(positionsX[Random.Range(0, 15)], positionRedY);
                Instantiate(red, positionRed, Quaternion.identity);

                positionsY.Remove(positionRedY);

            }
        }
        
    }


}