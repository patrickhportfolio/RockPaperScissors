using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementDeselectController : MonoBehaviour
{
    public void ResetElements()
    {
        var childComponents = this.GetComponentsInChildren<SOMaterialChangeComponent>();
        foreach (var comp in childComponents)
        {
            comp.ResetMaterial();
        }
    }
}
