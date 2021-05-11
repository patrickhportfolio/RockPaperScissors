using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementComponent : MonoBehaviour
{
    public ElementScriptableObject ElementScriptableObject;

    private Renderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        // Grab renderer and set the amterial to our SO StartMaterial
        this.Renderer = this.gameObject.GetComponent<Renderer>();
        this.Renderer.material = ElementScriptableObject.StartMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
