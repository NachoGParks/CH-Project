using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour

{   //VARIABLES

    //Stats
    public NavMeshAgent agent;
    public float demonHP = 90f;    
    public bool demonDead = false;
    private Animator animator;    

    //Ataque
    private GameObject target;    
    public PlayerManager playerManager;
    public float demonDamage = 10f;
    public float distToPlayer;
    public float timeToShoot = 3f;
    public float timeToShootLeft = 0f;

    //Defensa
    public float radius = 1f;
    public PlayerGun playerGUN;


    //FUNCIONES

    //Movimiento
    public void demonMovement()
    {
        if (agent != null)
        {
            agent.SetDestination(target.transform.position);
        }
    }
    public void CheckDistance()
    {
        distToPlayer = Vector3.Distance(target.transform.position, transform.position);
    }

    //Ataque
    public void Attack()
    {
        if (!demonDead)
        {
            timeToShootLeft -= Time.deltaTime;
            if (timeToShootLeft <= 0f && distToPlayer <= 1.5f)
            {                
                target.GetComponent<PlayerManager>().playerHP -= demonDamage;
                animator.SetBool("isAttacking", true);
                timeToShootLeft = timeToShoot;                
            }
            else
            {
                animator.SetBool("isAttacking", false);
            }
        }
    }

    //Daño recibido
    public void OnCollisionEnter(Collision collision)
    {
        if (demonDead != true)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider nearbyObject in colliders)
            {
                if (nearbyObject.tag == "Impact")
                {
                    demonHP -= playerGUN.ShotDamage;
                    Debug.Log("Enemy HP: " + demonHP);

                    if (demonHP <= 0)
                    {
                        Debug.Log("Enemigo Abatido");
                        demonDead = true;
                        InGameHUD.dead_Zombies++;
                    }
                }
            }
        }
    }

    //Muerte
    public void enemyDies()
    {
        if (demonDead)
        {
            Destroy(agent);
            Destroy(gameObject.GetComponent<CapsuleCollider>());
        }
    }

    void Start()
    {
        target = GameObject.FindWithTag("Player");
        animator = GetComponent<Animator>();
    }

    void Update()
    {        
        CheckDistance();
        Attack();
        demonMovement();        
        enemyDies();        
    }
}
