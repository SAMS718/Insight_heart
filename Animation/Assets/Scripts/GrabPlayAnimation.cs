using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabPlayAnimation : MonoBehaviour
{
    public Animator animator;         // Animator attached to your object
    public string animationTrigger;   // The trigger or bool parameter name in Animator

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrabbed);
            grabInteractable.selectExited.AddListener(OnReleased);
        }
    }

    void OnGrabbed(SelectEnterEventArgs args)
    {
        if (animator != null)
        {
            animator.SetBool(animationTrigger, true); // Start animation
        }
    }

    void OnReleased(SelectExitEventArgs args)
    {
        if (animator != null)
        {
            animator.SetBool(animationTrigger, false); // Stop animation
        }
    }
}
