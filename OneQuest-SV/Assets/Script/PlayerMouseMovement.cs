using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouseMovement : MonoBehaviour
{

    float moveSpeed;

    private Coroutine coroutine;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            if (Physics.Raycast(ray, out hitPoint)&& hitPoint.collider)
            {
                if(coroutine != null) StopCoroutine(coroutine);
                coroutine=StartCoroutine(PlayerMoveTowards(hitPoint.point));
                targetPosition = hitPoint.point;
            }
        }
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
            transform.position = destination;
            yield return null;
        }
    }



    //void PlayerMove()
    //{
    //    xAxis = Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;
    //    zAxis = Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime;
    //    //     (0,0,1)                          (1,0,0)
    //    v = transform.forward * zAxis + transform.right * xAxis;
    //    cc.Move(v * moveSpeed * Time.deltaTime);
    //}
}
