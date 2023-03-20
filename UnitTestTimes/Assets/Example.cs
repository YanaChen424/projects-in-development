using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Sum(5, 5);
        Sum(-10, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static int Sum(int num1,int num2)
    {
        return num1 + num2;
    }
    public void MoveTo(Vector3 v)
    {
        transform.position = v;
    }
    public void ChangeActive()
    {
        
        gameObject.SetActive(!gameObject.active);
    }
}
