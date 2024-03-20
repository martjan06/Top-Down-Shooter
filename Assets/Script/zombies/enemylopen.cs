using System.Collections;
using System.Collections.Generic;
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
    void Start()
    {
        //transform.position = waypoints[waypointIndex].transform.position;
    }

    void Update()
    {
        
        if (Vector3.Distance(transform.position, Player.position) <= afstand)
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

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 2f);
        Debug.DrawRay(transform.position, Vector2.right * 2f, Color.blue);

        // checkt welke angle correct is
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // draait naar de juiste angle
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 90));
        return;
    }
}
