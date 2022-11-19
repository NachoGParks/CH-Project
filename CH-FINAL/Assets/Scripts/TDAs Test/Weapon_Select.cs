using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Select : MonoBehaviour
{
    public GameObject[] weapons;

    void Start()
    {
        
    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapons[weapons.Length - 4].gameObject.SetActive(true);
            Debug.Log("You have selected the Rifle");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapons[weapons.Length - 3].gameObject.SetActive(true);
            Debug.Log("You have selected the Pistol");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weapons[weapons.Length - 2].gameObject.SetActive(true);
            Debug.Log("You have selected the Shotgun");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            weapons[weapons.Length - 1].gameObject.SetActive(true);
            Debug.Log("You have selected the SubMachineGun");
        }




    }
}
