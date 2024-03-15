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
            collision.gameObject.GetComponent<zombiehealthbaby>().TakeDamage(1);
            Destroy(Bullet);
        }
        Destroy(gameObject);

        if (collision.collider.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<zombiehealthnormal>().TakeDamage(1);
            Destroy(Bullet);
        }
        Destroy(gameObject);

        if (collision.collider.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<zombiehealthbig>().TakeDamage(1);
            Destroy(Bullet);
        }
        Destroy(gameObject);
    }
}
