using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSelectController : MonoBehaviour
{
    public string PlayerChoice;

    public void UnselectPreviousElement()
    {
        var childrenObjects = this.gameObject.GetComponentsInChildren<MaterialChangeComponent>();
        foreach (var child in childrenObjects)
        {
            child.ResetMaterial();
        }
    }
}
