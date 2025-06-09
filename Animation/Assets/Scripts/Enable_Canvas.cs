using UnityEngine;

public class Enable_Canvas : MonoBehaviour
{
    public Canvas targetCanvas;

    public void EnableTargetCanvas()
    {
        if (targetCanvas != null)
            targetCanvas.gameObject.SetActive(true);
    }
}
