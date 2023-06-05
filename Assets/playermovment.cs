using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public float speed = 2.5f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float runSpeed = 3.5f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    public Animator anm;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    void Update()
    {
        if (controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
           
            if (Input.GetKey(KeyCode.RightShift))
            {
                moveDirection = moveDirection * runSpeed;
            }
            else
            {
                moveDirection = moveDirection * speed;
            }
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);


        Vector3 temp = moveDirection;
        temp.y = 0;
        anm.SetFloat("speed", temp.magnitude);



    }
}
