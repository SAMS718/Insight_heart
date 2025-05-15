using UnityEngine;
using UnityEngine.XR.Management;
using System.Collections;


public class ForceXRInit : MonoBehaviour
{
    IEnumerator Start()
    {
        XRGeneralSettings.Instance.Manager.InitializeLoaderSync();
        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            Debug.LogError("Failed to initialize XR Loader");
        }
        else
        {
            XRGeneralSettings.Instance.Manager.StartSubsystems();
        }
        yield return null;
    }
}
