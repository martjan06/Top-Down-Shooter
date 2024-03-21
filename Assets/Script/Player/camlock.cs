using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camlock : MonoBehaviour
{
    public GameObject Player;
    private void Update()
    {
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y,-10f);
    }
}
