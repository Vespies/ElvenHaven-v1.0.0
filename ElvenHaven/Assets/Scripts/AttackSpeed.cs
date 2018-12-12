using UnityEngine;

public class AttackSpeed : MonoBehaviour
{

    private float time = 3;

    private float speed = 0.1f;

    private float oldSpeed;

    void Start ()
    {
        oldSpeed = transform.GetComponentInChildren<Weapon>().fireTime;
        transform.GetComponentInChildren<Weapon>().fireTime = speed;
        Invoke("TimeOut", time);
    }
    void TimeOut()
    { 
        transform.GetComponentInChildren<Weapon>().fireTime = oldSpeed;
        Destroy(this);
    }
}
