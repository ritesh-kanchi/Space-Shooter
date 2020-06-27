using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

    public void Start()
    {
        Cursor.visible = true;
    }

    public void LoadLevel()
    {
        Cursor.visible = false;
        SceneManager.LoadScene("Gun");
    }
}
