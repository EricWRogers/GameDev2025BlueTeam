using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public GameObject character;
    public float moveSpeed = 3.25f;
    public float jumpForce;
    public float doubleJumpForce;
    public int health = 10;
    public Rigidbody2D rb;

    private Vector2 playerInput;
    private bool shouldJump;
    private bool canJump;
    private bool shouldDoubleJump = false;
    private bool canDoubleJump = false;
    private bool shouldDash;
    private bool canDash;
    private bool shouldWallClimb;
    private bool canWallClimb;
    private bool shouldSpeedBoost;
    private bool canSpeedBoost;

    private void Start()
    {
        rb = character.GetComponent<Rigidbody2D>();
    }

    // get input values each frame
    private void Update()
    {
        // using "GetAxis" allows for many different control schemes to work here
        // go to Edit -> Project Settings -> Input to see and change them
        playerInput = new Vector2(Input.GetAxis("Horizontal"), 0.0f);

        if (canJump && Input.GetKeyDown(KeyCode.Space))
        { 
            canJump = false;
            shouldJump = true;
            canDoubleJump = true;
        }
        if (canDoubleJump && Input.GetKeyDown(KeyCode.E))
        {
            canDoubleJump = false;
            shouldDoubleJump = true;
        }
    }

    // apply physics movement based on input values
    private void FixedUpdate()
    {
        // move
        if (playerInput != Vector2.zero)
        {
            rb.AddForce(playerInput * moveSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }

        // jump
        if (shouldJump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            shouldJump = false;
        }
        // dash
        if (shouldDash)
        {
            rb.AddForce(playerInput * jumpForce, ForceMode2D.Impulse);
            shouldDash = false;
        }
        // double jump
        if (shouldDoubleJump)
        {
            rb.linearVelocity = Vector2.up * doubleJumpForce;
            shouldDoubleJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // allow jumping again
        canJump = true;
        character.transform.tag = "onFloor";
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        character.transform.tag = "Jumping";
    }
}