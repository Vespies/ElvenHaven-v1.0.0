using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    private readonly int health = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("TakeDamage", -health, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
