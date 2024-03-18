using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpickup : MonoBehaviour
{
    int extrahealth = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<healthplayer>().playerhealth += extrahealth;
            Destroy(gameObject);
        }
    }
}
