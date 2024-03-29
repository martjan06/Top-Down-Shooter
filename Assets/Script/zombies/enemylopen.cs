using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemylopen : MonoBehaviour
{

    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 5f;

    private int waypointIndex = 0;

    public Transform Player;

    public float afstand;

    public LayerMask layermask;
    void Start()
    {
        //transform.position = waypoints[waypointIndex].transform.position;
    }


    void Update()
    {
        RaycastHit2D hitfront = Physics2D.Raycast(transform.position, transform.up, 8.0f);
        Debug.DrawRay(transform.position, transform.up * 8.0f, Color.blue);

        RaycastHit2D hitfront1 = Physics2D.Raycast(transform.position, -transform.up, 8.0f);
        Debug.DrawRay(transform.position, -transform.up * 8.0f, Color.blue);

        RaycastHit2D hitfront2 = Physics2D.Raycast(transform.position, transform.right, 8.0f);
        Debug.DrawRay(transform.position, transform.right * 8.0f, Color.blue);

        RaycastHit2D hitfront3 = Physics2D.Raycast(transform.position, -transform.right, 8.0f);
        Debug.DrawRay(transform.position, -transform.right * 8.0f, Color.blue);

        if (hitfront.collider != null && hitfront.collider.gameObject.tag == ("Player"))
        {
            Chase();
        }
        else if (hitfront1.collider != null && hitfront1.collider.gameObject.tag == ("Player"))
        {
            Chase();
        }
        else if (hitfront2.collider != null && hitfront2.collider.gameObject.tag == ("Player"))
        {
            Chase();
        }
        else if (hitfront3.collider != null && hitfront3.collider.gameObject.tag == ("Player"))
        {
            Chase();
        }
        else
        {
            Move();
        }
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position,
        waypoints[waypointIndex].transform.position,
        moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }

        if (waypointIndex == waypoints.Length)
            waypointIndex = 0;
    }
    void Chase()
    {
        // roteert naar de variable target positie met bepaalde snelheid
        transform.position = Vector3.MoveTowards(transform.position, Player.position, 5f * Time.deltaTime);
        Vector2 direction = Player.position - transform.position;

        // checkt welke angle correct is
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // draait naar de juiste angle
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 90));
        return;
    }
}
