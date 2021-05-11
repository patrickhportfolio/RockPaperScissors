using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangeComponent : MonoBehaviour
{
    public Material StartMaterial;

    public Material ChangeToMaterial;

    private Renderer Renderer;

    // Start is called before the first frame update
    void Start()
    {
        this.Renderer = this.gameObject.GetComponent<Renderer>();

        if (StartMaterial != null)
        {
            this.Renderer.material = StartMaterial;
        }
        else
        {
            this.StartMaterial = this.Renderer.material;
        }
    }

    public void ChangeMaterial()
    {
        if (ChangeToMaterial != null)
        {
            this.Renderer.material = ChangeToMaterial;
        }
    }

    public void ChangeMaterial(Material material)
    {
        this.ChangeToMaterial = material;
        this.ChangeMaterial();
    }

    public void ResetMaterial()
    {
        this.Renderer.material = StartMaterial;
    }
}
