using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]



public class Bullet : MonoBehaviour
{
    
    public float moveSpeed = 100;
    public int damage = 1;

    private void Start()
    {
       
        Vector3 facingDirection = transform.up;
        Vector3 velocity = facingDirection * moveSpeed;
        GetComponent<Rigidbody2D>().AddForce(velocity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        string methodName = "TakeDamage";
        SendMessageOptions messageOptions = SendMessageOptions.DontRequireReceiver;
        Transform hitObject = other.transform;
        hitObject.SendMessage(methodName, damage, messageOptions);
        Die();
    }

    private void OnBecameInvisible()
    {
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
