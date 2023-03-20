using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static float RandomNumBetweenAB(float a,float b)
    {
        float c;
        return c=Random.Range(a,b);
    }
}
