using System.Collections;
using UnityEngine;

public class SequentialAnimationTrigger : MonoBehaviour
{
    public Animator firstAnimator;   // Animator for first 3D object
    public string firstAnimation;    // Name of the first animation

    public Animator secondAnimator;  // Animator for second 3D object
    public string secondAnimation;   // Name of the second animation

    public void PlaySequentialAnimations()
    {
        StartCoroutine(PlayAnimations());
    }

    private IEnumerator PlayAnimations()
    {
        // Play first animation
        firstAnimator.Play(firstAnimation);

        // Wait 8 seconds
        yield return new WaitForSeconds(7f);

        // Play second animation
        secondAnimator.Play(secondAnimation);
    }
}
