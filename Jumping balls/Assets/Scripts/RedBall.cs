using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : MonoBehaviour
{
    float xPos;
    float yPos;
    // Start is called before the first frame update
    void Start()
    {
        RandomizePosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RandomizePosition()
    {
        xPos = Random.Range(-8.4f, 8.4f);
        yPos = Random.Range(-4.5f, 4.5f);
        this.transform.position = new Vector3(Mathf.Round(xPos), Mathf.Round(yPos));
    }
}
