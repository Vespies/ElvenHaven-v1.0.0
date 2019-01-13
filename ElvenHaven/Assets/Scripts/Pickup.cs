using UnityEngine;
public enum PickupType
{
    Health,
    Damage,
    Invincible,
    AttackSpeed,
    MoveSpeed
}

public class Pickup : MonoBehaviour
{
    public PickupType pickupType;
    public int health = 10;

    private void OnTriggerEnter2D(Collider2D other)
    { 
        switch (pickupType)
        {
            case PickupType.Health:
                other.transform.SendMessage("TakeDamage", -health, SendMessageOptions.DontRequireReceiver);
                break;

            
            case PickupType.Damage:
                other.gameObject.AddComponent<DamageIncrease>();
                break;

            
            case PickupType.Invincible:
                other.gameObject.AddComponent<Invincible>();
                break;

            
            case PickupType.MoveSpeed:
                other.gameObject.AddComponent<SpeedBooster>();
                break;

            default:
                break;
        }
        Destroy(gameObject);
    }
}
