using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isgrounded;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * 8);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * 8);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * 8);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * 8);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.down * 8);

        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
