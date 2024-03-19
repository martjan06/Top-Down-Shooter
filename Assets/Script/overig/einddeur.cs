using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class einddeur : MonoBehaviour
{
    public string end;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Deur")
        {
            SceneManager.LoadScene(end);
        }
    }
}
 