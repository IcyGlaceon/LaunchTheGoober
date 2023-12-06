using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    float horizontal;
    [SerializeField] public float speed = 8f;
    [SerializeField] private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private float horizontalSpeed = 2f;

    [SerializeField] Transform playerStartTransform;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask wallLayer;

    [SerializeField] private Animator animator;

    public Scene activeScene;

    private void Update()
    {
        activeScene = SceneManager.GetActiveScene();

       /* if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }*/

        if(Input.GetMouseButtonDown(0) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

        //animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Vector2 movement = new Vector2(horizontal * horizontalSpeed, rb.velocity.y);

        rb.velocity = Vector2.Lerp(rb.velocity, movement, 1);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
                
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    public bool facingRight()
    {
        return isFacingRight;
    }

    public float JumpingPower()
    {
        return jumpingPower;
    }
}
