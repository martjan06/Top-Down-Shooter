using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthplayer : MonoBehaviour
{
    public int health = 10;
    public int playerhealth;
    public bool myplayer = true;
    public GameObject player;
    void Start()
    {
        playerhealth = health;
    }

    public void PlayerTakesDamage(int damage)
    {
        if (gameObject.tag == "Enemy")
        {
            playerhealth = playerhealth - damage;
            if (playerhealth <= 0)
            {
                Debug.Log("dead");
                myplayer = false;
                Destroy(player);
            }
        }
    }
}
