using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.MoveTowards(transform.position, player.position,Time.deltaTime);
    }
}
