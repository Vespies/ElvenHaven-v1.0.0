using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandCrossbows : MonoBehaviour {


    public GameObject bulletPrefab;
    public Transform[] bulletSpawn;
    public float fireTime = 0.5f;
    private bool isFiring = false;
    private bool isFiringHand = false;
    private bool isFiringRepeater = false;

    private Animator playerstate;

    private void Start()
    {
        playerstate = GetComponent<Animator>();
        playerstate.SetBool("SwitchHandCrossbow", true);
    }

    public void Fire()
    {

        isFiringHand = true;
        for (int i = 0; i < bulletSpawn.Length; i++)
        {
            Instantiate(bulletPrefab, bulletSpawn[i].position, bulletSpawn[i].rotation);
        }
        //Vector3 bulletPosition = bulletSpawn.position;
        //Quaternion bulletRotation = bulletSpawn.rotation;

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        Invoke("SetFiring", fireTime);
    }

    private void SetFiring()
    {
        isFiring = false;
        isFiringHand = false;
        isFiringRepeater = false;
    }
}
