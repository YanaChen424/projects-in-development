using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnTime : MonoBehaviour
{
    public GameObject G;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        //currentTime = 0;

        //InvokeRepeating("HelloWorld", 0, 5);
        //StartCoroutine(RepeatingFunc());
        StartCoroutine(ChangeColor(new Color[3] { Color.blue, Color.red, Color.gray }, 2, G));
    }

    // Update is called once per frame
    void Update()
    {
        //if(currentTime+5<Time.time)
        //{
        //    print(Time.time);
        //    currentTime=Time.time;
        //    print("Hello World");
        //}
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke();
        }
    }
    void HelloWorld()
    {
        print(Time.time);
        print("Hello World");
    }

    IEnumerator RepeatingFunc()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(3);
            print(Time.time);
        }
    }

    IEnumerator ChangeColor(Color[] colorList, int time, GameObject temp)
    {
        for (int i = 0; i < colorList.Length; i++)
        {
            temp.GetComponent<Renderer>().material.color = colorList[i];
            yield return new WaitForSeconds(time);

        }
    }
}
