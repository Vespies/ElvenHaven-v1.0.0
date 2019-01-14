using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour
{
    public Transform target; 
    public float speed = 5.0f;
    private void Update()
    {
        if (target != null)
        {
            Vector3 currentPosition = transform.position;
            Vector3 targetPosition = target.position;
            float currentSpeed = speed * 0.01f;

            float dist = Vector3.Distance(transform.position, target.position);

            if (dist < 1)
            {

            }
            else
            {
                if (dist > 16)
                {

                }
                else
                    transform.position = Vector3.MoveTowards(currentPosition, targetPosition, currentSpeed);
            }


        }

    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }


}
