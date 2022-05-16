using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement Character
    public float moveSpeed;
    public VariableJoystick joystick;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    //Jumping Character
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void MyInput()
    {
        //  MOVEMENT  //
        //rb.velocity = new Vector2(rb.velocity.x, moveSpeed);
        float x = joystick.Horizontal;
        //float y = joystick.Vertical;

        moveVelocity = new Vector2(x, 0);

        //  JUMP  //
         if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            Debug.Log("Lompat");
        }

        /*if(Input.GetMouseButtonUp(0))
        {

        }*/
    }
    

    void Movement()
    {
        //MOVEMENT SPEED
        rb.velocity = moveVelocity * moveSpeed;


        //Character jadi terbalik
        /*if(rb.velocity != Vector2.zero)
        {
            transform.up = rb.velocity;
        }*/
    }
     
}

