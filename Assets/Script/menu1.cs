using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu1 : MonoBehaviour
{
    public string Menu1;
    public void ChangeScene()
    {
        SceneManager.LoadScene(Menu1);
    }
}
