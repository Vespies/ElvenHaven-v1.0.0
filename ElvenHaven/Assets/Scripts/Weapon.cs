using UnityEngine;


public class Weapon : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    public Transform[] bulletSpawn;

    public void Fire()
    {
        for (int i = 0; i < bulletSpawn.Length; i++)
        {
            Instantiate(bulletPrefab, bulletSpawn[i].position, bulletSpawn[i].rotation);
        }

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
} 
