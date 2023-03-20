using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exceptions : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            GoRight("player");
        }
        catch
        {
            Debug.Log("error");
        }
        print("Finish");

        try
        {
            AgeCheck(160);
        }
        catch(System.Exception e)
        {
            Debug.Log("too old you're dead!");
        }

        try
        {
            AgeCheck(-12);
        }
        catch (System.Exception e)
        {
            Debug.Log("wait till you're born");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoRight(string nameOfObject)
    {
        GameObject temp = GameObject.Find(nameOfObject);
        temp.transform.position = temp.transform.position +  new Vector3(1, 0, 0);
    }
    public void AgeCheck(int age)
    {
        if(age>120)
        {
            throw new System.Exception("too old you're dead!");
        }else if(age<0)
        {
            throw new System.Exception("wait till you're born");
        }
        
    }
}
