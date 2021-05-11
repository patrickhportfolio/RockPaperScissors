using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Left click
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // If we've successfully hit an object
            if (Physics.Raycast(ray, out hit))
            {
                // Determine if the object is a clickable object
                var clickComponent = hit.transform.GetComponent<IClickableObject>();
                if (clickComponent != null)
                {
                    // Trigger the MouseClick function
                    clickComponent.MouseClick();
                }
            }
        }
    }
}
