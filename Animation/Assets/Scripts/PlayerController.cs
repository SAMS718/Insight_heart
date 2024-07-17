using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float rayLength;
    public LayerMask layermask;

    // Update is called once per frame
    private void Update()
    {
        // Check if the left mouse button is pressed and the pointer is not over a UI element
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Check if the ray hits an object within the specified ray length and layer mask
            if (Physics.Raycast(ray, out hit, rayLength, layermask))
            {
                // Check if the hit object has an Animator component
                Animator hitAnimator = hit.collider.gameObject.GetComponent<Animator>();
                if (hitAnimator != null)
                {
                    // Play the animation on the hit object's Animator component
                    hitAnimator.Play("Canvas");
                    Debug.Log(hit.collider.name);
                }
            }
        }
    }
}
