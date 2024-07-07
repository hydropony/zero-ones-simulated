using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown: MonoBehaviour {
    public float timeRemaining = 150;
    public bool isCountingDown = false;
    public Text countText;

    public void Start()
    {
        isCountingDown = true;
        timeRemaining = 150;
    }

    public void Update() {
        if (isCountingDown) {
            if (timeRemaining > 0) {
                timeRemaining -= Time.deltaTime;
                updateTimer(timeRemaining);
            }
            else {
                timeRemaining = 0;
                isCountingDown = false;
            }
        }
    }

    void updateTimer(float currentTime) {
        currentTime += 1;

        float minutes = (int)(currentTime / 60);
        float seconds = (int)(currentTime % 60);

        // countText.text = $"{minutes}:{seconds}";
        countText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}