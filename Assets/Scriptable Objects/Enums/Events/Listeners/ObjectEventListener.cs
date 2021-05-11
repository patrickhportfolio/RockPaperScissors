using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ObjectEventListener<T> : BaseEventListener
{
    public UnityEvent<T> ObjectResponse;

    public void OnEventRaised(T eventObject)
    {
        base.OnEventRaised();
        ObjectResponse.Invoke(eventObject);
    }
}
