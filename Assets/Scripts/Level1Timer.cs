using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1Timer : MonoBehaviour { 

    public bool timerRunning;
    public float currentTime;
    public float maxTime = 240;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            currentTime -= Time.deltaTime;
            timerText.text = DisplayTime(currentTime);
            if (currentTime <= 0)
            {
                timerRunning = false;
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    string DisplayTime(float time)
    {
        string text;
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        return text = string.Format("Time Left: {0:00}:{1:00}", minutes, seconds);
    }
}
