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
        //gets the animation
        gunAnim = GetComponent<Animator>();
        //makes sure game is not paused
        Time.timeScale = 1;
    }

    private void Update()
    {
        //everytime left mouse button is paused, enables animation for 3 firing modes
        if (Input.GetMouseButton(0))
        {
            gunAnim.SetBool("isFiring", true);
            gunAnim.SetBool("isFiringHand", true);
            gunAnim.SetBool("isFiringRepeater", true);
        }
        else
        {
            //disables the firing modes if nothing is pressed
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
        //if this component is currently active make the script in a child shoot, also play a sound
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
        //if this component is currently active make the script in a child shoot, also play a sound
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
        //if this component is currently active make the script in a child shoot, also play a sound
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
        //if this component is currently active make the script in a child shoot, also play a sound
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
        //if this component is currently active make the script in a child shoot, also play a sound
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
        //if this component is currently active make the script in a child shoot, also play a sound
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
