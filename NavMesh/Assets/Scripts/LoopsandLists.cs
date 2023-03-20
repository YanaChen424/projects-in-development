using System;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class LoopsandLists : MonoBehaviour
{
    int[] numbers = new int[4] { 10, 15, 20, 25 };
    // Start is called before the first frame update
    void Start()
    {
        //int[] arr = new int[4] { 1, 2, 3,4 };
        //int i = 1;
        //int max = arr[0];
        //while(i < arr.Length)
        //{
        //    if (arr[i] > max)
        //    {
        //        max = arr[i];
        //    }
        //    i++;
        //}
        //print(max);
        // int[] ages=new int[5] {78,56,27,19,12};
        // float avarage;
        // int sum=0;
        //for(int i=0;i<ages.Length;i++)
        // {
        //     sum+=ages[i];

        // }
        //avarage=sum/ages.Length;
        // print(avarage);

        // List<int> numbers2=new List<int>();
        // numbers2.Add(6);
        // numbers2.RemoveAt(6);
        List<Vector3> vector3List = new List<Vector3>()
        {
            new Vector3(5, 1, 3),
            new Vector3(15, 6, 334),
            new Vector3(-20, 3, 12),
            new Vector3(0, 11, 2)
        };
        Vector3 maxVector = new Vector3();
        maxVector =  GetTheMaxRight(vector3List);
        print(maxVector);
    }
    Vector3 GetTheMaxRight(List<Vector3> list)
    {
        float maxX = list[0].x;
        int maxIndex = 0;
        for (int i = 1; i < list.Count; i++)
        {
            if (maxX < list[i].x)
            {
                maxX = list[i].x;
                maxIndex = i;
            }
        }
        return list[maxIndex];
    }
}
