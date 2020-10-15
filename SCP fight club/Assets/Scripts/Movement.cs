using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float accelForce = 10f;

    [SerializeField]
    private float speed = 1.0f;

    private new Rigidbody2D rigidbody;

<<<<<<< HEAD
    public bool isPlayer2 = false;
    public bool isPlayer1 = false;
=======
>>>>>>> master

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // wanted to use "if (Input.GetAxisRaw("Horizontal") > 0);" but I don't know how
<<<<<<< HEAD
        //for player 1
        if ((Input.GetKey(KeyCode.RightArrow) && isPlayer1 == true)||(Input.GetKey(KeyCode.D) &&  isPlayer2 == true))
        {
            rigidbody.velocity = new Vector2(+speed, rigidbody.velocity.y);
        }
        else if ((Input.GetKey(KeyCode.LeftArrow) && isPlayer1 == true) || (Input.GetKey(KeyCode.A) &&  isPlayer2 == true))
=======
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity = new Vector2(+speed, rigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
>>>>>>> master
        {
            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
        }
        else
        { //gravity
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }
<<<<<<< HEAD
        if ((Input.GetKeyDown(KeyCode.UpArrow) &&  isPlayer1 == true) || (Input.GetKeyDown(KeyCode.W) &&  isPlayer2 == true))
        {
            rigidbody.velocity = Vector2.up * accelForce * speed;
        }
        
    }

}
=======
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * accelForce * speed;
        }
    }

}
>>>>>>> master
