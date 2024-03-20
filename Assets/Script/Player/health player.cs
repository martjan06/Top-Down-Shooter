using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthplayer : MonoBehaviour
{

    public int health = 1;
    public int playerhealth;
    public string Scene;
    public TextMeshProUGUI healthtext;
    void Start()
    {
        playerhealth = health;
    }
    public void Update()
    {
        healthtext.text = playerhealth.ToString();
        Debug.Log(playerhealth);
    }
    public void PlayerTakesDamage(int damage)
    {
        playerhealth -= damage;
        if (playerhealth <= 0)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
