using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject Bullet;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Object" || collision.gameObject.tag == "Wall")
        {
            Destroy(Bullet);
        }
        
    }
}
