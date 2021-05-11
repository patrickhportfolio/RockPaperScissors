using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOMaterialChangeComponent : MonoBehaviour
{
    private ElementScriptableObject ElementScriptableObject;

    private Renderer Renderer;

    // Start is called before the first frame update
    void Start()
    {
        this.Renderer = this.GetComponent<Renderer>();
        this.ElementScriptableObject = this.GetComponent<ElementComponent>().ElementScriptableObject;
    }

    public void SetFocusedMaterial()
    {
        this.Renderer.material = this.ElementScriptableObject.FocusedMaterial;
    }

    public void ResetMaterial()
    {
        this.Renderer.material = this.ElementScriptableObject.StartMaterial;
    }
}
