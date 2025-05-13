using UnityEngine;
using UnityEngine.UI;

public class TriggerButtonFrom3D : MonoBehaviour
{
    public Button uiButton;

    void OnMouseDown() // Works with clicks or touches if collider is present
    {
        if (uiButton != null)
        {
            uiButton.onClick.Invoke(); // Triggers the button’s onClick
        }
    }
}