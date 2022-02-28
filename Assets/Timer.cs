using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private float terrainEntered;
    private bool terrain1;
    private bool terrain2;
    private bool terrain3;
    private bool terrain4;
    private bool terrain5;
    // Start is called before the first frame update
    void Start()
    {
        terrain1 = terrain2 = terrain3 = terrain4 = terrain5 = false;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

        if(terrain1 && terrain2 && terrain3 && terrain4 && terrain5)
        {
            timerText.text = "Game over YOU WIN!!!";
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Terrain1")
        {
            terrain1 = true;
        }
        if(other.gameObject.name == "Terrain2")
        {
            terrain2 = true;
        }
        if(other.gameObject.name == "Terrain3")
        {
            terrain3 = true;
        }
        if(other.gameObject.name == "Terrain4")
        {
            terrain4 = true;
        }
        if(other.gameObject.name == "Terrain5")
        {
            terrain5 = true;
        }
    }
}
