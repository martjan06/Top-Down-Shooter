using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiehealthbaby : MonoBehaviour
{
    public int maxhealth = 1;
    public int currenthealth;
    void Start()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage(int amount)
    {
        currenthealth -= amount;
        if (currenthealth <= 0 )
        {
            Destroy(gameObject);
        }
    }
}
