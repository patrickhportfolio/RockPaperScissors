using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Timer;

    public GameObject ElementGroup;

    public Text ComputerChoiceText;

    public Text OutcomeText;

    private TimerController TimerController;

    private bool IsGameOver;

    private bool HasGameStarted;

    private bool? IsPlayerWinner;
    
    // Start is called before the first frame update
    void Start()
    {
        this.TimerController = this.Timer.GetComponent<TimerController>();
        this.ComputerChoiceText.gameObject.SetActive(false);
        this.OutcomeText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.IsGameOver && this.HasGameStarted)
        {
            if (!this.TimerController.IsTimerRunning)
            {
                // Pick a random choice for the computer
                var randomInt = Random.Range(0, 3);
                var randomSelection = string.Empty;
                switch (randomInt)
                {
                    case 0:
                        {
                            randomSelection = "Fire";
                            break;
                        }
                    case 1:
                        {
                            randomSelection = "Grass";
                            break;
                        }
                    case 2:
                        {
                            randomSelection = "Water";
                            break;
                        }
                }

                // Let the player know what the computer chose via UI text
                this.ComputerChoiceText.gameObject.SetActive(true);
                this.ComputerChoiceText.text = $"Computer chose {randomSelection}!";

                // Determine outcome of the game
                this.DetermineOutcome(randomSelection);

                this.IsGameOver = true;
            }
        }
    }

    public void StartGame()
    {
        this.TimerController.IsTimerRunning = true;
        this.HasGameStarted = true;
    }

    private void DetermineOutcome(string randomSelection)
    {
        var playerChoice = this.ElementGroup.GetComponent<ElementSelectController>().PlayerChoice;
        
        // Annoying logic that is difficult to maintain
        if (playerChoice == randomSelection)
        {
            this.IsPlayerWinner = null;
        }
        else if (playerChoice == "Water")
        {
            if (randomSelection == "Grass")
            {
                this.IsPlayerWinner = false;
            }
            else
            {
                this.IsPlayerWinner = true;
            }
        }
        else if (playerChoice == "Grass")
        {
            if (randomSelection == "Fire")
            {
                this.IsPlayerWinner = false;
            }
            else
            {
                this.IsPlayerWinner = true;
            }
        }
        else if (playerChoice == "Fire")
        {
            if (randomSelection == "Water")
            {
                this.IsPlayerWinner = false;
            }
            else
            {
                this.IsPlayerWinner = true;
            }
        }

        // Set the outcome for the player
        string outcomeText;
        if (IsPlayerWinner == null)
        {
            outcomeText = "It's a draw!";
        }
        else if (IsPlayerWinner.GetValueOrDefault())
        {
            outcomeText = "Hooray! You win!";
        }
        else
        {
            outcomeText = "Sorry, you lose!";
        }

        this.OutcomeText.text = outcomeText;
        this.OutcomeText.gameObject.SetActive(true);
    }
}
