using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : MonoBehaviour
{

    public Transform target;
    public Transform shootPoint;
    public GameObject bulletPrefab;
    private float firetime = 2.0f;
    private float nextfire;

    private void Start()
    {
        //nextfire = time in seconds since the beginning of the game
        nextfire = Time.time;
    }
    public void Update()
    {
        //runs this every frame
        Timetofire();
    }
    private void Shoot()
    {

    }
    public void Timetofire()
    {
        if (Time.time > nextfire)
        {
            //standard shooting code, making sure the enemy knows where to look and what to shoot
            Vector3 bulletPosition = shootPoint.position;
            Quaternion bulletRotation = shootPoint.rotation;
            Instantiate(bulletPrefab, bulletPosition, bulletRotation);
            //nextfire becomes greater than time therefore its gonna take some frames until the enemy shoots again
            nextfire = Time.time + firetime;
        }
    }
}
