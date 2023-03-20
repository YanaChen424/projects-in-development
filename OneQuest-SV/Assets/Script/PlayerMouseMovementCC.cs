using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class PlayerMouseMovementCC : MonoBehaviour
{

    float moveSpeed;

    private Coroutine coroutine;
    private Vector3 targetPosition;
    private CharacterController characterController;

    //gravity
    public bool isGround;
    float radius;
    public LayerMask groundLayerMask;
    public Transform groundCheck;
    float gravity;
    Vector3 velocity;

    //player rotation
    float mouseX;
    float mouseY;
    float LookSpeed;
    public Transform cameraTurn;
    float cameraX;

    public GameManager gameManager;

    //green
    public GameObject Panel1;
    public GameObject Panel2;

    public bool start;

    public TextMeshProUGUI coinNumText;
    int coinNum;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();  
        moveSpeed = 10f;

        //gravity
        isGround = false;
        radius = 1f;
        gravity = -9.81f;

        //player rotation
        LookSpeed = 120;
        cameraX = 0;

        start = true;

        coinNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GravityDown();
        PlayerRotation();
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            if (Physics.Raycast(ray, out hitPoint)&& !hitPoint.collider.CompareTag("green")&&Panel1.activeSelf==false&& Panel2.activeSelf == false&&start)
            {
                if(coroutine != null) StopCoroutine(coroutine);
                coroutine=StartCoroutine(PlayerMoveTowards(hitPoint.point));
                targetPosition = hitPoint.point;
            }
            if(Physics.Raycast(ray, out hitPoint,3f)&& hitPoint.collider.CompareTag("green")&& start)
            {
                Panel1.SetActive(true);
                start = false;
            }
        }
    }
    float MyClamp(float stareLoc, float min, float max)
    {
        if (stareLoc < min)
        {
            return min;
        }
        else if (stareLoc > max)
        {
            return max;
        }
        else
        {
            return stareLoc;
        }
    }   
    void GravityDown()
    {
        if (Physics.CheckSphere(groundCheck.position, radius, groundLayerMask))
        {
            isGround = true;

        }
        else
        {
            isGround = false;
        }
        if (isGround == false)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0;
        }
        characterController.Move(velocity * Time.deltaTime);
    }
    
    void PlayerRotation()
    {
        mouseX = Input.GetAxis("Mouse X") * LookSpeed * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * LookSpeed * Time.deltaTime;
        transform.Rotate(0, mouseX, 0);
        //cameraTurn.transform.Rotate(mouseY, 0, 0);
        cameraX -= mouseY;
        cameraX = MyClamp(cameraX, -90, 90);
        cameraTurn.localRotation = Quaternion.Euler(cameraX, 0, 0);
    }
    private void OnEnable()
    {
        
    }
    private IEnumerator PlayerMoveTowards(Vector3 target)
    {
        float playerDistanceToFloor =transform.position.y-target.y;
        target.y+=playerDistanceToFloor;
        while(Vector3.Distance(transform.position, target) > 0.1f)
        {
            Vector3 destination =Vector3.MoveTowards(transform.position, target, moveSpeed*Time.deltaTime);
            //transform.position = destination;
            Vector3 direction =target-transform.position;
            Vector3 movement = direction.normalized * moveSpeed * Time.deltaTime;
            characterController.Move(movement);
            yield return null;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Volcano") && gameManager.GetComponent<GameManager>().thirdPanelStart == false)
        {
            print("Got burn");

        }
        if (other.gameObject.tag == "Coin" && gameManager.GetComponent<GameManager>().thirdPanelStart == true)
        {
            print("got a coin");
            coinNum++;
            coinNumText.text = coinNum.ToString();
            Destroy(other.gameObject);
        }

    }

}
