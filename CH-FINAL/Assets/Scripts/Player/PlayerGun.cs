using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public float range = 30f;
    public GameObject rayCastStart;
    public GameObject impacto;
    public int ShotDamage;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Disparar();
            animator.SetBool("IsFiring", true);
        }
        else
        {
            animator.SetBool("IsFiring", false);
        }
    }

    void Disparar()
    {
        RaycastHit hit;
        if(Physics.Raycast(rayCastStart.transform.position, rayCastStart.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.CompareTag("Zombie"))
            {
                GameObject go = Instantiate(impacto, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy (go, 0.1f);
            }
        }
    }
}
