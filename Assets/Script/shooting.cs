using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Shots;
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject tempBullet = Instantiate(Bullet, transform.position,Player.transform.rotation);
            tempBullet.GetComponent<Rigidbody2D>().AddForce(-transform.up * 500f);
        }
    }
}
