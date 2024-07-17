using UnityEngine;

public class CanvasTimerUpdate1 : MonoBehaviour
{
    public float startTime = 0f;  // Time the canvas starts displaying (seconds)
    public float endTime = 0f;    // Time the canvas should be hidden (seconds)

    void Start()
    {
        // Start time check and error handling
        if (startTime >= endTime)
        {
            Debug.LogError("Start time cannot be greater than or equal to end time!");
            return;
        }

        // Initially hide the canvas only if start time is in the future
        if (startTime > Time.time)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

    void Update()
    {
        // Check if start time has been reached
        if (Time.time >= startTime)
        {
            gameObject.SetActive(true);
        }

        // Check if end time has been reached
        if (Time.time >= endTime)
        {
            gameObject.SetActive(false);
        }
    }
}