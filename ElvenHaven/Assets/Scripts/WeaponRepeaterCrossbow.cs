using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRepeaterCrossbow : MonoBehaviour {


    public GameObject bulletPrefab;
    public Transform[] bulletSpawn1;
    public Transform[] bulletSpawn2;
    public Transform[] bulletSpawn3;

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
        for(int i = 0; i < bulletSpawn2.Length; i++)
        {
            Instantiate(bulletPrefab, bulletSpawn2[i].position, bulletSpawn2[i].rotation);
        }
    }
    public void Fire3()
    {
        for(int i = 0; i < bulletSpawn3.Length; i++)
        {
            Instantiate(bulletPrefab, bulletSpawn3[i].position, bulletSpawn3[i].rotation);
        }
    }
}
