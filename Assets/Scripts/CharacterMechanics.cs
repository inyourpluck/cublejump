using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class CharacterMechanics1 : MonoBehaviour
{
    //private MobileController mContr;
    public float speedMove;
    public float jumpPower;
    private float gravityForce;
    private Vector3 moveVector;
    public float speed = 5f;
    private Transform _rotator;
    public Vector3 coordin;

    private CharacterController ch_controller;

    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        _rotator = GetComponent<Transform>();
        //mContr = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        GamingGravity();
        _rotator.Rotate(0, speed * Time.deltaTime, 0);
    }

    private void CharacterMove()
    {
        moveVector = Vector3.zero;
       // moveVector.x = mContr.Horizontal() * speedMove;
       // moveVector.z = mContr.Vertical() * speedMove;

        moveVector.y = gravityForce;

        ch_controller.Move(moveVector * Time.deltaTime);
    }


    private void GamingGravity()
    {
        if (!ch_controller.isGrounded) gravityForce -= 80f * Time.deltaTime;

        else gravityForce = -1f;

        if (ch_controller.isGrounded)
        {
            if (_rotator.position.y > coordin.y)
            {
                coordin.y = _rotator.position.y;
            }
            gravityForce = jumpPower;
        }
    }
}
