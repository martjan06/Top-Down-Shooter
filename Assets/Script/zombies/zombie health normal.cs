using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiehealthnormal : MonoBehaviour
{
    public int maxhealth = 2;
    public int currenthealth;
    void Start()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage1(int amount)
    {
        currenthealth -= amount;
        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
