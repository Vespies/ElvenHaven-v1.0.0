using UnityEngine;

public class SmoothLookAtTarget : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 0.0f;

    private void Update()
    {
        if (target != null)
        {
            Vector3 currentPosition = transform.position;
            Quaternion currentRotation = transform.rotation;
            Vector3 targetPosition = target.position;
            Vector3 difference = targetPosition - currentPosition;
            float angleZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            Vector3 rotationInDegrees = new Vector3();

            rotationInDegrees.x = 0;
            rotationInDegrees.y = 0;
            rotationInDegrees.z = angleZ + adjustmentAngle;

            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
            float rotationSpeed = Time.deltaTime * smoothing;
            transform.rotation = Quaternion.Lerp(currentRotation, rotationInRadians, rotationSpeed);
        }
    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
