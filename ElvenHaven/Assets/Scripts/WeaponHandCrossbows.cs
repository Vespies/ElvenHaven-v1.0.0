using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandCrossbows : MonoBehaviour {


    public GameObject bulletPrefab;
    public Transform[] bulletSpawn1;
    public Transform[] bulletSpawn2;

    public void Fire1()
    {
        for (int i = 0; i < bulletSpawn1.Length; i++)
        {
            Instantiate(bulletPrefab, bulletSpawn1[i].position, bulletSpawn1[i].rotation);
        }

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
    public void Fire2()
    {
        for (int i = 0; i < bulletSpawn2.Length; i++)
        {
            Instantiate(bulletPrefab, bulletSpawn2[i].position, bulletSpawn2[i].rotation);
        }
    }
}
