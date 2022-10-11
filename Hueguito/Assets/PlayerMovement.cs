using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxVelocity = 5f;
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
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() 
    {
        //Physics
        rb.MovePosition(rb.position + movement * maxVelocity * Time.fixedDeltaTime);
        
    }
}
