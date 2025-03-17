using UnityEngine;
using System.Collections.Generic;

public class linenew1 : MonoBehaviour
{
    public Transform target; // The object to follow
    private LineRenderer lineRenderer;
    private List<Vector3> points = new List<Vector3>();

    void Start()
    {
        // Get or add a LineRenderer component
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
            lineRenderer = gameObject.AddComponent<LineRenderer>();

        // Line Renderer settings
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount = 0;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default")); // Default material
    }

    void Update()
    {
        if (target != null)
        {
            // Add the target's position to the line
            points.Add(target.position);
            lineRenderer.positionCount = points.Count;
            lineRenderer.SetPositions(points.ToArray());
        }
    }
}
