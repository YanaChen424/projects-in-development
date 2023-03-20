using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFunc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start");
    }
    private void Awake()
    {
        print("Awake");
    }
    private void OnEnable()
    {
        print("OnEnable");
    }
    private void OnDisable()
    {
        print("OnDisable");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
