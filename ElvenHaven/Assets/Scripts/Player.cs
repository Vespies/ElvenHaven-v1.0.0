using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;
    public UnityEvent OnPause;
    private Animator gunAnim;

    private void Start()
    {
        gunAnim = GetComponent<Animator>();
        Time.timeScale = 1;
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
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
    public void FireRepeaterCrossbow2()
    {
        if (transform.GetComponentInChildren<WeaponRepeaterCrossbow>() != null)
        {
            transform.GetComponentInChildren<WeaponRepeaterCrossbow>().Fire2();
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
    public void FireRepeaterCrossbow3()
    {
        if (transform.GetComponentInChildren<WeaponRepeaterCrossbow>() != null)
        {
            transform.GetComponentInChildren<WeaponRepeaterCrossbow>().Fire3();
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
    public void FireLongbow()
    {
        if (transform.GetComponentInChildren<Weapon>() != null)
        {
            transform.GetComponentInChildren<Weapon>().Fire();
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
    public void FireHandCrossbow1()
    {
        if (transform.GetComponentInChildren<WeaponHandCrossbows>() != null)
        {
            transform.GetComponentInChildren<WeaponHandCrossbows>().Fire1();
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
    public void FireHandCrossbow2()
    {
        if (transform.GetComponentInChildren<WeaponHandCrossbows>() != null)
        {
            transform.GetComponentInChildren<WeaponHandCrossbows>().Fire2();
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
