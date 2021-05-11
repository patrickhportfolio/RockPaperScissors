using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementGeneratorController : MonoBehaviour
{
    public List<ElementScriptableObject> ElementScriptableObjects;

    public GameObject ElementPrefab;

    // Start is called before the first frame update
    void Start()
    {
        var numOfCreatedElements = 0;
        foreach (var element in this.ElementScriptableObjects)
        {
            // Create a new gameobejct from the prefab
            var createdElement = Instantiate(ElementPrefab);
            createdElement.name = $"{element.Name}Cube";

            // Set the elementSO to the value we're looping on
            var elementComponent = createdElement.GetComponent<ElementComponent>();
            elementComponent.ElementScriptableObject = element;

            // Set world position based on number so they are spaced out
            var positionVector = new Vector3(numOfCreatedElements * 2, 0.5f, 0);
            createdElement.transform.position = positionVector;

            // Set the parent object
            createdElement.transform.SetParent(this.transform);

            // Increase counter
            numOfCreatedElements++;
        }
    }
}
