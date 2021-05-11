using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Assets/Events/BaseEvent")]
public class BaseEvent : ScriptableObject
{
    public List<BaseEventListener> Listeners = new List<BaseEventListener>();

    public virtual void Raise()
    {
        foreach (var listener in Listeners)
        {
            listener.OnEventRaised();
        }
    }

    public void RegisterListener(BaseEventListener listener)
    {
        Listeners.Add(listener);
    }

    public void UnregisterListener(BaseEventListener listener)
    {
        Listeners.Remove(listener);
    }	
}
