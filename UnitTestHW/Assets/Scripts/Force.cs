using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        AddForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddForce()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(0,3,0,ForceMode.Impulse);
        
    }
}
