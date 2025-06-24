using UnityEngine;

public class FollowGrabbedObject : MonoBehaviour
{
    public Transform target; // The grabbed object

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position;
            transform.rotation = target.rotation;
        }
    }
}
