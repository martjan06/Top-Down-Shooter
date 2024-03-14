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
            rb.AddForce(Vector2.up * 10);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * 10);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * 10);

        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * 10);

        }


    }
}
