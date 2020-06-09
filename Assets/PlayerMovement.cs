using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator;

    public Vector2 movement;

    public int playerDirection;

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        IdleDirection();

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void IdleDirection()
    {

        if (movement.x > 0)
        {
            animator.SetFloat("State", .75f);
            playerDirection = 0;
        }
        else if (movement.x < 0)
        {
            animator.SetFloat("State", .5f);
            playerDirection = 1;
        }
        else if (movement.y > 0)
        {
            animator.SetFloat("State", 1f);
            playerDirection = 2;
        }
        else if (movement.y < 0)
        {
            animator.SetFloat("State", 0f);
            playerDirection = 3;
        }
    }


}
