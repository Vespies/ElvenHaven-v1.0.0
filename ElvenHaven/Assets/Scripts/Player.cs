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

    public void FireRepeaterCrossbow1()
    {
        if (transform.GetComponentInChildren<WeaponRepeaterCrossbow>() != null)
        {
            transform.GetComponentInChildren<WeaponRepeaterCrossbow>().Fire1();
        }
    }
    public void FireRepeaterCrossbow2()
    {
        if (transform.GetComponentInChildren<WeaponRepeaterCrossbow>() != null)
        {
            transform.GetComponentInChildren<WeaponRepeaterCrossbow>().Fire2();
        }
    }
    public void FireRepeaterCrossbow3()
    {
        if (transform.GetComponentInChildren<WeaponRepeaterCrossbow>() != null)
        {
            transform.GetComponentInChildren<WeaponRepeaterCrossbow>().Fire3();
        }
    }
    public void FireLongbow()
    {
        if (transform.GetComponentInChildren<Weapon>() != null)
        {
            transform.GetComponentInChildren<Weapon>().Fire();
        }
    }
    public void FireHandCrossbow1()
    {
        if (transform.GetComponentInChildren<WeaponHandCrossbows>() != null)
        {
            transform.GetComponentInChildren<WeaponHandCrossbows>().Fire1();
        }
    }
    public void FireHandCrossbow2()
    {
        if (transform.GetComponentInChildren<WeaponHandCrossbows>() != null)
        {
            transform.GetComponentInChildren<WeaponHandCrossbows>().Fire2();
        }
    }
}
