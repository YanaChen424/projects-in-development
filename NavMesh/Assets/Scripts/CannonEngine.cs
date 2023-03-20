using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonEngine : MonoBehaviour
{
    [SerializeField] Transform PlayerPos;
    [SerializeField] GameObject missile;
    [SerializeField] Transform ShootPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,PlayerPos.position)<=5)
        {
            transform.LookAt(PlayerPos);
            Instantiate(missile, ShootPoint.position, missile.transform.localRotation);
        }

    }
}
