using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 20f;
    public Rigidbody2D rb;

    public PlayerMovement script;


    void Start()
    {
        script = GameObject.FindObjectOfType<PlayerMovement>();

        if (script.playerDirection == 0)
        {
            rb.velocity = transform.right * speed;
        } else if (script.playerDirection == 1)
        {
            rb.velocity = -transform.right * speed;
        }
        else if (script.playerDirection == 2)
        {
            rb.velocity = transform.up * speed;
        }
        else if (script.playerDirection == 3)
        {
            rb.velocity = -transform.up * speed;
        }
    }

    void Update()
    {

    }
}
