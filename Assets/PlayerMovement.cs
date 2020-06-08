using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator;

    Vector2 movement;

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
        }
        else if (movement.x < 0)
        {
            animator.SetFloat("State", .5f);
        }
        else if (movement.y > 0)
        {
            animator.SetFloat("State", 1f);
        }
        else if (movement.y < 0)
        {
            animator.SetFloat("State", 0f);
        }
    }


}
