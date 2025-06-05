using UnityEngine;

public class XRRigSwitcher : MonoBehaviour
{
    public GameObject xrRig1; // Default active rig
    public GameObject xrRig2; // Default inactive rig

    private bool isUsingRig1 = true;

    // Call this on your button's OnClick()
    public void ToggleRig()
    {
        if (xrRig1 == null || xrRig2 == null)
        {
            Debug.LogError("XR rigs not assigned!");
            return;
        }

        if (isUsingRig1)
        {
            xrRig1.SetActive(false);
            xrRig2.SetActive(true);
        }
        else
        {
            xrRig2.SetActive(false);
            xrRig1.SetActive(true);
        }

        isUsingRig1 = !isUsingRig1;
    }
}
