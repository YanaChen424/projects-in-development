using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    NavMeshAgent agent;
    public string answer;
    bool selectedRightChoise;
    bool selectedWrongChoise;
    public GameObject answerSelect;
    public GameObject wrongScreen;
    CharacterController cc;
    float xAxis;
    float zAxis;
    float moveSpeed;
    Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cc = GetComponent<CharacterController>();
        //speed = 30f;
        selectedRightChoise = true;
        selectedWrongChoise = true;
        moveSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        //{
        //    Vector3 move = new Vector3(1, 0, 0)* Input.GetAxis("Horizontal");
        //    cc.Move(move * Time.deltaTime * speed);
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        //{
        //    Vector3 move = new Vector3(-1, 0, 0)* Input.GetAxis("Horizontal");
        //    cc.Move(move * Time.deltaTime * speed);
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        //{
        //    Vector3 move = new Vector3(0, 0, 1);
        //    cc.Move(move * Time.deltaTime * speed);
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        //{
        //    Vector3 move = new Vector3(0, 0, -1);
        //    cc.Move(move * Time.deltaTime * speed);
        //}ed * Time.deltaTime);

        PlayerMove();

        if (agent.enabled && agent.remainingDistance == 0)
        {
            agent.enabled = false;
        }
        if (Input.GetMouseButton(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            if (Physics.Raycast(ray, out hitPoint))
            {
                agent.enabled = true;
                agent.SetDestination(hitPoint.point);
            }
            if (Physics.Raycast(ray, out hitPoint, 100f))
            {
                if (hitPoint.transform != null)
                {
                    //Our custom method. 
                    CurrentClickedGameObject(hitPoint.transform.gameObject);
                }

            }
        if(answer=="108"&&selectedRightChoise==true)
            {
                print("good job");
                selectedRightChoise = false;
            }
        if(answer != "108" && answer!=null && answer!="" && selectedWrongChoise)
            {
                print(answer);
                selectedWrongChoise = false;
                StartCoroutine(WaitTime());



            }
    }
}

    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if (gameObject.tag == "yellow")
        {
            answerSelect.SetActive(true);
            
        }
    }

    private IEnumerator WaitTime()
    {
        wrongScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        wrongScreen.SetActive(false);
        selectedRightChoise = true;
        selectedWrongChoise = true;
    }
    void PlayerMove()
    {
        xAxis = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        zAxis = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        //     (0,0,1)                          (1,0,0)
        v = transform.forward * zAxis + transform.right * xAxis;
        cc.Move(v * moveSpeed * Time.deltaTime);
    }
}
