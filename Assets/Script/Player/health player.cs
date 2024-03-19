using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthplayer : MonoBehaviour
{
    public int health = 10;
    public int playerhealth;
    public string dead;
    void Start()
    {
        playerhealth = health;
    }

    public void PlayerTakesDamage(int damage)
    {
        playerhealth -= damage;
        if (playerhealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(dead);
        }
    }
}
