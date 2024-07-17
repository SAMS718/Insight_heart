using UnityEngine;

public class CanvasTimerUpdate : MonoBehaviour
{
    public float duration = 10f; // Time to display the canvas (seconds)
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= duration)
        {
            gameObject.SetActive(false); // Hide the canvas
        }
    }
}
