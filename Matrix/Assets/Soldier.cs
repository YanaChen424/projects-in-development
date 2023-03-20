using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    public string color;
    public int row;
    public int col;

    public Soldier(string color,int row,int col)
    {
        this.row = row;
        this.col = col;
        this.color = color;
    }
// Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
