using UnityEngine;

public class CanvasToggle : MonoBehaviour
{
    public Canvas targetCanvas;

    public void DisableCanvas()
    {
        if (targetCanvas != null)
        {
            targetCanvas.gameObject.SetActive(false);
        }
    }
}
