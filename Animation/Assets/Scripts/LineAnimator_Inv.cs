using UnityEngine;
using System.Collections;

public class LineAnimator_Inv : MonoBehaviour {
    [SerializeField] private float animationDuration = 5f;

    private LineRenderer lineRenderer;
    private Vector3[] linePoints;
    private int pointsCount;

    private void Start() {
        lineRenderer = GetComponent<LineRenderer>();

        // Store a copy of lineRenderer's points in linePoints array
        pointsCount = lineRenderer.positionCount;
        linePoints = new Vector3[pointsCount];
        for (int i = 0; i < pointsCount; i++) {
            linePoints[i] = lineRenderer.GetPosition(i);
        }

        StartCoroutine(AnimateLineReverse());
    }

    private IEnumerator AnimateLineReverse() {
        float segmentDuration = animationDuration / pointsCount;

        // Initialize all points to the last one (end point visually)
        for (int i = 0; i < pointsCount; i++) {
            lineRenderer.SetPosition(i, linePoints[pointsCount - 1]);
        }

        for (int i = pointsCount - 1; i > 0; i--) {
            float startTime = Time.time;

            Vector3 startPosition = linePoints[i];
            Vector3 endPosition = linePoints[i - 1];

            Vector3 pos = startPosition;
            while (pos != endPosition) {
                float t = (Time.time - startTime) / segmentDuration;
                pos = Vector3.Lerp(startPosition, endPosition, t);

                // Animate all previous points (i-1 backward) to the interpolated position
                for (int j = 0; j < i; j++) {
                    lineRenderer.SetPosition(j, pos);
                }

                yield return null;
            }
        }
    }
}
