using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameController : MonoBehaviour
{
    public GameObject Timer;

    private TimerController TimerController;

    // Start is called before the first frame update
    void Start()
    {
        this.TimerController = this.Timer.GetComponent<TimerController>();
    }

    public void StartGame()
    {
        this.TimerController.IsTimerRunning = true;
    }
}
