using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform target;
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;

    public void Spawn()
    {
        //as long as the game is not paused
        if (Time.timeScale == 1)
            //if there is the hero object present
            if (target != null)
            {
                //gets position of both self and player
                Vector3 currentPosition = transform.position;
                Vector3 targetPosition = target.position;
                //calculates the distance between self and player
                float dist = Vector3.Distance(transform.position, target.position);

                //if player is close enough, spawns the given prefab
                if (dist < 14)
                {
                    Vector3 rotationInDegrees = transform.eulerAngles;
                    rotationInDegrees.z += adjustmentAngle;
                    Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
                    Instantiate(prefabToSpawn, transform.position, rotationInRadians);
                }
                //else does nothing
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
