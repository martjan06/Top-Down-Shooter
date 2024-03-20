using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class einddeur : MonoBehaviour
{
    public string end;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deur")
        {
            SceneManager.LoadScene(end);
        }
    }
}
 