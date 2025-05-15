using UnityEngine;

public class ButtonAnimationControl : MonoBehaviour
{
    public Animator targetAnimator; // Assign in Inspector

    void Start()
    {
        if (targetAnimator != null)
        {
            targetAnimator.speed = 0f; // Start paused
        }
    }

    // Call this with true on PointerDown, false on PointerUp
    public void SetAnimationPlaying(bool isPlaying)
    {
        if (targetAnimator != null)
        {
            targetAnimator.speed = isPlaying ? 1f : 0f;
        }
    }
}
