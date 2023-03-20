using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class ex4 : MonoBehaviour
{
    List<int> numList = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        int amount = 10;
        numList = NumList2(20, 1, amount);

        
 
        MoveByNumInList(numList);
        StartCoroutine(Steps(numList));

    }

    static List<int> NumList2(int max, int min, int amount)
    {
        List<int> numList = new List<int>();
        for (int i = 0; i < amount; i++)
        {
            numList.Add(GetNotRepetedNum(max, min, numList));
        }
        return numList;
    }
    private static int GetNotRepetedNum(int max, int min, List<int> numList)
    {

        while (true)
        {
            int num = Random.Range(max, min);
            bool resultOfTheSame = IsThisNumberAlreadyExsist(num, numList);
            if (!resultOfTheSame)
            {
                return num;
            }
        }
    }

    private static bool IsThisNumberAlreadyExsist(int num, List<int> numList)
    {
        for (int i = 0; i < numList.Count; i++)
        {
            if (numList[i] == num)
            {
                return true;
            }
        }
        return false;
    }

    private static void MoveByNumInList(List<int> numList)
    {
        int num;
        for(int i = 0; i < numList.Count-1; i++)
        {
            for (int j = 0; j < numList.Count - i-1; j++)
            {
                if (numList[j] > numList[j + 1])
                {
                    num = numList[j + 1];
                    numList[j + 1] = numList[j];
                    numList[j] = num;
                }
            }

        }

        for (int i = 0; i < numList.Count; i++)
        {
            print(numList[i]);
        }
    }

    IEnumerator Steps(List<int> numList)
    {
        for (int i = 0; i < numList.Count; i++)
        {
            transform.position = transform.position + new Vector3(0, numList[i], 0);
            print("new position added is:" + numList[i].ToString());
            yield return new WaitForSeconds(3f);
        }
        

    }
    // Update is called once per frame
    void Update()
    {


    }
}
