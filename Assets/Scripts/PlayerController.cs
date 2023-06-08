using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidBody;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;
    private bool isJumping;
    private float horiz;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horiz = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && !isJumping)
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
}
