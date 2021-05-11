using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SOGameManager : MonoBehaviour
{
    public Text ComputerChoiceText;

    public Text OutcomeText;

    // Start is called before the first frame update
    void Start()
    {
        this.ComputerChoiceText.gameObject.SetActive(false);
        this.OutcomeText.gameObject.SetActive(false);
    }
}
