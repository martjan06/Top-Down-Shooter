using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylopen : MonoBehaviour
{

    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 2f;

    private int waypointIndex = 0;

    private bool chase = false;
    void Start()
    {
        //transform.position = waypoints[waypointIndex].transform.position;
    }

    void Update()
    {
        
        if (chase == false)
        {
            Move();
        }
        else if (chase == true)
        {
            Chase();
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

    }
}
