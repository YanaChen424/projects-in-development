using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    int[] num=new int[4] {1,6,8,9};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Index(new int[] { 1, 6, 8, 9 });
    }
    public static int Index(int[] num)
    {
        int min = num[0];
        int index = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                index = i;
            }
        }

        return index;
        

    }
}
