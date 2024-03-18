using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiehealthbig : MonoBehaviour
{
    public int maxhealth = 3;
    public int currenthealth;
    void Start()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage2(int amount)
    {
        currenthealth -= amount;
        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
