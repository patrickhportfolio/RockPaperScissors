using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float StartingTime = 5;

    public Text CountdownText;

    public bool IsTimerRunning;

    private float TimeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        // this.IsTimerRunning = true;
        this.TimeRemaining = this.StartingTime;
        this.CountdownText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTimerRunning)
        {
            this.CountdownText.gameObject.SetActive(true);

            // Subtract the time between each frame
            this.TimeRemaining -= Time.deltaTime;

            if (this.TimeRemaining <= 0)
            {
                this.IsTimerRunning = false;

                // Set time to 0 so it's pretty
                this.TimeRemaining = 0;
            }

            // Round down the time so that it looks pretty
            this.CountdownText.text = $"{Mathf.FloorToInt(this.TimeRemaining)} seconds remaining!";
        }
    }
}
