using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Assets/ScriptableObjects/Element")]
public class ElementScriptableObject : ScriptableObject
{
    public string Name;

    public Material StartMaterial;

    public Material FocusedMaterial;
}
