using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float accelForce = 10f;

    [SerializeField]
    private float speed = 1.0f;

    private new Rigidbody rigidbody;

    public Animator animator;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        // wanted to use "if (Input.GetAxisRaw("Horizontal") > 0);" but I don't know how
        //for player 1
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            rigidbody.velocity = new Vector2(+speed, rigidbody.velocity.y);
            animator.SetInteger("walking", 1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
            animator.SetInteger("walking", -1);
        }
        else
        { //gravity
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
            animator.SetInteger("walking", 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            rigidbody.velocity = Vector2.up * accelForce * speed;
        }
        
    }

}