﻿using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    void Start()
    {
        ChangeWeapon(0);
    }
    public void ChangeWeapon(int index)
    {
        if (index < transform.childCount)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (i == index)
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
                else 
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
    }
    public void AddWeapon(GameObject prefab)
    {
        GameObject weapon = Instantiate(prefab, transform.position, transform.rotation, transform);
        ChangeWeapon(weapon.transform.GetSiblingIndex());

        if (weapon.GetComponent<WeaponRepeaterCrossbow>() != null)
        {
            transform.parent.GetComponent<Animator>().SetTrigger("SwitchRepeater");
        }

        if (weapon.GetComponent<WeaponHandCrossbows>() != null)
        {
            transform.parent.GetComponent<Animator>().SetTrigger("SwitchHandCrossbows");
        }
        if (weapon.GetComponent<Weapon>() != null)
        {
            transform.parent.GetComponent<Animator>().SetTrigger("SwitchLongbow");
        }
    }
    private void Update()
    {

    }
}
