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
            timerText.text = "Time Remaining: " + System.Math.Round(currentTime);
            if (currentTime <= 0)
            {
                timerRunning = false;
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
