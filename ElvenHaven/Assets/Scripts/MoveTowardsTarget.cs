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
            transform.position = Vector3.MoveTowards(currentPosition, targetPosition, currentSpeed);
        }
    }


}
