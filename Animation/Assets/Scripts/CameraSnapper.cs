using UnityEngine;
using UnityEngine.UI;

public class CameraSnapper : MonoBehaviour
{
    public Camera mainCamera;
    public Camera casualCamera;
    public Button snapButton;

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private bool isSnapped = false;

    void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;

        originalPosition = mainCamera.transform.position;
        originalRotation = mainCamera.transform.rotation;

        if (casualCamera != null)
            casualCamera.gameObject.SetActive(false); // Ensure it's off at start

        if (snapButton != null)
            snapButton.onClick.AddListener(ToggleCameraPosition);
    }

    void ToggleCameraPosition()
    {
        if (!isSnapped)
        {
            if (casualCamera != null)
            {
                casualCamera.gameObject.SetActive(true); // Enable just to read position

                // Snap main camera to casual camera
                mainCamera.transform.position = casualCamera.transform.position;
                mainCamera.transform.rotation = casualCamera.transform.rotation;

                casualCamera.gameObject.SetActive(false); // Turn off again to avoid dual render
            }
            isSnapped = true;
        }
        else
        {
            // Reset main camera to original state
            mainCamera.transform.position = originalPosition;
            mainCamera.transform.rotation = originalRotation;
            isSnapped = false;
        }
    }
}