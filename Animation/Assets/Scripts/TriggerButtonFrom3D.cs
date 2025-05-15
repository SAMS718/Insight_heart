using UnityEngine;
using UnityEngine.UI;

public class TriggerButtonFrom3D : MonoBehaviour
{
    public Button uiButton;

    private void OnTriggerEnter(Collider other)
    {
        if (uiButton != null)
        {
            uiButton.onClick.Invoke(); // Triggers the button’s onClick
        }
    }    
 /*   void OnMouseDown() // Works with clicks or touches if collider is present
    {
        if (uiButton != null)
        {
            uiButton.onClick.Invoke(); // Triggers the button’s onClick
        }
    }*/
}