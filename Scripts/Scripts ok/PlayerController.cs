using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;

    public float jumpForce;
    public float gravity;

    private float currentgravity;
    private float currentjumpspeed;
    private float currentspeed;

    public Transform groundcheck;
    public LayerMask Ground;

    public bool doublejump = true;

    void Start()
    {
        currentjumpspeed = jumpForce;
        currentspeed = speed;
        currentgravity = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed;

        bool isGrounded = Physics.CheckSphere(groundcheck.position, 1.5f, Ground);

        direction.y += gravity * Time.deltaTime;

        controller.Move(direction * Time.deltaTime);

        if (isGrounded)
        {
            doublejump = true;
            if (Input.GetButtonDown("Jump"))
            {
                direction.y = jumpForce;
            }
        }
        else
        {
            if (doublejump & Input.GetButtonDown("Jump"))
            {
                direction.y = jumpForce;
                doublejump = false;
            }
        }
        
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch (hit.gameObject.tag)
        {
            case "SpeedBoost":
                speed = 25f;
                break;
            case "JumpPad":
                jumpForce = 25f;
                break;
            case "Change":
                gravity = 13f;
                jumpForce = -10f;
                break;
            case "Back":
                float hInput = Input.GetAxis("Horizontal");
                direction.x = -hInput * speed;
                break;
            case "Ground":
                jumpForce = currentjumpspeed;
                speed = currentspeed;
                gravity = currentgravity;
                break;

        }
    }

}
