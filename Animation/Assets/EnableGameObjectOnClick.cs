using UnityEngine;

public class EnableGameObjectOnClick : MonoBehaviour
{
    public GameObject objectToEnable; // Assign in Inspector

    public void EnableObject()
    {
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true);
        }
    }
}
