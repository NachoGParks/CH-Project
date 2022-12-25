using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSoundPLS : MonoBehaviour
{
    public AudioSource shootingSound;

    void Start()
    {
        shootingSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootingSound.Play();

        }
    }
}
