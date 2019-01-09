using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : MonoBehaviour
{

    public Transform target;
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public float firetime = 5.0f;

    private void Start()
    {
        if (target != null)
        {
            Vector3 currentPosition = transform.position;
            Vector3 targetPosition = target.position;

            float dist = Vector3.Distance(transform.position, target.position);

            if (dist < 1)
            {

            }
            else
            {
                if (dist > 20)
                {


                }
                else
                    while (true)
                    {
                        Invoke("Shoot", firetime);
                    }    
            }
        }
    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    private void Shoot()
    {
        Vector3 bulletPosition = shootPoint.position;
        Quaternion bulletRotation = shootPoint.rotation;
        Instantiate(bulletPrefab, bulletPosition, bulletRotation);
    }
}
