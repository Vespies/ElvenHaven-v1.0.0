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
    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            ChangeWeapon(0); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            ChangeWeapon(1); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            ChangeWeapon(2); 
        }
    }
}
