using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidBody;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;

    private PlayerInputActions inputActions;

    private bool isJumping;
    private bool isGrounded;
    private float horiz;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Player.Movement.Enable();
    }

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horiz = inputActions.Player.Movement.ReadValue<float>();
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
        if (collision.gameObject.CompareTag("Ground")|| collision.gameObject.CompareTag("Paper"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Paper") && !collision.gameObject.GetComponent<PaperClue>().Once)
        {
            InGameManager.Instance.Values.Add(collision.gameObject.GetComponent<PaperClue>().Value);
            collision.gameObject.GetComponent<PaperClue>().Once = true;
            InGameManager.Instance.Validation();
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
