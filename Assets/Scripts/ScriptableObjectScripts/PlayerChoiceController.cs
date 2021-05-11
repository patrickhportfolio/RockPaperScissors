using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChoiceController : MonoBehaviour
{
    public GameObject PlayerChoice;

    public void SetPlayerChoice(GameObject gameObject)
    {
        this.PlayerChoice = gameObject;
    }
}
