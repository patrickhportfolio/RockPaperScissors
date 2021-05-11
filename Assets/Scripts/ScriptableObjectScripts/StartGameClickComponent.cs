using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameClickComponent : MonoBehaviour, IClickableObject
{
    public BaseEvent StartGameEvent;

    public void MouseClick()
    {
        this.StartGameEvent.Raise();
    }
}
