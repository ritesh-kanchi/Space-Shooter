using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
