using UnityEngine;

public class CTU2 : MonoBehaviour
{
    public float endTimer = 10f; // Time to hide the canvas (seconds)
    private float startTimer = 5f; // Time to start displaying the canvas (seconds)
    private bool canvasShown = false;

    void Update()
    {
        if (!canvasShown && Time.time >= startTimer)
        {
            gameObject.SetActive(true); // Display the canvas
            canvasShown = true;
        }

        if (Time.time >= endTimer)
        {
            gameObject.SetActive(false); // Hide the canvas
        }
    }
}
