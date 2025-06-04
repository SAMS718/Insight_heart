using UnityEngine;

public class XRPositionSetter : MonoBehaviour
{
    public GameObject originalXRSetup;

    public void SetTransformValues()
    {
        if (originalXRSetup != null)
        {
            // Set position
            originalXRSetup.transform.position = new Vector3(67.546f, 4.017f, 25.501f);

            // Set rotation
            originalXRSetup.transform.rotation = Quaternion.Euler(29.057f, 1.467f, 0f);

            // Set scale
            originalXRSetup.transform.localScale = new Vector3(9f, 9f, 9f);
        }
        else
        {
            Debug.LogWarning("Original XR Setup is not assigned.");
        }
    }
}
