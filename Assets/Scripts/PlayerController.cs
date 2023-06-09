using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidBody;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;
    public Joystick joystick;

    private bool isJumping;
    private bool isGrounded;
    private float horiz;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horiz = joystick.Horizontal;
    }

    public void Jump()
    {
        if (!isJumping && isGrounded)
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(movementSpeed * horiz, rigidBody.velocity.y);

        if (isJumping)
        {
            isJumping = false;
            rigidBody.AddForce(new Vector2(0, jumpForce * 10));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;

        }
    }
}
