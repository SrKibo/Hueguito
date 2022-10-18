using System.ComponentModel;
using System.Timers;
using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5f, speed = 0, acceleration = 10f, deceleration = 10f;
    public bool directionKeyPressed = false;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Animator animator;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        if(movement.x != 0 || movement.y != 0)
        {
            directionKeyPressed = true;
        }
        else
        {
            directionKeyPressed = false;
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetBool("IsMoving", directionKeyPressed);
    }
//  ______     ______     ______     ______     __         ______     ______     ______     ______   __     ______     __   __    
// /\  __ \   /\  ___\   /\  ___\   /\  ___\   /\ \       /\  ___\   /\  == \   /\  __ \   /\__  _\ /\ \   /\  __ \   /\ "-.\ \   
// \ \  __ \  \ \ \____  \ \ \____  \ \  __\   \ \ \____  \ \  __\   \ \  __<   \ \  __ \  \/_/\ \/ \ \ \  \ \ \/\ \  \ \ \-.  \  
//  \ \_\ \_\  \ \_____\  \ \_____\  \ \_____\  \ \_____\  \ \_____\  \ \_\ \_\  \ \_\ \_\    \ \_\  \ \_\  \ \_____\  \ \_\\"\_\ 
//   \/_/\/_/   \/_____/   \/_____/   \/_____/   \/_____/   \/_____/   \/_/ /_/   \/_/\/_/     \/_/   \/_/   \/_____/   \/_/ \/_/ 
                                                                                                                               
    //     if(directionKeyPressed){
    //         if(movement.x < 0)
    //             speed = speed - acceleration * Time.deltaTime;
    //         else if(movement.x > 0)
    //             speed = speed + acceleration * Time.deltaTime;
    //     }
    //     else {
    //         if(speed > deceleration * Time.deltaTime){
    //             speed = speed - deceleration * Time.deltaTime;
    //         }
    //         else if(speed < deceleration * Time.deltaTime){
    //             speed = speed + deceleration * Time.deltaTime;
    //         }
    //         else speed = 0;
    //     }
    // }

// var Speed        : float = 0;//Don't touch this
// var MaxSpeed     : float = 10;//This is the maximum speed that the object will achieve
// var Acceleration : float = 10;//How fast will object reach a maximum speed
// var Deceleration : float = 10;//How fast will object reach a speed of 0

// function Update () {
// if ((Input.GetKey ("left"))&&(Speed < MaxSpeed))
//     Speed = Speed - Acceleration  Time.deltaTime;
// else if ((Input.GetKey ("right"))&&(Speed > -MaxSpeed))
//     Speed = Speed + Acceleration  Time.deltaTime;
// else
// {
//     if(Speed > Deceleration  Time.deltaTime)
//         Speed = Speed - Deceleration  Time.deltaTime;
//     else if(Speed < -Deceleration  Time.deltaTime)
//         Speed = Speed + Deceleration  Time.deltaTime;
//     else
//         Speed = 0;
// }
    
    void FixedUpdate() 
    {
        //Physics
        rb.MovePosition(rb.position + movement * movement.magnitude * Time.fixedDeltaTime);
        // rb.MovePosition(rb.position + movement * Math.Abs(speed) * Time.fixedDeltaTime);
        
    }
}
