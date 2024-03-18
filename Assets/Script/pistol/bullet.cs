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

        if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(Bullet);
            collision.gameObject.GetComponent<zombiehealthbaby>().TakeDamage(1);
        }

        if (collision.collider.gameObject.tag == "enemy1")
        {
            Destroy(Bullet);
            collision.gameObject.GetComponent<zombiehealthnormal>().TakeDamage1(1);
        }

        if (collision.collider.gameObject.tag == "enemy2")
        {
            Destroy(Bullet);
            collision.gameObject.GetComponent<zombiehealthbig>().TakeDamage2(1);
        }
    }
}
