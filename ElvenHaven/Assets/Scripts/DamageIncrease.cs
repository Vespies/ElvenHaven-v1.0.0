using UnityEngine;

public class DamageIncrease : MonoBehaviour
{
    private float time = 5; 
    private GameObject oldPrefab;

    void Start()
    {
        oldPrefab = transform.GetComponentInChildren<Weapon>().bulletPrefab;
        transform.GetComponentInChildren<Weapon>().bulletPrefab = Resources.Load("Bullet Damage increase") as GameObject;
        Invoke("TimeOut", time);
    }

    void TimeOut()
    {
        transform.GetComponentInChildren<Weapon>().bulletPrefab = oldPrefab;
        Destroy(this);
    }
}
