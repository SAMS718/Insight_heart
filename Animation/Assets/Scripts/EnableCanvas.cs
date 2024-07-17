using UnityEngine;

public class EnableCanvas : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // Get the Canvas component from this GameObject
    Canvas canvas = GetComponent<Canvas>();

    // Check if the canvas is disabled
    if (!canvas.isActiveAndEnabled)
    {
      // Enable the canvas
      canvas.enabled = true;
    }
  }
}
