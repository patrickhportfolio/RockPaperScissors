using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOElementClickComponent : MonoBehaviour, IClickableObject
{
    public GameObjectEvent ElementClickEvent;

    public void MouseClick()
    {
        // Set the player's choice for outcome determination once timer expires
        this.ElementClickEvent.Raise(this.gameObject);

        // Change the object's material
        var matChangeComp = this.gameObject.GetComponent<SOMaterialChangeComponent>();
        if (matChangeComp != null)
        {
            // Then change the material for the latest selection
            matChangeComp.SetFocusedMaterial();
        }
    }
}
