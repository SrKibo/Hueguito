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
    public float speed = 4f;
    
    public Rigidbody2D rb;
    public Vector2 movement, lastMovement;
    public Animator animator;
    public SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
        
        
        // Animator parameters

        animator.SetFloat("Speed", rb.velocity.sqrMagnitude);
        if(movement.sqrMagnitude > 0f)
        {
            lastMovement = movement;
        }

        animator.SetFloat("Horizontal", lastMovement.x);
        animator.SetFloat("Vertical", lastMovement.y);
        // animator.SetBool("IsMoving", directionKeyPressed);
    }
    
    void FixedUpdate() 
    {
        rb.velocity = movement * speed;
    }
}
