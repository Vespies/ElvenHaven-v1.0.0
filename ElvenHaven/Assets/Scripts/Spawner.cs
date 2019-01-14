using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform target;
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;

    public void Spawn ()
    {
        if (target != null)
        {
            Vector3 currentPosition = transform.position;
            Vector3 targetPosition = target.position;

            float dist = Vector3.Distance(transform.position, target.position);

            if (dist < 15)
            {
                Vector3 rotationInDegrees = transform.eulerAngles;
                rotationInDegrees.z += adjustmentAngle;
                Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
                Instantiate(prefabToSpawn, transform.position, rotationInRadians);
            }
            else
            {

            }


        }

	}
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
