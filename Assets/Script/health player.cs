using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthplayer : MonoBehaviour
{
    public int health = 10;
    public int playerhealth;
    void Start()
    {
        playerhealth = health;
    }

    public void PlayerTakesDamage(int damage)
    {
        if (gameObject.tag == "Enemy")
        playerhealth = playerhealth - damage;
    }
}
