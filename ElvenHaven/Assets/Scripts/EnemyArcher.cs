using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : MonoBehaviour
{

    public Transform target;
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public float firetime = 5.0f;
    public float nextfire;
    public bool spottingenemy = false;

    private void Start()
    {
        print("hey");
        nextfire = Time.time;
        if (target != null)
        {
            Vector3 currentPosition = transform.position;
            Vector3 targetPosition = target.position;

            float dist = Vector3.Distance(transform.position, target.position);

            if (dist < 15)
            {
                
                spottingenemy = true;
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
    public void Update()
    {
            Timetofire();
    }

    private void Shoot()
    {

    }
    public void Timetofire()
    {
        if (Time.time > nextfire)
        {
            //transform.parent.GetComponent<Animator>().SetBool("Crossbow shoot",true);
            Vector3 bulletPosition = shootPoint.position;
            Quaternion bulletRotation = shootPoint.rotation;
            Instantiate(bulletPrefab, bulletPosition, bulletRotation);
            nextfire = Time.time + firetime;
            //transform.parent.GetComponent<Animator>().SetBool("Crossbow shoot",false);
        }
    }
}
