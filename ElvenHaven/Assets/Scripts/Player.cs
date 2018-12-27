using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;

    private Animator gunAnim;

    private void Start()
    {
      
        gunAnim = GetComponent<Animator>();
    }


    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gunAnim.SetBool("isFiring", true);
            gunAnim.SetBool("isFiringHand", true);
            gunAnim.SetBool("isFiringRepeater", true);
        }
        else 
        {
           gunAnim.SetBool("isFiring", false);
           gunAnim.SetBool("isFiringHand", false);
           gunAnim.SetBool("isFiringRepeater", false);
        }
    }
    public void SendHealthData(int health)
    {

        if (OnUpdateHealth != null)
        {
            OnUpdateHealth(health);
        }

    }

    public void Fire()
    {
        transform.GetComponentInChildren<Weapon>().Fire();
        transform.GetComponentInChildren<WeaponRepeaterCrossbow>().Fire();
        transform.GetComponentInChildren<WeaponHandCrossbows>().Fire();
    }
}
