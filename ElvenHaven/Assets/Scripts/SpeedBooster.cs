using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    private float time = 3;
    private float speedIncrease = 5;
    private float oldSpeed;

    void Start ()
    {
        oldSpeed = transform.GetComponent<TopDownCharacterController2D>().speed;
        transform.GetComponent<TopDownCharacterController2D>().speed += speedIncrease;
        Invoke("TimeOut", time);
	}
    void TimeOut()
    {
        transform.GetComponent<TopDownCharacterController2D>().speed = oldSpeed;
        Destroy(this);
    }
}
