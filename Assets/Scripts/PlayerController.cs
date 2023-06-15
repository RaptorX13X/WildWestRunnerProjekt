using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;

    private int desiredLane = 1; //0:left 1:middle 2:right
    public float laneDistance = 4; //the distance between two lanes

    public float jumpForce;
    public float downForce;
    public float Gravity = -20;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private int jumpCounting;

    public bool isJumping = false;

    void Start()
    {
        //controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //direction.z = forwardSpeed;

        Vector3 move = transform.position += transform.forward * forwardSpeed * Time.deltaTime;

        //direction.y += Gravity * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCounting < 1)
        {
            jumpCounting++;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;


        }


        if (Input.GetKeyDown(KeyCode.DownArrow) && jumpCounting > 0)
        {
            jumpCounting--;
            rb.AddForce(Vector3.down * downForce, ForceMode.Impulse);
        }


        //Gather the inputs on which lane we should be

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
            ChangeLine();

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;

            ChangeLine();

            //Calculate where we should be in the future

        }

       
    }

    private void ChangeLine()
    {
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        //controller.enabled = false;
        transform.position = targetPosition;
        //controller.enabled = true;
    }

    //private void FixedUpdate()
    //{
    //    controller.Move(direction * Time.fixedDeltaTime);
    //}

    //private void Jump()
    //{
    //    direction.y = jumpForce;
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCounting = 0;
            Debug.Log("ground");
            isJumping= false;
        }
    }

    public bool IsJumping() // Dziêki tej metodzie mogê odwo³aæ siê do PlayerAnimator.cs.
    {
        return isJumping; // Metoda zwraca wynik isWalking.
    }
}

