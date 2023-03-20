using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Checkers : MonoBehaviour
{
    [SerializeField]
    GameObject[,] cube = new GameObject[8, 8];
    // Start is called before the first frame update
    void Start()
    {
        for(int row = 0; row < cube.GetLength(0); row++)
        {
            for(int col=0;col<cube.GetLength(1);col++)
            { 
                cube[row,col] =GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube[row,col].transform.position=new Vector3(row,col,0);
                if((row+col)%2==0)
                {
                    cube[row, col].GetComponent<MeshRenderer>().material.color = Color.black;
                }
            }
        }
        //Soldier constructor = new Soldier(color, row, col);
        Soldier[,] b = new Soldier[8,8];
        b[0, 0] = new Soldier("white", 0, 0);
        b[2, 3] = new Soldier("white", 2, 3);
        b[1, 4] = new Soldier("white", 1, 4);
        b[7, 7] = new Soldier("black", 7, 7);

        Soldier temp = new Soldier("white", 2, 3);
        Soldier[] result =ValidMove(b, temp);
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Soldier[] ValidMove(Soldier[,] board, Soldier s)
    {
        if(s.color=="white")
        {
            if(s.col>0&&s.col<7&&s.row>0)
            {
                return new Soldier[2] { board[s.row-1,s.col-1], board[s.row-1,s.col+1] };
            }else if(s.col==0&&s.row>0)
            {
                return new Soldier[1] { board[s.row - 1, s.col + 1]};
            }else if(s.col==7&&s.row>0)
            {
                return new Soldier[1] { board[s.row - 1, s.col - 1] };
            }else //s.row==0
            {
                return null;
            }
        }else
        {
            if (s.col > 0 && s.col < 7 && s.row < 7)
            {
                return new Soldier[2] { board[s.row + 1, s.col - 1], board[s.row + 1, s.col + 1] };
            }
            else if (s.col == 0 && s.row > 7)
            {
                return new Soldier[1] { board[s.row + 1, s.col + 1] };
            }
            else if (s.col == 7 && s.row > 7)
            {
                return new Soldier[1] { board[s.row + 1, s.col - 1] };
            }
            else //s.row==0
            {
                return null;
            }
        }
    }
}