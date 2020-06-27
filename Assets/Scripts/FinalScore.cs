using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public static int score;
    // Use this for initialization
    void Start()
    {
        GetComponent<Text>().text = "Score: " + Score.score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
