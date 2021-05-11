using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementClickComponent : MonoBehaviour, IClickableObject
{
    public string ChoiceValue;

    public void MouseClick()
    {
        // Change the object's material
        var matChangeComp = this.gameObject.GetComponent<MaterialChangeComponent>();
        if (matChangeComp != null)
        {
            // Reset all of the choices to prevent multiple highlights
            this.gameObject.GetComponentInParent<ElementSelectController>().UnselectPreviousElement();
            
            // Then change the material for the latest selection
            matChangeComp.ChangeMaterial();
        }

        // Set the player's choice for outcome determination once timer expires
        this.gameObject.GetComponentInParent<ElementSelectController>().PlayerChoice = this.ChoiceValue;
    }
}
