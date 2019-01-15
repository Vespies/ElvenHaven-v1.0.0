using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour
{
    public Transform target; 
    public float speed = 5.0f;
    private void Update()
    {
        //as long as the game is not paused
        if (Time.timeScale ==1)
            //if there is the hero object present
            if (target != null)
            {
                //gets position of both self and player
                Vector3 currentPosition = transform.position;
                Vector3 targetPosition = target.position;
                //sets the movement speed of the enemy
                float currentSpeed = speed * 0.01f;
                //calculates the distance between self and player
                float dist = Vector3.Distance(transform.position, target.position);

                //if its less than 1 it stops moving to avoid bumping into player
                if (dist < 1)
                {

                }
                else
                {
                    //if its further than 1 but also more than 16 it does nothing for the same reason
                    if (dist > 16)
                    {

                    }
                    else
                    {
                        //in other cases it moves towards the player position and enables the audio source which acknowledges the player of the possible threats
                        transform.position = Vector3.MoveTowards(currentPosition, targetPosition, currentSpeed);
                        GetComponent<AudioSource>().enabled = true;
                    }
                }


            }

    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }


}
