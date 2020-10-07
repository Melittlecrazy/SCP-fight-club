using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    public float speed = 1.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveSidetoSide = Input.GetAxis("Horizontal");
        Vector2 inputDirection = new Vector2(moveSidetoSide, 5 * speed);
        rigidbody.AddForce(inputDirection * speed);

        if (Input.GetKey(Space)) ;
    }
}
