using UnityEngine;

[CreateAssetMenu(menuName = "Assets/Events/GameObjectEvent")]
public class GameObjectEvent : BaseEvent
{
    public void Raise(GameObject gameObject)
    {
        foreach (var listener in Listeners)
        {
            var actionListener = listener as GameObjectEventListener;
            actionListener.OnEventRaised(gameObject);
        }
    }
}
