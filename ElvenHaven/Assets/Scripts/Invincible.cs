using UnityEngine;

public class Invincible : MonoBehaviour
{
    private float time = 5;
    void Start ()
    {
        transform.GetComponent<Collider2D>().enabled = false;
        Invoke("TimeOut", time);
    }
    void TimeOut()
    {
        transform.GetComponent<Collider2D>().enabled = true;
        Destroy(this);
    }
}
