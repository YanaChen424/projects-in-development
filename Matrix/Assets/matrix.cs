using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class matrix : MonoBehaviour
{
    //int[,] theMatrix = new int[2, 2];
    float[,] theMatrix = new float[6, 5];
    // Start is called before the first frame update
    void Start()
    {
        //theMatrix[0, 0]=10;
        //theMatrix[0, 1]=15;
        //theMatrix[1, 0]=20;
        //theMatrix[1, 1]=25;

        for(int row=0;row<6;row++)
        {
            for(int col=0;col<5;col++)
            {
                theMatrix[row,col] = Random.Range(1f,100f);
                print($"the pos in row:{row} and in col:{col} is {theMatrix[row, col]}");
            }
        }
        print(avrageMatrix(theMatrix));
    }
    float avrageMatrix(float[,] theMatrix)
    {
        float sum = 0;
        float avrage = 0;
        for (int row = 0; row < 6; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                sum += theMatrix[row,col];
            }
        }
        return avrage=sum/theMatrix.Length;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
