using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float accelForce = 10f;

    private new Rigidbody2D rigidbody;
    public float speed = 1.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // wanted to use "if (Input.GetAxisRaw("Horizontal") > 0);" but I don't know how

         if(Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity = new Vector2(+speed, rigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
        }
        else
        { //gravity
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }

            if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rigidbody.velocity = Vector2.up * jumpVelocity;
        }
    }

}
